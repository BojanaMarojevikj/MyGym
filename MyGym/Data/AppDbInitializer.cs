using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyGym.Data.Static;
using MyGym.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGym.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Training center
                if (!context.TrainingCenters.Any()) {
                    context.TrainingCenters.AddRange(new List<TrainingCenter>()
                    {
                        new TrainingCenter()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new TrainingCenter()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new TrainingCenter()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new TrainingCenter()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new TrainingCenter()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }

                //Equipments
                if (!context.Equipments.Any())
                {
                    context.Equipments.AddRange(new List<Equipment>()
                    {
                        new Equipment()
                        {
                            Name = "Actor 1",
                            Description = "This is the Bio of the first actor",
                            PictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Equipment()
                        {
                            Name = "Actor 2",
                            Description = "This is the Bio of the second actor",
                            PictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Equipment()
                        {
                            Name = "Actor 3",
                            Description = "This is the Bio of the second actor",
                            PictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Equipment()
                        {
                            Name = "Actor 4",
                            Description = "This is the Bio of the second actor",
                            PictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Equipment()
                        {
                            Name = "Actor 5",
                            Description = "This is the Bio of the second actor",
                            PictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();

                }

                //Coaches
                if (!context.Coaches.Any())
                {
                    context.Coaches.AddRange(new List<Coach>()
                    {
                        new Coach()
                        {
                            Name = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            PictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Coach()
                        {
                            Name = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            PictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Coach()
                        {
                            Name = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            PictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Coach()
                        {
                            Name = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            PictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Coach()
                        {
                            Name = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            PictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                //Trainings
                if (!context.Trainings.Any())
                {
                    context.Trainings.AddRange(new List<Training>()
                    {
                        new Training()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            TrainingCenterId = 3,
                            CoachId = 3,
                            TrainingCategory = TrainingCategory.HIIT
                        },
                        new Training()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            TrainingCenterId = 1,
                            CoachId = 1,
                            TrainingCategory = TrainingCategory.Cardio
                        },
                        new Training()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            TrainingCenterId = 4,
                            CoachId = 4,
                            TrainingCategory =  TrainingCategory.Upper_Body
                        },
                        new Training()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            TrainingCenterId = 1,
                            CoachId = 2,
                            TrainingCategory = TrainingCategory.Lower_Body
                        },
                        new Training()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            TrainingCenterId = 1,
                            CoachId = 3,
                            TrainingCategory = TrainingCategory.Pilates
                        },
                        new Training()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            TrainingCenterId = 1,
                            CoachId = 5,
                            TrainingCategory = TrainingCategory.Yoga
                        }
                    });
                    context.SaveChanges();
                }

                //Equipments & Trainings
                if (!context.Equipments_Trainings.Any())
                {
                    context.Equipments_Trainings.AddRange(new List<Equipment_Training>()
                    {
                        new Equipment_Training()
                        {
                            EquipmentId = 1,
                            TrainingId = 1
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 3,
                            TrainingId = 1
                        },

                         new Equipment_Training()
                        {
                            EquipmentId = 1,
                            TrainingId = 2
                        },
                         new Equipment_Training()
                        {
                           EquipmentId = 4,
                            TrainingId = 2
                        },

                        new Equipment_Training()
                        {
                            EquipmentId = 1,
                            TrainingId = 3
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 2,
                            TrainingId = 3
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 5,
                            TrainingId = 3
                        },


                        new Equipment_Training()
                        {
                            EquipmentId = 2,
                            TrainingId = 4
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 3,
                            TrainingId = 4
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 4,
                            TrainingId = 4
                        },


                        new Equipment_Training()
                        {
                            EquipmentId = 2,
                            TrainingId = 5
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 3,
                            TrainingId = 5
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 4,
                            TrainingId = 5
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 5,
                            TrainingId = 5
                        },


                        new Equipment_Training()
                        {
                            EquipmentId = 3,
                            TrainingId = 6
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 4,
                            TrainingId = 6
                        },
                        new Equipment_Training()
                        {
                            EquipmentId = 5,
                            TrainingId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                
                if(!await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                string adminUserEmail = "admin@mygym.com";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Admin123!");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                

                string appUserEmail = "user@mygym.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "User123!");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
