-- sql/schema.sql
CREATE DATABASE IF NOT EXISTS resume_builder CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE resume_builder;

-- Users (simple; you can hook real auth later)
CREATE TABLE IF NOT EXISTS users (
  id INT AUTO_INCREMENT PRIMARY KEY,
  email VARCHAR(191) UNIQUE,
  name VARCHAR(191),
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Resumes
CREATE TABLE IF NOT EXISTS resumes (
  id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT,
  title VARCHAR(191),
  template VARCHAR(50) DEFAULT 'classic',
  job_title VARCHAR(191),
  industry VARCHAR(100),
  summary TEXT,
  skills TEXT,           -- comma-separated for ATS parsing
  experience JSON,       -- array of jobs with bullets
  education JSON,        -- array of education entries
  certifications JSON,   -- array of certs
  projects JSON,         -- array of projects
  languages TEXT,        -- comma-separated
  job_description TEXT,  -- pasted JD for matching
  ats_score INT DEFAULT 0,
  edits JSON,            -- keeps accepted/removed suggestions
  updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE SET NULL
);

-- Suggestions learned per industry/role (feedback loop)
CREATE TABLE IF NOT EXISTS suggestion_stats (
  id INT AUTO_INCREMENT PRIMARY KEY,
  industry VARCHAR(100),
  role VARCHAR(100),
  suggestion TEXT,
  accepted_count INT DEFAULT 0,
  removed_count INT DEFAULT 0,
  last_used TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
