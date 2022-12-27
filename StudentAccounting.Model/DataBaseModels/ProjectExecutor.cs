
namespace StudentAccounting.Model.DataBaseModels
{
    public class ProjectExecutor
    {
        public int Id { get; set; }
        public string Responsibilities { get; set; } = string.Empty;
        public string WorkStatus { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public DateTime DateEnd { get; set; }

        public int ParticipantsId { get; set; }
        public Participants? Participants { get; set; }
        public int ProjectId { get; set; }
        public Project? Projects { get; set; }
    }
}
