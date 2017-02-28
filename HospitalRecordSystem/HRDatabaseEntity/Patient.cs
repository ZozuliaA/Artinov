using System;
using System.Collections.Generic;
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
        //[ForeignKey("AddressId")]
        public virtual Address Address { get; set; }  //FK
        //[ForeignKey("PhoneId")]
        public virtual Phone Phone { get; set; }   //FK
        //[ForeignKey("PassportId")]
        public virtual Passport Passport { get; set; }   //FK
        public virtual HistoryBook HistoryBook { get; set; }   //FK
        public string Email { get; set; }
        [Index(IsUnique = true)]
        [MinLength(3)]
        [MaxLength(30)]
        public string Login { get; set; }
        [MinLength(6)]
        [MaxLength(32)]
        public string Password { get; set; }
        public virtual ICollection<Appoinment> Appoinments { get; set; }
    }
}