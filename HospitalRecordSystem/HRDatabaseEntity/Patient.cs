using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HADatabaseEntity;

namespace HADatabaseEntity
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PatientId { get; set; }
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(150)]
        public string SecondName { get; set; }
        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }
        public virtual Address Address { get; set; }  //FK
        public virtual Phone Phone { get; set; }   //FK
        public virtual Passport Passport { get; set; }   //FK
        public virtual HistoryBook HistoryBook { get; set; }   //FK
        public string Email { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(30)]
        public string Login { get; set; }
        public string Password { get; set; }
    }
}