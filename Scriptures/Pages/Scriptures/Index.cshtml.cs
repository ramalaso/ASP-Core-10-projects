using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Scriptures.Data;
using Scriptures.Models;

namespace Scriptures.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly Scriptures.Data.ScripturesContext _context;

        public IndexModel(Scriptures.Data.ScripturesContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        public async Task OnGetAsync()
        {
            Scripture = await _context.Scripture.ToListAsync();
        }
    }
}
