namespace InscripcionesU.Models {
    public class ProfessorHasUniversity
    { 
        /* ------------- */
        public int ProfessorId { get; set; }
        public Professor ProfessorData { get; set; }

        /* ----------- */
        public int UniversityId { get; set; }
        public University UniversityData { get; set; }
    }
}