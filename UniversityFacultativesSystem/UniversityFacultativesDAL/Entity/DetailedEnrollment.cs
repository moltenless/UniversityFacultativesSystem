namespace UniversityFacultativesDAL.Entity
{
    public struct DetailedEnrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public string StudentLastName { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentMiddleName { get; set; }
        public string StudentGroup { get; set; }
        public string StudentAddress { get; set; }
        public string StudentPhone { get; set; }
        public string StudentCoursesTaken { get; set; }
        public int CourseId {  get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDescription { get; set; }
        public int TeacherId { get; set; }
        public string TeacherLastName { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherMiddleName { get; set; }
        public string TeacherDepartment { get; set; }
        public string CourseHours { get; set; }
        public string CourseType {  get; set; }

        public DetailedEnrollment(int enrollmentId,
                                  int studentId,
                                  string studentLastName,
                                  string studentFirstName,
                                  string studentMiddleName,
                                  string studentGroup,
                                  string studentAddress,
                                  string studentPhone,
                                  string studentCoursesTaken,
                                  int courseId,
                                  int subjectId,
                                  string subjectName,
                                  string subjectDescription,
                                  int teacherId,
                                  string teacherLastName,
                                  string teacherFirstName,
                                  string teacherMiddleName,
                                  string teacherDepartment,
                                  string courseHours,
                                  string courseTypes)
        {
            EnrollmentId = enrollmentId;
            StudentId = studentId;
            StudentLastName = studentLastName;
            StudentFirstName = studentFirstName;
            StudentMiddleName = studentMiddleName;
            StudentGroup = studentGroup;
            StudentAddress = studentAddress;
            StudentPhone = studentPhone;
            StudentCoursesTaken = studentCoursesTaken;
            CourseId = courseId;
            SubjectId = subjectId;
            SubjectName = subjectName;
            SubjectDescription = subjectDescription;
            TeacherId = teacherId;
            TeacherLastName = teacherLastName;
            TeacherFirstName = teacherFirstName;
            TeacherMiddleName = teacherMiddleName;
            TeacherDepartment = teacherDepartment;
            CourseHours = courseHours;
            CourseType = courseTypes;
        }
    }
}
