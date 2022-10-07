using Project.ENTITIES.Models;
using Project.MAP.Optionals;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HomeMap());
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AboutMap());
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new CommentMap());
        }

        public DbSet<Home>  Homes { get; set; }
        public DbSet<AppUser>   AppUsers { get; set; }
        public DbSet<About>   Abouts { get; set; }
        public DbSet<Blog>   Blogs { get; set; }
        public DbSet<Address>   Addresses { get; set; }
        public DbSet<Contact>   Contacts { get; set; }
        public DbSet<Comment>   Comments { get; set; }
    }
}
