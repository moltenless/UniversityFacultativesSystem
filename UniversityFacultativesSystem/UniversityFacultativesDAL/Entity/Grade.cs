namespace UniversityFacultativesDAL.Entity
{
    public struct Grade
    {
        public int Id { get; set; }
        public int SemesterId { get; set; }
        public int EnrollmentId {  get; set; }
        public int Value { get; set; }

        public Grade(int id, int semesterId, int enrollmentId, int value)
        {
            Id = id;
            SemesterId = semesterId;
            EnrollmentId = enrollmentId;
            Value = value;
        }
    }
}
