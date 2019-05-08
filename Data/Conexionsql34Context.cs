using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Conexionsql34.Models
{
    public class Conexionsql34Context : DbContext
    {
        public Conexionsql34Context (DbContextOptions<Conexionsql34Context> options)
            : base(options)
        {
        }

        public DbSet<Conexionsql34.Models.Cliente> Cliente { get; set; }
    }
}
