namespace UniversityFacultativesDAL.Entity
{
    public struct Course
    {
        public int Id { get; set; } 
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int Hours { get; set; }
        public string Type { get; set; }

        public Course(int id, int subjectId, int teacherId, int hours, string type)
        {
            this.Id = id;
            this.SubjectId = subjectId;
            this.TeacherId = teacherId;
            this.Hours = hours;
            this.Type = type;
        }
    }
}
