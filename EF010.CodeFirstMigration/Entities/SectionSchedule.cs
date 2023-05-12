namespace EF010.CodeFirstMigration.Entities
{
    public class SectionSchedule
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int ScheduleId { get; set; }

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}