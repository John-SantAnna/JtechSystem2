using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JtechSystem.Models;

namespace JtechSystem.Data
{
    public class JtechSystemContext : DbContext
    {
        public JtechSystemContext (DbContextOptions<JtechSystemContext> options)
            : base(options)
        {
        }

        public DbSet<JtechSystem.Models.Ticket> Ticket { get; set; }
    }
}
