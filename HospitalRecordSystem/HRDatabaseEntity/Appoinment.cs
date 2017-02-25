using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HADatabaseEntity;

namespace HADatabaseEntity
{
    public class Appoinment
    {
        public Appoinment()
        {
            AppointmentId = new Guid();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AppointmentId { get; set; }
        [Required]
        public int RecordNumber { get; set; }
        [Required]
        public DateTime Date { get; set; }
        
        public virtual Doctor Doctor { get; set; } //FK
        public virtual Room Room { get; set; }   //FK
        public virtual Patient Patient { get; set; }  //FK

        //public virtual Time Time { get; set; }    //FK
    }
}