using Dotnet.Microservices.Auth.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Microservices.Auth.API.Data
{
    public class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            context.Users.Add(new User
            {
                FirstName = "Mark",
                LastName = "Anderson" ,
                Email = $"mark.anderson@abc.com"
            });

            context.Users.Add(new User
            {
                FirstName = "Tony",
                LastName = "Lee",
                Email = $"tony.lee@abc.com"
            });

            context.Users.Add(new User
            {
                FirstName = "Frank",
                LastName = "Johnson",
                Email = $"frank.johnson@abc.com"
            });

            context.SaveChanges();
        }
    }
}
