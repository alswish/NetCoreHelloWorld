using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstWebProject.Models
{
    public class MyFirstWebProjectContext : DbContext
    {
        public MyFirstWebProjectContext (DbContextOptions<MyFirstWebProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MyFirstWebProject.Models.Movie> Movie { get; set; }
    }
}
