using BYBlog.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYBlog.DAL.Concrete
{
    public class BYBlog_DbContext:DbContext
    {
        public BYBlog_DbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Server=localhost;Port=5432;Database=BYBlogDb;Integrated Security=true;Pooling=true;");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.UseSerialColumns();
            modelBuilder.UseIdentityColumns();
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }






    }
}
