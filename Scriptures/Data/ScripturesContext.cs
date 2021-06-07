using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scriptures.Models;

namespace Scriptures.Data
{
    public class ScripturesContext : DbContext
    {
        public ScripturesContext (DbContextOptions<ScripturesContext> options)
            : base(options)
        {
        }

        public DbSet<Scriptures.Models.Scripture> Scripture { get; set; }
    }
}
