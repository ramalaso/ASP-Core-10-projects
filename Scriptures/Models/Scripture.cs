﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Scriptures.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }
        public string Note { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
