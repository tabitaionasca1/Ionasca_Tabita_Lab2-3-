using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ionasca_Tabita_Lab2_3_.Data;
using Ionasca_Tabita_Lab2_3_.Models;

namespace Ionasca_Tabita_Lab2_3_.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ionasca_Tabita_Lab2_3_.Data.Ionasca_Tabita_Lab2_3_Context _context;

        public IndexModel(Ionasca_Tabita_Lab2_3_.Data.Ionasca_Tabita_Lab2_3_Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
