﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HADatabaseEntity
{
    public class TimeOfReceiving
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TORId { get; set; }
        public int T10_00 { get; set; }
        public int T10_20 { get; set; }
        public int T10_40 { get; set; }
        public int T11_00 { get; set; }
        public int T12_00 { get; set; }
    }
}