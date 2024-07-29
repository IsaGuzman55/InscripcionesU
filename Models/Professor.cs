namespace InscripcionesU.Models 
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Propiedad de navegación
        public ICollection<ProfessorHasUniversity> ProfessorHasUniversities { get; set; }
    }
}