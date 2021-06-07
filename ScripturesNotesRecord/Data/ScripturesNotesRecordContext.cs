using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScripturesNotesRecord.Models;

namespace ScripturesNotesRecord.Data
{
    public class ScripturesNotesRecordContext : DbContext
    {
        public ScripturesNotesRecordContext (DbContextOptions<ScripturesNotesRecordContext> options)
            : base(options)
        {
        }

        public DbSet<ScripturesNotesRecord.Models.Scripture> Scripture { get; set; }
    }
}
