<?php
// public/export_pdf.php
// Approach: open the HTML version and let browser print to PDF.
// If you want server-side PDF: integrate dompdf and render the same HTML.
$id = (int)($_GET['id'] ?? 0);
header("Location: export_html.php?id=".$id);
exit;

// Optional server-side (if you add dompdf):
/*
require_once __DIR__.'/../vendor/autoload.php';
use Dompdf\Dompdf;
ob_start();
include 'export_html.php'; // or build HTML string
$html = ob_get_clean();
$dompdf = new Dompdf();
$dompdf->loadHtml($html);
$dompdf->setPaper('A4','portrait');
$dompdf->render();
$dompdf->stream('resume.pdf');
*/
