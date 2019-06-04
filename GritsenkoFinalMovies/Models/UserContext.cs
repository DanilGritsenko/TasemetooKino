using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GritsenkoFinalMovies.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }


    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            Role admin = new Role { Id = 1, Name = "admin" };
            Role user = new Role { Id = 2, Name = "user" };
            db.Roles.Add(admin);
            db.Roles.Add(user);
            db.Users.Add(new User
            {
                Id = 1,
                Name = "Difictly",
                Email = "difictly1@gmail.com",
                Password = "1",
                Age = 18,
                RoleId = 1
            });
            base.Seed(db);
        }
    }
}