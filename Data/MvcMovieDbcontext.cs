
using Nhap1.Models;
using Microsoft.EntityFrameworkCore;

namespace Nhap1.Data
{
    public class MvcMovieDbContext : DbContext
    {
        public MvcMovieDbContext (DbContextOptions<MvcMovieDbContext> options) : base(options)
        {

        }

        
        
        public DbSet<PhongBan> PhongBan {get; set;}
        
        
        
    }
}