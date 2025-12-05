<?php
// public/load.php
require_once __DIR__ . '/../config/db.php';
$userId = 1;
$stmt = $pdo->prepare("SELECT * FROM resumes WHERE user_id=? ORDER BY updated_at DESC LIMIT 1");
$stmt->execute([$userId]);
echo json_encode($stmt->fetch() ?: []);
