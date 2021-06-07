using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScripturesNotesRecord.Models
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
