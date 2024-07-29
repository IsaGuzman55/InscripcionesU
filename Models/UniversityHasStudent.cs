namespace InscripcionesU.Models {
    public class UniversityHasStudent
    {
        /* --------- */
        public int UniversityId { get; set; }
        public University UniversityData { get; set; }

        /* ---------- */
        public int StudentId { get; set; }  
        public Student StudentData { get; set; }
    }
}