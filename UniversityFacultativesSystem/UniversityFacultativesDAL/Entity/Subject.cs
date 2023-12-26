namespace UniversityFacultativesDAL.Entity
{
    public struct Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Subject(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
