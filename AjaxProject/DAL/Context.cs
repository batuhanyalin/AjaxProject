using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;initial catalog=AjaxDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
