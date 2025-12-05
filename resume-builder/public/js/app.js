// public/js/app.js
function serializeForm(form){
  const fd = new FormData(form);
  const obj = {};
  for(const [k,v] of fd.entries()) obj[k]=v;
  return obj;
}

function currentExperience(){
  // Simple demo experience; could add UI to edit JSON
  return [
    { role:"Software Engineer", company:"ACME Corp", period:"2021–Present", bullets:[
      "Built REST APIs improving throughput by 35%",
      "Automated CI/CD pipelines with GitHub Actions",
      "Optimized SQL queries reducing latency by 40%"
    ] }
  ];
}

function currentEducation(){
  return [
    { degree:"BSc Computer Science", institution:"University of Example", year:"2019" }
  ];
}

function currentProjects(){
  return [
    { name:"AI Resume Builder", desc:"ATS-friendly generator with keyword matching and templates" }
  ];
}

function currentCerts(){
  return [
    { name:"AWS Certified Cloud Practitioner", issuer:"Amazon Web Services" }
  ];
}

document.getElementById('suggestBtn').addEventListener('click', async ()=>{
  const form = document.getElementById('resumeForm');
  const data = serializeForm(form);
  const res = await fetch('suggest.php', {
    method:'POST', headers:{'Content-Type':'application/json'},
    body: JSON.stringify(data)
  });
  const json = await res.json();
  const box = document.getElementById('suggestions');
  box.innerHTML = "<strong>Suggestions:</strong>";
  json.suggestions.forEach(s=>{
    const span = document.createElement('span');
    span.className='badge';
    span.textContent = s.text;
    span.onclick = async ()=>{
      // Simple insert into summary
      const summary = document.querySelector('textarea[name="summary"]');
      const before = summary.value;
      summary.value = (summary.value.trim()? summary.value+"\n" : "") + s.text;
      // record accepted
      await fetch('suggest.php?action=accepted', { method:'POST', headers:{'Content-Type':'application/json'},
        body: JSON.stringify({ industry:data.industry, role:data.job_title, suggestion:s.text })
      });
      span.style.opacity = .5;
    };
    box.appendChild(span);

    // remove handler
    const remove = document.createElement('span');
    remove.className='badge';
    remove.textContent = "x";
    remove.style.background='#fee';
    remove.style.borderColor='#fbb';
    remove.onclick = async ()=>{
      await fetch('suggest.php?action=removed', { method:'POST', headers:{'Content-Type':'application/json'},
        body: JSON.stringify({ industry:data.industry, role:data.job_title, suggestion:s.text })
      });
      span.remove(); remove.remove();
    };
    box.appendChild(remove);
  });
});

document.getElementById('atsBtn').addEventListener('click', async ()=>{
  const form = document.getElementById('resumeForm');
  const data = serializeForm(form);
  data.skills = data.skills || '';
  data.experience = JSON.stringify(currentExperience());
  data.education = JSON.stringify(currentEducation());
  const res = await fetch('ats_check.php', {
    method:'POST', headers:{'Content-Type':'application/json'},
    body: JSON.stringify(data)
  });
  const json = await res.json();
  const box = document.getElementById('atsResult');
  box.innerHTML = `<strong>ATS score:</strong> <span class="score">${json.score}</span> / 100<br>
  <strong>Missing keywords:</strong> ${json.missing.map(k=>`<span class='kpill'>${k}</span>`).join(' ')}<br>
  <strong>Recommendations:</strong> ${json.recommendations.join('; ')}`;
});

document.getElementById('saveBtn').addEventListener('click', async ()=>{
  const form = document.getElementById('resumeForm');
  const data = serializeForm(form);
  data.experience = JSON.stringify(currentExperience());
  data.education = JSON.stringify(currentEducation());
  data.projects = JSON.stringify(currentProjects());
  data.certifications = JSON.stringify(currentCerts());

  const res = await fetch('save.php', {
    method:'POST', headers:{'Content-Type':'application/json'},
    body: JSON.stringify(data)
  });
  const json = await res.json();
  alert(json.message || 'Saved');
  location.reload();
});

document.getElementById('exportHtmlBtn').addEventListener('click', ()=>{
  const id = document.querySelector('input[name="id"]').value;
  window.open('export_html.php?id='+encodeURIComponent(id||''), '_blank');
});

document.getElementById('exportPdfBtn').addEventListener('click', ()=>{
  const id = document.querySelector('input[name="id"]').value;
  window.open('export_pdf.php?id='+encodeURIComponent(id||''), '_blank');
});
