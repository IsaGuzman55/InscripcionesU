namespace InscripcionesU.Models {
    public class SubjectHasInscription
    {
        /* ------------- */   
        public int SubjectId { get; set; }
        public Subject SubjectData { get; set; }

        /* ------------- */ 
        public int InscriptionId { get; set; }
        public Inscription InscriptionData { get; set; }
    }
}