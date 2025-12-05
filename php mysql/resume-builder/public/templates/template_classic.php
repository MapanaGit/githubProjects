<?php
// public/templates/template_classic.php
$exp = json_decode($resumeData['experience'] ?? '[]', true) ?: [];
$edu = json_decode($resumeData['education'] ?? '[]', true) ?: [];
$certs = json_decode($resumeData['certifications'] ?? '[]', true) ?: [];
$projects = json_decode($resumeData['projects'] ?? '[]', true) ?: [];
?>
<h1><?php echo htmlspecialchars($resumeData['title'] ?: 'Your Name'); ?></h1>
<div class="meta"><?php echo htmlspecialchars(($resumeData['job_title'] ?? '').' • '.($resumeData['industry'] ?? '')); ?></div>

<h2>Summary</h2>
<p><?php echo nl2br(htmlspecialchars($resumeData['summary'] ?? '')); ?></p>

<h2>Skills</h2>
<p>
<?php foreach(array_filter(array_map('trim', explode(',', $resumeData['skills'] ?? ''))) as $s): ?>
  <span class="chip"><?php echo htmlspecialchars($s); ?></span>
<?php endforeach; ?>
</p>

<h2>Experience</h2>
<ul>
<?php foreach($exp as $job): ?>
  <li>
    <strong><?php echo htmlspecialchars($job['role'] ?? ''); ?>, <?php echo htmlspecialchars($job['company'] ?? ''); ?></strong>
    <?php if(!empty($job['period'])): ?> — <span class="meta"><?php echo htmlspecialchars($job['period']); ?></span><?php endif; ?>
    <?php if(!empty($job['bullets'])): ?>
      <ul>
        <?php foreach($job['bullets'] as $b): ?>
          <li><?php echo htmlspecialchars($b); ?></li>
        <?php endforeach; ?>
      </ul>
    <?php endif; ?>
  </li>
<?php endforeach; ?>
</ul>

<h2>Projects</h2>
<ul>
<?php foreach($projects as $p): ?>
  <li><strong><?php echo htmlspecialchars($p['name'] ?? ''); ?></strong> — <?php echo htmlspecialchars($p['desc'] ?? ''); ?></li>
<?php endforeach; ?>
</ul>

<h2>Education</h2>
<ul>
<?php foreach($edu as $e): ?>
  <li><strong><?php echo htmlspecialchars($e['degree'] ?? ''); ?></strong>, <?php echo htmlspecialchars($e['institution'] ?? ''); ?> — <span class="meta"><?php echo htmlspecialchars($e['year'] ?? ''); ?></span></li>
<?php endforeach; ?>
</ul>

<h2>Certifications</h2>
<ul>
<?php foreach($certs as $c): ?>
  <li><?php echo htmlspecialchars($c['name'] ?? ''); ?> — <span class="meta"><?php echo htmlspecialchars($c['issuer'] ?? ''); ?></span></li>
<?php endforeach; ?>
</ul>

<h2>Languages</h2>
<p><?php echo htmlspecialchars($resumeData['languages'] ?? ''); ?></p>
