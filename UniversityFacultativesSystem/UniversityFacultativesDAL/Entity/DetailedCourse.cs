namespace UniversityFacultativesDAL.Entity
{
    public struct DetailedCourse
    {
        public int CourseId { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDescription { get; set; }
        public int TeacherId { get; set; }
        public string TeacherLastName { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherMiddleName { get; set; }
        public string TeacherDepartment { get; set; }
        public string CourseHours { get; set; }
        public string CourseType { get; set; }

        public DetailedCourse(int courseId,
                              int subjectId,
                              string subjectName,
                              string subjectDescription,
                              int teacherId,
                              string teacherLastName,
                              string teacherFirstName,
                              string teacherMiddleName,
                              string teacherDepartment,
                              string courseHours,
                              string courseType)
        {
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
            CourseType = courseType;
        }
    }
}
