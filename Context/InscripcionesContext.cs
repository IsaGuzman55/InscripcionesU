using Microsoft.EntityFrameworkCore;
using InscripcionesU.Models;

namespace InscripcionesU.Context{
    public class InscripcionesContext : DbContext{

    public InscripcionesContext(DbContextOptions<InscripcionesContext> options) : base(options){}
        public DbSet<Career> Careers {get; set;}
        public DbSet<CareerHasSubject> CareerHasSubjects {get; set;}
        public DbSet<Inscription> Inscriptions {get; set;}
        public DbSet<ProfessorHasUniversity> ProfessorHasUniversities {get; set;}
        public DbSet<Professor> Professors {get; set;}
        public DbSet<Semester> Semesters {get; set;}
        public DbSet<Student> Students {get; set;}
        public DbSet<Subject> Subjects {get; set;}
        public DbSet<SubjectHasInscription> SubjectHasInscriptions {get; set;}
        public DbSet<SubjectHasProfessor> SubjectHasProfessors {get; set;}
        public DbSet<University> Universities {get; set;}
        public DbSet<UniversityHasCareer> UniversitiesHasCareer {get; set;}
        public DbSet<UniversityDean> UniversityDeans {get; set;}
        public DbSet<UniversityHasStudent> UniversityHasStudents {get; set;}

        /* RELACIONES TABLAS PIVOTE */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* CareerHasSubjects */
            modelBuilder.Entity<CareerHasSubject>()
                .HasKey(cs => new { cs.CareerId, cs.SubjectId});

                modelBuilder.Entity<CareerHasSubject>()
                .HasOne(cs => cs.CareerData)
                .WithMany(c => c.CareerHasSubjects)
                .HasForeignKey(cs => cs.CareerId);

                modelBuilder.Entity<CareerHasSubject>()
                    .HasOne(cs => cs.SubjectData)
                    .WithMany(s => s.CareerHasSubjects)
                    .HasForeignKey(cs => cs.SubjectId);

             /* ProfessorHasUniversities */
            modelBuilder.Entity<ProfessorHasUniversity>()
                .HasKey(pu => new { pu.ProfessorId, pu.UniversityId});

                modelBuilder.Entity<ProfessorHasUniversity>()
                .HasOne(pu => pu.ProfessorData)
                .WithMany(p => p.ProfessorHasUniversities)
                .HasForeignKey(pu => pu.ProfessorId);

                modelBuilder.Entity<ProfessorHasUniversity>()
                    .HasOne(pu => pu.UniversityData)
                    .WithMany(u => u.ProfessorHasUniversities)
                    .HasForeignKey(pu => pu.UniversityId);

             /* SubjectHasInscription */
            modelBuilder.Entity<SubjectHasInscription>()
                .HasKey(si => new { si.SubjectId, si.InscriptionId});

                modelBuilder.Entity<SubjectHasInscription>()
                .HasOne(si => si.SubjectData)
                .WithMany(s => s.SubjectHasInscriptions)
                .HasForeignKey(pu => pu.SubjectId);

                modelBuilder.Entity<SubjectHasInscription>()
                    .HasOne(si => si.InscriptionData)
                    .WithMany(i => i.SubjectHasInscriptions)
                    .HasForeignKey(si => si.InscriptionId);

            /* SubjectHasProfessor */
            modelBuilder.Entity<SubjectHasInscription>()
                .HasKey(si => new { si.SubjectId, si.InscriptionId});

                modelBuilder.Entity<SubjectHasInscription>()
                .HasOne(si => si.SubjectData)
                .WithMany(s => s.SubjectHasInscriptions)
                .HasForeignKey(pu => pu.SubjectId);

                modelBuilder.Entity<SubjectHasInscription>()
                    .HasOne(si => si.InscriptionData)
                    .WithMany(i => i.SubjectHasInscriptions)
                    .HasForeignKey(si => si.InscriptionId);

            /* UniversityHasCareer */
            modelBuilder.Entity<UniversityHasCareer>()
                .HasKey(uc => new { uc.UniversityId, uc.CareerId});

                modelBuilder.Entity<UniversityHasCareer>()
                .HasOne(uc => uc.UniversityData)
                .WithMany(u => u.UniversityHasCareers)
                .HasForeignKey(uc => uc.UniversityId);

                modelBuilder.Entity<UniversityHasCareer>()
                    .HasOne(uc => uc.CareerData)
                    .WithMany(c => c.UniversityHasCareers)
                    .HasForeignKey(uc => uc.CareerId);

            /* UniversityHasCareer */
            modelBuilder.Entity<UniversityHasStudent>()
                .HasKey(us => new { us.UniversityId, us.StudentId});

                modelBuilder.Entity<UniversityHasStudent>()
                .HasOne(us => us.UniversityData)
                .WithMany(u => u.UniversityHasStudents)
                .HasForeignKey(us => us.UniversityId);

                modelBuilder.Entity<UniversityHasStudent>()
                    .HasOne(us => us.StudentData)
                    .WithMany(s => s.UniversityHasStudents)
                    .HasForeignKey(us => us.StudentId);

            base.OnModelCreating(modelBuilder);
        }

    }
}