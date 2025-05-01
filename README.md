# 🎓 UniversityFacultativesSystem (Screenshots are below)

**A complete university facultative course management system built with C# and MySQL. Featuring role-based authentication, secure user provisioning, and a robust layered architecture for managing courses, users, enrollments, and grades.**

---

## 🏛️ Overview

This project provides a full university-style system to manage facultative (elective) courses. It includes:

- 🗃️ A **MySQL database** for storing:
  - Students, Teachers, Courses
  - Subjects, Departments, Semesters
  - Enrollments, Grades
  - Student & Teacher login credentials
- ⚙️ A **stored procedure** to:
  - Create MySQL users based on new student/teacher records
  - Assign appropriate **privileges** for each role
- 👤 A special **Deanery (Admin) user**:
  - Full access to the system and all database operations

---
![Screen Recording 2025-04-30 185733](https://github.com/user-attachments/assets/94260486-3581-4f65-a490-3f503a0d4311)
---

## 🏗️ Architecture

### 🗃️ MySQL Database
- Tables
- MySQL database users & privileges
- Stored procedurs & views

### ✅ C# Data Access Layer (DAL)

- **Entities**: Strongly typed models for each table
- **Repositories**: Clean abstraction for CRUD operations
- **Main Service**: Business logic layer for interacting with the DB

### 💻 C# Windows Forms UI

- Login screen with **role-based entry** (Student, Teacher, Deanery)
- Secure connection via **MySQL user credentials** generated during signup
- UI and functionality change depending on the user role

---

![use case diagram](https://github.com/user-attachments/assets/a475bcd1-006e-43de-a063-305dcfbca108)
![conceptial scheme](https://github.com/user-attachments/assets/add24ad9-eaeb-48e2-bdd2-4a6138e28452)


---

## 🔐 Authentication Flow

1. User (Student/Teacher/Deanery) attempts to log in.
2. Application connects to the MySQL server **as the MySQL user** with entered credentials.
3. Credentials are validated via login tables.
4. Upon success, the user accesses features allowed by their role:
   - 🧑‍🎓 **Students**: View courses, enroll, check grades
   - 👩‍🏫 **Teachers**: Manage course content and assign grades
   - 🧑‍💼 **Deanery Staff**: Full CRUD on all data

---

![Screen Recording 2025-04-30 195328](https://github.com/user-attachments/assets/006fd921-db05-4235-8036-d6838ea515fa)

---

![ezgif-31888c8a040a74](https://github.com/user-attachments/assets/f8ae57bc-9e22-4a05-ab00-44d50f7d371f)



