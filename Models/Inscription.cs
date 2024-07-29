namespace InscripcionesU.Models {
    public class Inscription
    {
        public int Id { get; set; }

        /* ----------- */
        public int SemesterId { get; set; }
        public Semester Semester { get; set; }

        public ICollection<SubjectHasInscription> SubjectHasInscriptions { get; set; }
        public ICollection<SubjectHasProfessor> SubjectHasProfessors { get; set; }
    }
}