create database course;
use course;

CREATE TABLE Teachers (
  id INT PRIMARY KEY AUTO_INCREMENT,
  last_name VARCHAR(100),
  first_name VARCHAR(100),
  middle_name VARCHAR(100),
  department VARCHAR(100)
);

CREATE TABLE Students (
  id INT PRIMARY KEY AUTO_INCREMENT,
  last_name VARCHAR(100),
  first_name VARCHAR(100),
  middle_name VARCHAR(100),
  group_name VARCHAR(100),
  address VARCHAR(100),
  phone VARCHAR(100),
  facultatives_taken INT DEFAULT 0
);

CREATE TABLE Subjects (
  id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(100),
  description VARCHAR(300)
);

CREATE TABLE Semesters (
  id INT PRIMARY KEY AUTO_INCREMENT,
  beginning_date VARCHAR(100),
  end_date VARCHAR(100),
  students_min_subjects_count INT default 2
);

CREATE TABLE FacultativeCourses (
  id INT PRIMARY KEY AUTO_INCREMENT,
  subject_id INT,
  teacher_id INT,
  hours INT,
  type VARCHAR(100),
  FOREIGN KEY (subject_id) REFERENCES Subjects(id),
  FOREIGN KEY (teacher_id) REFERENCES Teachers(id)
);

CREATE TABLE Enrollments (
  id INT PRIMARY KEY AUTO_INCREMENT,
  student_id INT,
  course_id INT,
  FOREIGN KEY (student_id) REFERENCES Students(id),
  FOREIGN KEY (course_id) REFERENCES FacultativeCourses(id)
);

CREATE TABLE Semesters_Grades (
  id INT PRIMARY KEY AUTO_INCREMENT,
  semester_id INT,
  enrollment_id INT,
  grade INT,
  FOREIGN KEY (semester_id) REFERENCES Semesters(id),
  FOREIGN KEY (enrollment_id) REFERENCES Enrollments(id)
);

create table teacher_logins(
teacher_id int,
login varchar(100),
password varchar(100),
FOREIGN KEY (teacher_id) REFERENCES Teachers(id)
);

create table student_logins(
student_id int,
login varchar(100),
password varchar(100),
FOREIGN KEY (student_id) REFERENCES Students(id)
);

DELIMITER //
CREATE PROCEDURE insert_teacher_and_create_user(
    IN p_last_name VARCHAR(100),
    IN p_first_name VARCHAR(100),
    IN p_middle_name VARCHAR(100),
    IN p_department VARCHAR(100))
BEGIN
    DECLARE new_id INT;
    DECLARE new_username VARCHAR(100);
    DECLARE new_password VARCHAR(100);

    START TRANSACTION;

    INSERT INTO Teachers (last_name, first_name, middle_name, department)
    VALUES (p_last_name, p_first_name, p_middle_name, p_department);
    SET new_id = LAST_INSERT_ID();
    
    SET new_username = p_last_name;
    SET new_password = CONCAT(SUBSTRING(MD5(RAND()), 1, 6));
    
    SET @dynamic_sql = CONCAT('CREATE USER ', new_username, '@localhost IDENTIFIED BY ''', new_password, '''; ');
    PREPARE stmt FROM @dynamic_sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    SET @dynamic_sql = CONCAT('GRANT SELECT ON course.* TO ''', new_username, '''@localhost; ');
    PREPARE stmt FROM @dynamic_sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    SET @dynamic_sql = CONCAT('GRANT INSERT ON course.facultativecourses TO ''', new_username, '''@localhost; ');
    PREPARE stmt FROM @dynamic_sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    SET @dynamic_sql = CONCAT('GRANT INSERT ON course.semesters_grades TO ''', new_username, '''@localhost; ');
    PREPARE stmt FROM @dynamic_sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    SET @dynamic_sql = CONCAT('GRANT EXECUTE ON PROCEDURE course.ModifyGrades TO ''', new_username, '''@''localhost''; ');
    PREPARE stmt FROM @dynamic_sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;

    INSERT INTO teacher_logins (teacher_id, login, password)
    VALUES (new_id, new_username, new_password);

    COMMIT;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE delete_teacher_and_user(IN p_teacher_id INT)
BEGIN
    DECLARE user_login VARCHAR(100);

    START TRANSACTION;

    SELECT login INTO user_login FROM teacher_logins WHERE teacher_id = p_teacher_id;

    DELETE FROM teacher_logins WHERE teacher_id = p_teacher_id;
    DELETE FROM Teachers WHERE id = p_teacher_id;

    SET @delete_user_sql = CONCAT('REVOKE ALL PRIVILEGES ON *.* FROM \'', user_login, '\'@\'localhost\'');
    PREPARE delete_user_stmt FROM @delete_user_sql;
    EXECUTE delete_user_stmt;
    DEALLOCATE PREPARE delete_user_stmt;
    
	SET @delete_user_sql = CONCAT('DROP USER \'', user_login, '\'@\'localhost\'');
    PREPARE delete_user_stmt FROM @delete_user_sql;
    EXECUTE delete_user_stmt;
    DEALLOCATE PREPARE delete_user_stmt;
    
    COMMIT;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE insert_student_and_create_user(
    IN p_last_name VARCHAR(100),
    IN p_first_name VARCHAR(100),
    IN p_middle_name VARCHAR(100),
    IN p_group_name VARCHAR(100),
    IN p_address VARCHAR(100),
    IN p_phone VARCHAR(100))
BEGIN
    DECLARE new_id INT;
    DECLARE new_username VARCHAR(100);
    DECLARE new_password VARCHAR(100);

    START TRANSACTION;

    INSERT INTO Students (last_name, first_name, middle_name, group_name, address, phone)
    VALUES (p_last_name, p_first_name, p_middle_name, p_group_name, p_address, p_phone);
    SET new_id = LAST_INSERT_ID();
    
    SET new_username = p_last_name;
    SET new_password = CONCAT(SUBSTRING(MD5(RAND()), 1, 6));

    SET @dynamic_sql = CONCAT('CREATE USER \'', new_username, '\'@\'localhost\' IDENTIFIED BY \'', new_password, '\';');
    PREPARE stmt FROM @dynamic_sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    SET @dynamic_sql = CONCAT('GRANT SELECT ON course.* TO \'', new_username, '\'@\'localhost\';');
    PREPARE stmt FROM @dynamic_sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
    
    SET @dynamic_sql = CONCAT('GRANT INSERT ON course.enrollments TO \'', new_username, '\'@\'localhost\';');
    PREPARE stmt FROM @dynamic_sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;

    INSERT INTO student_logins (student_id, login, password)
    VALUES (new_id, new_username, new_password);

    COMMIT;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE delete_student_and_user(IN p_student_id INT)
BEGIN
    DECLARE user_login VARCHAR(100);

    START TRANSACTION;

    SELECT login INTO user_login FROM student_logins WHERE student_id = p_student_id;

    DELETE FROM student_logins WHERE student_id = p_student_id;
    DELETE FROM Students WHERE id = p_student_id;

    SET @delete_user_sql = CONCAT('DROP USER \'', user_login, '\'@\'localhost\'');
    PREPARE delete_user_stmt FROM @delete_user_sql;
    EXECUTE delete_user_stmt;
    DEALLOCATE PREPARE delete_user_stmt;

    COMMIT;
END //
DELIMITER ;

create view FacultativeCourses_Inclusive_View as
select
course.id              as course_id, 
subject.id             as subject_id,
subject.name           as subject_name,
subject.description    as subject_description,
teacher.id             as teacher_id,
teacher.last_name      as teacher_last_name,
teacher.first_name     as teacher_first_name, 
teacher.middle_name    as teacher_middle_name,
teacher.department     as teacher_department,
course.hours           as course_hours,
course.type            as course_type
from FacultativeCourses course
join Subjects subject on course.subject_id = subject.id
join Teachers teacher on course.teacher_id = teacher.id
order by course.id;

create view Enrollments_Inclusive_View as
select
enrollment.id as                 	enrollment_id,
student.id as                    	student_id,
student.last_name as 				student_last_name,
student.first_name as 				student_first_name,
student.middle_name as 				student_middle_name,
student.group_name as 				student_group_name,
student.address as 					student_address,
student.phone as 					student_phone,
student.facultatives_taken as 		student_facultatives_taken,
								    course.course_id, 
									course.subject_id,
									course.subject_name,
									course.subject_description,
									course.teacher_id,
									course.teacher_last_name,
									course.teacher_first_name, 
									course.teacher_middle_name,
									course.teacher_department,
									course.course_hours,
									course.course_type 						
from Enrollments enrollment
join Students student on enrollment.student_id = student.id
join FacultativeCourses_Inclusive_View course on enrollment.course_id = course.course_id
order by enrollment.id;

create view Semesters_Grades_Inclusive_View as
select 
grade.id as grade_id,
semester.id as semester_id,
semester.beginning_date as semester_beginning_date,
semester.end_date as semester_end_date,
semester.students_min_subjects_count as semester_students_min_subjects_count,
enrollment.enrollment_id,
enrollment.student_id,
enrollment.student_last_name,
enrollment.student_first_name,
enrollment.student_middle_name,
enrollment.student_group_name,
enrollment.student_address,
enrollment.student_phone,
enrollment.student_facultatives_taken,
enrollment.course_id, 
enrollment.subject_id,
enrollment.subject_name,
enrollment.subject_description,
enrollment.teacher_id,
enrollment.teacher_last_name,
enrollment.teacher_first_name, 
enrollment.teacher_middle_name,
enrollment.teacher_department,
enrollment.course_hours,
enrollment.course_type,
grade.grade as grade_grade
from Semesters_Grades grade
join Semesters semester on grade.semester_id = semester.id
join Enrollments_Inclusive_View enrollment on grade.enrollment_id = enrollment.enrollment_id
order by grade.id;

DELIMITER //
CREATE PROCEDURE ModifyGrades(IN semesterId INT, IN teacherId INT, IN modifyValue INT)
BEGIN
    DECLARE current_id INT;
    DECLARE currentGrade INT;
    DECLARE done INT DEFAULT FALSE;

    DECLARE gradesCursor CURSOR FOR
        SELECT grade_id, grade_grade
        FROM Semesters_Grades_Inclusive_View
        WHERE semester_id = semesterId and teacher_id = teacherId;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

    OPEN gradesCursor;

    gradesLoop: LOOP
        FETCH gradesCursor INTO current_id, currentGrade;

        IF done THEN
            LEAVE gradesLoop;
        END IF;

        SET currentGrade = LEAST(GREATEST(currentGrade + modifyValue, 1), 100);

        UPDATE Semesters_Grades
        SET grade = currentGrade
        WHERE id = current_id; 
    END LOOP;

    CLOSE gradesCursor;
END //
DELIMITER ;

DELIMITER //
CREATE TRIGGER increment_facultatives_taken
AFTER INSERT ON Enrollments
FOR EACH ROW
BEGIN
    UPDATE Students
    SET facultatives_taken = facultatives_taken + 1
    WHERE id = NEW.student_id;
END //
DELIMITER ;

DELIMITER //
CREATE TRIGGER update_facultatives_taken_delete
AFTER DELETE ON Enrollments
FOR EACH ROW
BEGIN
    UPDATE Students
    SET facultatives_taken = facultatives_taken - 1
    WHERE id = OLD.student_id;
END //
DELIMITER ;