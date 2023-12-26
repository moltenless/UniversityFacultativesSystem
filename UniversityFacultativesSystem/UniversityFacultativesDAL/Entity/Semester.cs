namespace UniversityFacultativesDAL.Entity
{
    public struct Semester
    {
        public int Id { get; set; }
        public string BeginningDate {  get; set; }
        public string EndDate { get; set; }
        public int StudentsMinCoursesCount { get; set; }

        public Semester(int id, string beginningDate, string endDate, int studentsMinCoursesCount)
        {
            Id = id;
            BeginningDate = beginningDate;
            EndDate = endDate;
            StudentsMinCoursesCount = studentsMinCoursesCount;
        }
    }
}
