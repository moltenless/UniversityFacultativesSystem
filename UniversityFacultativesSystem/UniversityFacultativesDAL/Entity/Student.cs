namespace UniversityFacultativesDAL.Entity
{
    public struct Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Group { get; set; }   
        public string Address { get; set; }
        public string Phone { get; set; }
        public int CoursesTaken { get; set; }

        public Student(int id,
                       string lastName,
                       string firstName,
                       string middleName,
                       string group,
                       string address,
                       string phone,
                       int coursesTaken)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Group = group;
            Address = address;
            Phone = phone;
            CoursesTaken = coursesTaken;
        }
    }
}
