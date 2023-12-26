namespace UniversityFacultativesDAL.Entity
{
    public struct Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Enrollment(int id, int studentId, int courseId)
        {
            Id = id;
            StudentId = studentId;
            CourseId = courseId;
        }
    }
}
