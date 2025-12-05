<?php
// public/save.php
require_once __DIR__ . '/../config/db.php';

$payload = json_decode(file_get_contents('php://input'), true);
$userId = 1;

$data = [
  'user_id' => $userId,
  'title' => $payload['title'] ?? '',
  'template' => $payload['template'] ?? 'classic',
  'job_title' => $payload['job_title'] ?? '',
  'industry' => $payload['industry'] ?? '',
  'summary' => $payload['summary'] ?? '',
  'skills' => $payload['skills'] ?? '',
  'experience' => $payload['experience'] ?? '[]',
  'education' => $payload['education'] ?? '[]',
  'certifications' => $payload['certifications'] ?? '[]',
  'projects' => $payload['projects'] ?? '[]',
  'languages' => $payload['languages'] ?? '',
  'job_description' => $payload['job_description'] ?? '',
];

if (!empty($payload['id'])) {
  $stmt = $pdo->prepare("UPDATE resumes SET title=:title, template=:template, job_title=:job_title, industry=:industry, summary=:summary, skills=:skills, experience=:experience, education=:education, certifications=:certifications, projects=:projects, languages=:languages, job_description=:job_description WHERE id=:id");
  $data['id'] = (int)$payload['id'];
  $stmt->execute($data);
  echo json_encode(['message'=>'Updated', 'id'=>$data['id']]); exit;
}

$stmt = $pdo->prepare("INSERT INTO resumes (user_id,title,template,job_title,industry,summary,skills,experience,education,certifications,projects,languages,job_description) VALUES (:user_id,:title,:template,:job_title,:industry,:summary,:skills,:experience,:education,:certifications,:projects,:languages,:job_description)");
$stmt->execute($data);
echo json_encode(['message'=>'Saved', 'id'=>$pdo->lastInsertId()]);
