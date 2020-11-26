using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Borc_Irina_Lab8.Models;

namespace Borc_Irina_Lab8.Data
{
    public class Borc_Irina_Lab8Context : DbContext
    {
        public Borc_Irina_Lab8Context (DbContextOptions<Borc_Irina_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Borc_Irina_Lab8.Models.Book> Book { get; set; }

        public DbSet<Borc_Irina_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Borc_Irina_Lab8.Models.Category> Category { get; set; }
    }
}
