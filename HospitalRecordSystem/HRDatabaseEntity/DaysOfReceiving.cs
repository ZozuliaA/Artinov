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
        public string Mondey { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Satarday { get; set; }
        public string Sunday { get; set; }
        public virtual TimeOfReceiving TimeOfReceiving { get; set; } //FK

        // ENUM  ?????? 
    }
}