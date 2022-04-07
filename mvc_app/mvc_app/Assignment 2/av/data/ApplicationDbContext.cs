using av.Models;
using Microsoft.EntityFrameworkCore;
namespace av{
    public class ApplicationDBContext: DbContext{
      public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options){
      }
      public DbSet<Student> Students { get; set; }

      public DbSet<Subject> Subject { get; set; }   
      public DbSet<Teacher> Teachers { get; set; }   
    }
} 