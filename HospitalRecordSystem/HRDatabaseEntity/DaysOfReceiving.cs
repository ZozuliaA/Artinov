using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HADatabaseEntity;

namespace HADatabaseEntity
{
    public class DaysOfReceiving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DORId { get; set; }
        public bool Mondey { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Satarday { get; set; }
        public bool Sunday { get; set; }
        //[ForeignKey("TORId")]
        public virtual TimeOfReceiving TimeOfReceiving { get; set; } //FK

        // ENUM  ?????? 
    }
}