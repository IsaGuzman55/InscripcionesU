namespace InscripcionesU.Models {
    public class UniversityHasCareer
    {
        /* ------------- */
        public int CareerId { get; set; }
        public Career CareerData { get; set; }

        /* ------------- */
        public int UniversityId { get; set; }
        public University UniversityData { get; set; }
    }
}