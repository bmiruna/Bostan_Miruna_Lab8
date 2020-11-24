using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bostan_Miruna_Lab8.Models;

namespace Bostan_Miruna_Lab8.Data
{
    public class Bostan_Miruna_Lab8Context : DbContext
    {
        public Bostan_Miruna_Lab8Context (DbContextOptions<Bostan_Miruna_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bostan_Miruna_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bostan_Miruna_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Bostan_Miruna_Lab8.Models.Category> Category { get; set; }
    }
}
