namespace UniversityFacultativesDAL.Entity
{
    public struct Teacher
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Department {  get; set; }

        public Teacher(int id, string lastName, string firstName, string middleName, string department)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Department = department;
        }
    }
}
