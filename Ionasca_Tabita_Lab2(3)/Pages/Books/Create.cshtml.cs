﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ionasca_Tabita_Lab2_3_.Data;
using Ionasca_Tabita_Lab2_3_.Models;

namespace Ionasca_Tabita_Lab2_3_.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Ionasca_Tabita_Lab2_3_.Data.Ionasca_Tabita_Lab2_3_Context _context;

        public CreateModel(Ionasca_Tabita_Lab2_3_.Data.Ionasca_Tabita_Lab2_3_Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
