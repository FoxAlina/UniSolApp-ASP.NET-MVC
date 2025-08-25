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
                            Name = "User",
                            Surname = "One",
                            Password = "One",
                            CreatedDateTime = DateTime.UtcNow
                        },
                        new User()
                        {
                            Id = Guid.NewGuid(),
                            Name = "User",
                            Surname = "Two",
                            Password = "Two",
                            CreatedDateTime = DateTime.UtcNow
                        },
                        new User()
                        {
                            Id = Guid.NewGuid(),
                            Name = "User",
                            Surname = "Three",
                            Password = "Three",
                            CreatedDateTime = DateTime.UtcNow
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
                            Name = "Item 1",
                            Description = "Item number one.",
                            CreatedDateTime = DateTime.UtcNow,
                            UserId = userId,
                            ModuleId = moduleId,
                            ModuleUserId = userId
                        },
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Item 2",
                            Description = "Item number two.",
                            CreatedDateTime = DateTime.UtcNow,
                            UserId = userId,
                            ModuleId = moduleId,
                            ModuleUserId = userId
                        },
                        new Item()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Item 3",
                            Description = "Item number three.",
                            CreatedDateTime = DateTime.UtcNow,
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
                            Name = "Module 1",
                            Description = "Module number one.",
                            CreatedDateTime = DateTime.UtcNow,
                            UserId = userId
                        },
                        new Module()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Module 2",
                            Description = "Module number two.",
                            CreatedDateTime = DateTime.UtcNow,
                            UserId = userId
                        },
                        new Module()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Module 3",
                            Description = "Module number three.",
                            CreatedDateTime = DateTime.UtcNow,
                            UserId = userId
                        }
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
