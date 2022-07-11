using LivresWebApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivresWebApplication.data
{
    public class LivreContext: DbContext
    {
        public LivreContext(DbContextOptions<LivreContext> options) : base(options)
        {

        }
        public DbSet<Livre> livre { get; set; }
    }
}
