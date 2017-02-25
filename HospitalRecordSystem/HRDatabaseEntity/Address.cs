using System;
using System.ComponentModel.DataAnnotations;

namespace HADatabaseEntity
{
    public class Address
    {
        public Guid AddressId { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public int ApartamentNumber { get; set; } 
    }
}