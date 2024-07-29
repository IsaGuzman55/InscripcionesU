using InscripcionesU.Context;

namespace InscripcionesU.Models {
    public class Career
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Propiedad de navegación
        public ICollection<CareerHasSubject> CareerHasSubjects { get; set; }
        public ICollection<UniversityHasCareer> UniversityHasCareers { get; set; }
    }
}
