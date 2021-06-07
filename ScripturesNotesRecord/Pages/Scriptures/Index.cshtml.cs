using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScripturesNotesRecord.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ScripturesNotesRecord.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScripturesNotesRecord.Data.ScripturesNotesRecordContext _context;

        public IndexModel(ScripturesNotesRecord.Data.ScripturesNotesRecordContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchBook { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchKeyword { get; set; }

        public async Task OnGetAsync()
        {
            var scriptures = from m in _context.Scripture
                             select m;

            if (!string.IsNullOrEmpty(SearchBook))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchBook));
            }

            if (!string.IsNullOrEmpty(SearchKeyword))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchKeyword));
            }

            Scripture = await scriptures.ToListAsync();
        }
    }
}
