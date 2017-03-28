﻿using System;
using System.Collections.Generic;
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
        [Required]
        public string Role { get; set; }
        public string LoginD { get; set; }
        public string HashD { get; set; }

        //[ForeignKey("SpecialtyId")]
        public virtual Specialty Specialty { get; set; }
        public virtual DaysOfReceiving DaysOfReceiving { get; set; }
        //public Guid DORId { get; set; } //FK
        //[ForeignKey("DORId")]
        //public Guid DORId { get; set; } //FK
        //public Guid TORId { get; set; } //FK
    }
}
