using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Revisor.Models;

namespace Revisor.Data
{
    public class RevisorContext : DbContext
    {
        public RevisorContext (DbContextOptions<RevisorContext> options)
            : base(options)
        {
        }

        public DbSet<Revisor.Models.Books> Books { get; set; } = default!;
    }
}
