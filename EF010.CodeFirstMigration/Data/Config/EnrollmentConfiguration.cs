using EF010.CodeFirstMigration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF010.CodeFirstMigration.Data.Config
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(x => new { x.SectionId, x.StudentId });



            builder.ToTable("Enrollments");


            builder.HasData(LoadEnrollments());
        }

        private static List<Enrollment> LoadEnrollments()
        {
            return new List<Enrollment>
            {
                new Enrollment() { StudentId = 1, SectionId = 6 },
                new Enrollment() { StudentId = 2, SectionId = 6 },
                new Enrollment() { StudentId = 3, SectionId = 7 },
                new Enrollment() { StudentId = 4, SectionId = 7 },
                new Enrollment() { StudentId = 5, SectionId = 8 },
                new Enrollment() { StudentId = 6, SectionId = 8 },
                new Enrollment() { StudentId = 7, SectionId = 9 },
                new Enrollment() { StudentId = 8, SectionId = 9 },
                new Enrollment() { StudentId = 9, SectionId = 10 },
                new Enrollment() { StudentId = 10, SectionId = 10 }
            };
        }
    }
}
