from flask import Flask, render_template, request, redirect, flash
import sqlite3

app = Flask(__name__)
app.secret_key = "student_management_secret_key"

DATABASE = "students.db"


# ===============================
# Database Connection
# ===============================

def get_db_connection():
    conn = sqlite3.connect(DATABASE)
    conn.row_factory = sqlite3.Row
    return conn


# ===============================
# Create Database & Table
# ===============================

def create_table():
    conn = get_db_connection()
    cursor = conn.cursor()

    cursor.execute("""
        CREATE TABLE IF NOT EXISTS students(
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT NOT NULL,
            email TEXT NOT NULL,
            course TEXT NOT NULL
        )
    """)

    conn.commit()
    conn.close()


create_table()


# ===============================
# HOME PAGE
# Display all students
# ===============================

@app.route("/")
def index():

    conn = get_db_connection()
    students = conn.execute(
        "SELECT * FROM students ORDER BY id DESC"
    ).fetchall()
    conn.close()

    return render_template("index.html", students=students)


# ===============================
# ADD STUDENT
# ===============================

@app.route("/add", methods=["GET", "POST"])
def add():

    if request.method == "POST":

        name = request.form["name"].strip()
        email = request.form["email"].strip()
        course = request.form["course"].strip()

        if not name or not email or not course:
            flash("All fields are required.", "error")
            return redirect("/add")

        conn = get_db_connection()

        conn.execute("""
            INSERT INTO students(name,email,course)
            VALUES(?,?,?)
        """, (name, email, course))

        conn.commit()
        conn.close()

        flash("Student added successfully!", "success")

        return redirect("/")

    return render_template("add.html")


# ===============================
# EDIT STUDENT
# ===============================

@app.route("/edit/<int:id>", methods=["GET", "POST"])
def edit(id):

    conn = get_db_connection()

    student = conn.execute(
        "SELECT * FROM students WHERE id=?",
        (id,)
    ).fetchone()

    if student is None:
        conn.close()
        flash("Student not found.", "error")
        return redirect("/")

    if request.method == "POST":

        name = request.form["name"].strip()
        email = request.form["email"].strip()
        course = request.form["course"].strip()

        if not name or not email or not course:
            flash("All fields are required.", "error")
            return redirect(f"/edit/{id}")

        conn.execute("""
            UPDATE students
            SET name=?, email=?, course=?
            WHERE id=?
        """, (name, email, course, id))

        conn.commit()
        conn.close()

        flash("Student updated successfully!", "success")

        return redirect("/")

    conn.close()

    return render_template("edit.html", student=student)


# ===============================
# DELETE STUDENT
# ===============================

@app.route("/delete/<int:id>")
def delete(id):

    conn = get_db_connection()

    conn.execute(
        "DELETE FROM students WHERE id=?",
        (id,)
    )

    conn.commit()
    conn.close()

    flash("Student deleted successfully!", "success")

    return redirect("/")


# ===============================
# RUN APPLICATION
# ===============================

if __name__ == "__main__":
    app.run(debug=True)