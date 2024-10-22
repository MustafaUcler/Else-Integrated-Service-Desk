using System.ComponentModel.DataAnnotations.Schema;

namespace Else_ISD.Models
{
    public class Issues
    {
        public int IssueId { get; set; }
        public string IssueName { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public DateTime IssueCreated { get; set; }
        public DateTime? IssueUpdated { get; set; }
        public DateTime? IssueCompleted { get; set; }
        public string? AssignedTo { get; set; }
        public PriorityLevel Priority { get; set; }
        public IssueStatus Status { get; set; }
        public int? DbDumpId { get; set; } // foreign key to DbDump

        [ForeignKey("DbDumpId")]
        public DbDump DbDump { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public  User CreatedBy { get; set; } // Navigation to the user Who created the issue
    }

    public enum PriorityLevel
    {
        Low,
        Medium,
        High,
        Critical
    }

    public enum IssueStatus
    {
        Open,
        InProgress,
        Resolved,
        Closed
    }
}
