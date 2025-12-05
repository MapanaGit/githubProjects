<?php
// public/index.php
require_once __DIR__ . '/../config/db.php';

// Minimal fake user for demo
$userId = 1;
$pdo->exec("INSERT IGNORE INTO users (id,email,name) VALUES (1,'demo@example.com','Demo User')");

// Load latest resume
$stmt = $pdo->prepare("SELECT * FROM resumes WHERE user_id=? ORDER BY updated_at DESC LIMIT 1");
$stmt->execute([$userId]);
$resume = $stmt->fetch();
?>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title>AI Resume Builder</title>
<link rel="stylesheet" href="css/base.css">
<link rel="stylesheet" href="css/template_classic.css" id="template-css">
<script>
function switchTemplate(sel){
  const id = 'template-css';
  const link = document.getElementById(id);
  link.href = 'css/template_' + sel.value + '.css';
}
</script>
</head>
<body>
<div class="container">
  <h1>AI Resume Builder</h1>
  <p class="small">ATS-friendly structure, keyword matching, smart suggestions, and three templates. Your data is stored locally in MySQL.</p>

  <div class="grid">
    <div class="section">
      <h2>Resume info</h2>
      <form id="resumeForm">
        <input type="hidden" name="id" value="<?php echo $resume['id'] ?? ''; ?>">
        <label>Title</label>
        <input name="title" placeholder="e.g., Software Engineer Resume" value="<?php echo htmlspecialchars($resume['title'] ?? ''); ?>">
        <label>Job title</label>
        <input name="job_title" placeholder="e.g., Software Engineer" value="<?php echo htmlspecialchars($resume['job_title'] ?? ''); ?>">
        <label>Industry</label>
        <input name="industry" placeholder="e.g., Technology" value="<?php echo htmlspecialchars($resume['industry'] ?? ''); ?>">
        <label>Professional summary</label>
        <textarea name="summary" placeholder="Concise, results-focused summary"><?php echo htmlspecialchars($resume['summary'] ?? ''); ?></textarea>
        <label>Skills (comma-separated)</label>
        <input name="skills" placeholder="e.g., Java, Spring, REST, AWS, SQL" value="<?php echo htmlspecialchars($resume['skills'] ?? ''); ?>">
        <label>Languages (comma-separated)</label>
        <input name="languages" placeholder="e.g., English, Zulu" value="<?php echo htmlspecialchars($resume['languages'] ?? ''); ?>">
        <label>Job description (paste)</label>
        <textarea name="job_description" placeholder="Paste the job description for matching"><?php echo htmlspecialchars($resume['job_description'] ?? ''); ?></textarea>

        <div class="controls">
          <label>Template</label>
          <select name="template" onchange="switchTemplate(this)">
            <option value="classic" <?php if(($resume['template'] ?? 'classic')==='classic') echo 'selected'; ?>>Classic</option>
            <option value="modern" <?php if(($resume['template'] ?? '')==='modern') echo 'selected'; ?>>Modern</option>
            <option value="minimal" <?php if(($resume['template'] ?? '')==='minimal') echo 'selected'; ?>>Minimal</option>
          </select>
          <button type="button" id="suggestBtn">Smart suggestions</button>
          <button type="button" id="atsBtn">ATS check</button>
          <button type="button" id="saveBtn">Save</button>
          <button type="button" id="exportHtmlBtn" class="secondary">Export HTML</button>
          <button type="button" id="exportPdfBtn" class="secondary">Export PDF</button>
        </div>
      </form>
    </div>

    <div class="section">
      <h2>Section-by-section preview</h2>
      <div class="preview">
        <div id="resumePreview" class="resume">
          <?php
            $tpl = $resume['template'] ?? 'classic';
            $templatePath = __DIR__ . "/templates/template_{$tpl}.php";
            if (!file_exists($templatePath)) $templatePath = __DIR__ . "/templates/template_classic.php";
            $resumeData = $resume ?: [
              'title'=>'','job_title'=>'','industry'=>'','summary'=>'','skills'=>'','languages'=>'',
              'experience'=>'[]','education'=>'[]','certifications'=>'[]','projects'=>'[]'
            ];
            include $templatePath;
          ?>
        </div>
      </div>
      <div id="atsResult" class="small"></div>
      <div id="suggestions" class="small"></div>
    </div>
  </div>
</div>
<script src="js/app.js"></script>
</body>
</html>
