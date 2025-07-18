using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalSolutionApplication.Models;

namespace UniversalSolutionApplication.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                Guid userId = Guid.NewGuid();
                Guid moduleId = Guid.NewGuid();

                context.Database.EnsureCreated();

                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            Id = userId,
                            SurrogateId = "User-001",
                            Name = "User",
                            Surname = "One",
                            Password = "One",
                            CreatedDateTime = DateTime.Today
                        },
                        new User()
                        {
                            Id = Guid.NewGuid(),
                            SurrogateId = "User-002",
                            Name = "User",
                            Surname = "Two",
                            Password = "Two",
                            CreatedDateTime = DateTime.Today
                        },
                        new User()
                        {
                            Id = Guid.NewGuid(),
                            SurrogateId = "User-003",
                            Name = "User",
                            Surname = "Three",
                            Password = "Three",
                            CreatedDateTime = DateTime.Today
                        }
                    });
                }

                if (!context.Items.Any())
                {
                    context.Items.AddRange(new List<Item>()
                    {
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            SurrogateId = "Item-001",
                            Name = "Item 1",
                            Description = "Item number one.",
                            CreatedDateTime = DateTime.Today,
                            UserId = userId,
                            ModuleId = moduleId,
                            ModuleUserId = userId
                        },
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            SurrogateId = "Item-002",
                            Name = "Item 2",
                            Description = "Item number two.",
                            CreatedDateTime = DateTime.Today,
                            UserId = userId,
                            ModuleId = moduleId,
                            ModuleUserId = userId
                        },
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            SurrogateId = "Item-003",
                            Name = "Item 3",
                            Description = "Item number three.",
                            CreatedDateTime = DateTime.Today,
                            UserId = userId,
                            ModuleId = moduleId,
                            ModuleUserId = userId
                        }
                    });
                }

                if (!context.Modules.Any())
                {
                    context.Modules.AddRange(new List<Module>()
                    {
                        new Module()
                        {
                            Id = moduleId,
                            SurrogateId = "Module-001",
                            Name = "Module 1",
                            Description = "Module number one.",
                            CreatedDateTime = DateTime.Today,
                            UserId = userId
                        },
                        new Module()
                        {
                            Id = Guid.NewGuid(),
                            SurrogateId = "Module-002",
                            Name = "Module 2",
                            Description = "Module number two.",
                            CreatedDateTime = DateTime.Today,
                            UserId = userId
                        },
                        new Module()
                        {
                            Id = Guid.NewGuid(),
                            SurrogateId = "Module-003",
                            Name = "Module 3",
                            Description = "Module number three.",
                            CreatedDateTime = DateTime.Today,
                            UserId = userId
                        }
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
