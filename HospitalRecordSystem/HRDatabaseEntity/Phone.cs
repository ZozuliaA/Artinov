using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HADatabaseEntity
{
    public class Phone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PhoneId { get; set; }
        public string home { get; set; }
        public string work { get; set; }
        public string mobile { get; set; }
    }
}