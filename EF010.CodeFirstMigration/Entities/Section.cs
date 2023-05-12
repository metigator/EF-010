namespace EF010.CodeFirstMigration.Entities
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<SectionSchedule> SectionSchedules { get; set; } = new List<SectionSchedule>();


    }
}
