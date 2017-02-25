using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HADatabaseEntity;

namespace HADatabaseEntity
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DoctorId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string LastName { get; set; }
        public virtual Specialty Specialty { get; set; } //public Guid DORId { get; set; } //FK
        public virtual DaysOfReceiving DaysOfReceiving { get; set; } //public Guid DORId { get; set; } //FK
         //public Guid TORId { get; set; } //FK
    }
}
