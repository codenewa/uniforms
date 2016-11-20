using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformBuilder.Utility;

namespace UniformBuilder.EF.Seeds
{
    public class UserSeed: ISeed
    {
        public void RunSeed(UniformBuilderContext context)
        {
            var users = new List<User>
            {
                new User
                {
                    Id = IdGenerator.NewId(),
                    Name = "Ashish",
                    Type = UserType.Admin
                },
                new User
                {
                    Id = IdGenerator.NewId(),
                    Name = "Bob",
                    Type = UserType.Dealer
                },
                new User
                {
                    Id = IdGenerator.NewId(),
                    Name = "Ann",
                    Type = UserType.Guest
                }
            };

            context.AddOrUpdate<User>(m=>m.Id, users);
        }
    }
}
