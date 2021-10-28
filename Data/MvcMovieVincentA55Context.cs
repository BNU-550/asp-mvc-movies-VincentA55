using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieVincentA55.Models;

namespace MvcMovieVincentA55.Data
{
    public class MvcMovieVincentA55Context : DbContext
    {
        public MvcMovieVincentA55Context (DbContextOptions<MvcMovieVincentA55Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieVincentA55.Models.Movie> Movie { get; set; }
    }
}
