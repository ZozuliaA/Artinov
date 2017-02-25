using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HADatabaseEntity
{
    public class HistoryBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HistoryBookId { get; set; }
        public int BookNumber { get; set; }
        public int Comment { get; set; }
    }
}