<?php
// public/export_html.php
require_once __DIR__ . '/../config/db.php';
$id = (int)($_GET['id'] ?? 0);
$stmt = $pdo->prepare("SELECT * FROM resumes WHERE id=?");
$stmt->execute([$id]);
$resume = $stmt->fetch();
if (!$resume) { http_response_code(404); echo "Not found"; exit; }

$tpl = $resume['template'] ?? 'classic';
$templatePath = __DIR__ . "/templates/template_{$tpl}.php";
if (!file_exists($templatePath)) $templatePath = __DIR__ . "/templates/template_classic.php";

$resumeData = $resume;
?><!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title><?php echo htmlspecialchars($resume['title']); ?></title>
<link rel="stylesheet" href="css/base.css">
<link rel="stylesheet" href="css/template_<?php echo htmlspecialchars($tpl); ?>.css">
<style>
@media print {
  body{background:#fff}
  .container,.section,.preview{border:none}
}
</style>
</head>
<body>
<div class="container">
  <div class="resume">
    <?php include $templatePath; ?>
  </div>
</div>
</body>
</html>
