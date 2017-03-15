using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HADatabaseEntity
{
    public class TimeOfReceiving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TORId { get; set; }
        public bool T10_00 { get; set; }
        public bool T10_20 { get; set; }
        public bool T10_40 { get; set; }
        public bool T11_00 { get; set; }
        public bool T12_00 { get; set; }
    }
}