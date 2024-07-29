namespace InscripcionesU.Models {
    public class UniversityDean
    {   
        public int Id { get; set; }
        public string Name { get; set; }

        /* ----------- */
        public int UniversityId { get; set; }
        public University University { get; set; }
    }
}