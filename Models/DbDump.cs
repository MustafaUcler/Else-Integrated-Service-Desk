
namespace Else_ISD.Models
{
    public class DbDump
    {
        public int DbDumpId { get; set; } // PK
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public long FileSize { get; set; }
        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; } // Foreign key to the user who created the dump
        public User CreatedByUser { get; set; } // Navigation property to the user
    }
}
