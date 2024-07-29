using InscripcionesU.Context;

namespace InscripcionesU.Models {
    public class CareerHasSubject
    {
        /* ----------- */
        public int CareerId { get; set; }
        public Career CareerData { get; set; }

        /* ----------- */
        public int SubjectId { get; set; }
        public Subject SubjectData { get; set; }
    }
}