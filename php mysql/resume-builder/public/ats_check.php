<?php
// public/ats_check.php
require_once __DIR__ . '/../config/db.php';

$payload = json_decode(file_get_contents('php://input'), true);

$jd = strtolower($payload['job_description'] ?? '');
$skills = array_filter(array_map('trim', explode(',', strtolower($payload['skills'] ?? ''))));
$baseKeywords = array_unique(array_merge($skills, extractKeywords($jd)));

$experience = json_decode($payload['experience'] ?? '[]', true);
$education  = json_decode($payload['education'] ?? '[]', true);

$bodyText = strtolower(
  ($payload['summary'] ?? '') . ' ' .
  implode(' ', $skills) . ' ' .
  flattenBullets($experience) . ' ' .
  flattenEducation($education)
);

$present = [];
$missing = [];
foreach($baseKeywords as $kw){
  if (!$kw) continue;
  (strpos($bodyText, $kw) !== false) ? $present[] = $kw : $missing[] = $kw;
}

// Simple ATS scoring: coverage + structure + length
$coverage = count($present) / max(count($baseKeywords),1);
$structure = assessStructure($payload);
$length = strlen(trim(($payload['summary'] ?? ''))) >= 240 ? 1 : 0.6;

$score = (int) round(($coverage*0.6 + $structure*0.3 + $length*0.1) * 100);

$recs = [];
if ($coverage < 0.7) $recs[] = "Add missing critical keywords into skills or bullets";
if ($structure < 0.9) $recs[] = "Use standard section headers (Summary, Skills, Experience, Education)";
if ($length < 0.9) $recs[] = "Expand summary with quantified impact";

echo json_encode([
  'score' => $score,
  'missing' => array_slice($missing,0,20),
  'recommendations' => $recs
]);

function extractKeywords($text){
  $text = preg_replace('/[^a-z0-9\s]/',' ', $text);
  $parts = preg_split('/\s+/', $text);
  $stop = ['and','or','the','a','an','to','for','with','of','in','on','at','by','is','are','as','be','this','that','it','you','your'];
  $freq = [];
  foreach($parts as $p){
    $p = trim($p);
    if (strlen($p)<3) continue;
    if (in_array($p,$stop)) continue;
    $freq[$p] = ($freq[$p]??0)+1;
  }
  arsort($freq);
  return array_slice(array_keys($freq),0,20);
}

function flattenBullets($exp){
  $out = '';
  foreach($exp as $j){
    if (!empty($j['bullets'])) $out .= ' '.implode(' ', $j['bullets']);
  }
  return $out;
}
function flattenEducation($edu){
  $out = '';
  foreach($edu as $e){
    $out .= ' '.($e['degree']??'').' '.($e['institution']??'');
  }
  return $out;
}
function assessStructure($p){
  $headers = ['summary','skills','experience','education'];
  $present = 0;
  foreach($headers as $h){ if (!empty($p[$h])) $present++; }
  return $present / count($headers);
}
