drop table semesters_grades;
drop table enrollments;
drop table facultativecourses;

# BEFORE EXECUTING MAKE SURE YOU HAVE HAVE DELETED THREE NODE TABLES WITH REFERENCES!!!
# OTHERWISE IT IS GOING TO BE HAND-DELETING 40 MYSQL USERS


DELIMITER //

CREATE PROCEDURE delete_teacher_and_user_loop()
BEGIN
    DECLARE i INT DEFAULT 1;
    
    WHILE i <= 10 DO
        CALL delete_teacher_and_user(i);
        SET i = i + 1;
    END WHILE;
END //

DELIMITER ;


DELIMITER //

CREATE PROCEDURE delete_student_and_user_loop()
BEGIN
    DECLARE i INT DEFAULT 1;
    
    WHILE i <= 30 DO
        CALL delete_student_and_user(i);
        SET i = i + 1;
    END WHILE;
END //

DELIMITER ;


CALL delete_teacher_and_user_loop();
CALL delete_student_and_user_loop();

drop procedure delete_teacher_and_user_loop;
drop procedure delete_student_and_user_loop;