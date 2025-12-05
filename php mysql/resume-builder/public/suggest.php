<?php
// public/suggest.php
require_once __DIR__ . '/../config/db.php';

$action = $_GET['action'] ?? '';
$payload = json_decode(file_get_contents('php://input'), true);

if ($action === 'accepted') {
  trackSuggestion($payload, true);
  echo json_encode(['ok'=>true]); exit;
}
if ($action === 'removed') {
  trackSuggestion($payload, false);
  echo json_encode(['ok'=>true]); exit;
}

$industry = strtolower(trim($payload['industry'] ?? ''));
$role = strtolower(trim($payload['job_title'] ?? ''));

// seed library
$seed = [
  'technology' => [
    'software engineer' => [
      "Designed and shipped features impacting thousands of users",
      "Improved API performance by 35% through query optimization",
      "Implemented CI/CD pipelines reducing deployment time by 60%",
      "Collaborated cross-functionally to align technical and business goals",
      "Wrote unit and integration tests to maintain 90%+ coverage"
    ],
    'integration developer' => [
      "Built and maintained REST/SOAP integrations with robust error handling",
      "Optimized message throughput using async patterns and queues",
      "Improved observability with structured logging and metrics",
      "Hardened security with OAuth 2.0 and scoped tokens",
      "Authored integration specs and sequence diagrams"
    ]
  ],
  'finance' => [
    'business analyst' => [
      "Mapped processes and reduced cycle times by 20%",
      "Translated requirements into user stories and acceptance criteria",
      "Built dashboards to track KPIs and trends",
      "Facilitated workshops and stakeholder alignment",
      "Documented risks and mitigation strategies"
    ]
  ]
];

$suggestions = [];
$lib = $seed[$industry] ?? [];
$roleSug = $lib[$role] ?? [];

if (empty($roleSug)) {
  $roleSug = [
    "Delivered measurable outcomes aligned to key KPIs",
    "Used data to drive decisions and prioritize work",
    "Communicated clearly with stakeholders and teammates",
    "Documented solutions and maintained high code quality",
    "Mentored peers and contributed to team best practices"
  ];
}

// Blend in learned suggestions (top accepted)
$learned = fetchLearned($industry, $role);
$suggestions = array_map(function($t){ return ['text'=>$t]; }, array_slice(array_unique(array_merge($learned, $roleSug)),0,8));

echo json_encode(['suggestions'=>$suggestions]);

function fetchLearned($industry,$role){
  global $pdo;
  $stmt = $pdo->prepare("SELECT suggestion FROM suggestion_stats WHERE industry=? AND role=? ORDER BY accepted_count DESC, last_used DESC LIMIT 5");
  $stmt->execute([$industry,$role]);
  return array_map(fn($r)=>$r['suggestion'], $stmt->fetchAll());
}

function trackSuggestion($p, $accepted){
  global $pdo;
  $industry = strtolower(trim($p['industry'] ?? ''));
  $role = strtolower(trim($p['role'] ?? ''));
  $suggestion = trim($p['suggestion'] ?? '');
  if (!$suggestion) return;
  // upsert
  $stmt = $pdo->prepare("SELECT id FROM suggestion_stats WHERE industry=? AND role=? AND suggestion=?");
  $stmt->execute([$industry,$role,$suggestion]);
  $row = $stmt->fetch();
  if ($row){
    $col = $accepted ? 'accepted_count' : 'removed_count';
    $pdo->prepare("UPDATE suggestion_stats SET $col = $col + 1, last_used=CURRENT_TIMESTAMP WHERE id=?")->execute([$row['id']]);
  } else {
    $pdo->prepare("INSERT INTO suggestion_stats (industry,role,suggestion,".($accepted?'accepted_count':'removed_count').") VALUES (?,?,?,1)")
      ->execute([$industry,$role,$suggestion]);
  }
}
