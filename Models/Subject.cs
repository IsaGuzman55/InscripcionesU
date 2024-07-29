namespace InscripcionesU.Models{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Propiedad de navegación
        public ICollection<CareerHasSubject> CareerHasSubjects { get; set; }
        public ICollection<SubjectHasInscription> SubjectHasInscriptions { get; set; }
        public ICollection<SubjectHasProfessor> SubjectHasProfessors { get; set; }
    }
}