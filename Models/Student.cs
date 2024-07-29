namespace InscripcionesU.Models {
    public class Student
    {    
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        /* ----------- */
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }

        public ICollection<UniversityHasStudent> UniversityHasStudents { get; set; }
    }
}