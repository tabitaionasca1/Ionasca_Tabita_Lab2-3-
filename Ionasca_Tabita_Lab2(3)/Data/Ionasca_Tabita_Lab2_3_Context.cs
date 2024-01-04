using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ionasca_Tabita_Lab2_3_.Models;

namespace Ionasca_Tabita_Lab2_3_.Data
{
    public class Ionasca_Tabita_Lab2_3_Context : DbContext
    {
        public Ionasca_Tabita_Lab2_3_Context (DbContextOptions<Ionasca_Tabita_Lab2_3_Context> options)
            : base(options)
        {
        }

        public DbSet<Ionasca_Tabita_Lab2_3_.Models.Book> Book { get; set; } = default!;
    }
}
