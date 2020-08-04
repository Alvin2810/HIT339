using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldMVCWebApp._00Data
{
    public class MovieDBContext: DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
