using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace summer19.Models
{
    public class CorporateContext:DbContext
    {
        public CorporateContext(DbContextOptions<CorporateContext> options):base(options)
        {

        }

        public DbSet<Requirement> Requirements { get; set; }
    }
}
