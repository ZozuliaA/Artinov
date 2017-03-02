using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HADatabaseEntity
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public bool Unavaible { get; set; }
    }
}