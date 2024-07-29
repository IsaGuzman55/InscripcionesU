namespace InscripcionesU.Models {
    public class University{
        public int Id { get; set; }
        public string Name { get; set; }

        // Propiedad de navegación
        public ICollection<ProfessorHasUniversity> ProfessorHasUniversities { get; set; }
        public ICollection<UniversityHasCareer> UniversityHasCareers { get; set; }
        public ICollection<UniversityHasStudent> UniversityHasStudents { get; set; }
        public ICollection<University> Universities { get; set; }
    }
}