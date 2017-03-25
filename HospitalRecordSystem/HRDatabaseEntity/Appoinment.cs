using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HADatabaseEntity;

namespace HADatabaseEntity
{
    public class Appoinment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AppointmentId { get; set; }
        [Required]
        public int RecordNumber { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Time { get; set; }
        //[ForeignKey("DoctorId")]
        //public virtual Guid Doctor { get; set; } //FK
        public virtual Doctor Doctor { get; set; } //FK
        //[ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }  //FK
        //[ForeignKey("RoomId")]
        public virtual Room Room { get; set; }    //FK
    }
}