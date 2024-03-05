using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevWeb001.Models;

namespace DevWeb001.Data
{
    public class DevWeb001Context : DbContext
    {
        public DevWeb001Context (DbContextOptions<DevWeb001Context> options)
            : base(options)
        {
        }

        public DbSet<DevWeb001.Models.Test> Test { get; set; } = default!;
    }
}
