using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HADatabaseEntity
{
    public class Passport
    {
        [Key]
        //+ ID card
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PassportId { get; set; }
        [Required]
        public string SeriesA { get; set; }
        [Required]
        public int SeriesN { get; set; }
        [Required]
        public int BDay { get; set; }
        [Required]
        public int BMonth { get; set; }
        [Required]
        public int BYear { get; set; }
        [Required]
        public int DayIoP { get; set; }
        [Required]
        public int YearIoP { get; set; }
    }
}