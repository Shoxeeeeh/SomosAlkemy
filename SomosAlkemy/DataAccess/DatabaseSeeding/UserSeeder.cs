using Microsoft.EntityFrameworkCore;
using SomosAlkemy.Entities;

namespace SomosAlkemy.DataAccess.DatabaseSeeding
{
    public class UserSeeder : IEntitySeeder     
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    DNI = "42305828",
                    Email = "mathiasdavid@live.ca",
                    FirstName = "Mathias",
                    LastName = "Perez",
                    IsDeleted = false,
                    Password = "1234"
                },
                 new User
                 {
                     Id = 2,
                     DNI = "4231145",
                     Email = "jorgeperez@live.ca",
                     FirstName = "Jorge",
                     LastName = "Perez",
                     IsDeleted = false,
                     Password = "3332"
                 }

                );
        }
    }
}
