using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    // ORM - EntityFramework, Dapper, NHibernate
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
