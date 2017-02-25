using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HADatabaseEntity
{
    public class Passport
    {
        [Key]
        //+
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PassportId { get; set; }
        public string SeriesA { get; set; }
        public int SeriesN { get; set; }
        public int BDay { get; set; }
        public int BMonth { get; set; }
        public int BYear { get; set; }
        public int DayIoP { get; set; }
        public int YearIoP { get; set; }
    }
}