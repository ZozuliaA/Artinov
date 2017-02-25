using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HADatabaseEntity
{
    public class Specialty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SpecialtyId { get; set; } 
        public string SpecialtyName { get; set; } 
        public string SpecialtyDescription { get; set; } 
    }
}