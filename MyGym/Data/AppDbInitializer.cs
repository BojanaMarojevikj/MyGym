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
                            Name = "Rituals Studio",
                            Logo = "https://scontent-dfw5-2.xx.fbcdn.net/v/t39.30808-6/305568212_614722836751296_941147583496687606_n.png?_nc_cat=108&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGfyYJF8jKBG8Cn6l0-p-auBOijdtk4SLYE6KN22ThItqCAcm-5H_wIdbmBfjqyXWpgwvFAw11WMkGsOv5x7NcK&_nc_ohc=cisoq1v51toAX_CaPL8&_nc_ht=scontent-dfw5-2.xx&oh=00_AfBCK00CP30kcGnntf317FzSOGwHKW83PrjtTFyJMbnzZQ&oe=63D35F5E",
                            Description = "Rituals Studio is a fitness studio located in Karpos. It is open every day except Sunday. It offers a wide variety of trainings including functional training, HIIT, upper body and lower body."
                        },
                        new TrainingCenter()
                        {
                            Name = "The Yoga Place",
                            Logo = "https://scontent-dfw5-2.xx.fbcdn.net/v/t39.30808-6/299121364_591743208984068_282569798793587096_n.png?_nc_cat=106&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeFucnwBReeWP1rQuCJL59cePLZqzLsHSI88tmrMuwdIjyld1IDddnFlQUVyr3gvMImmHG6QMP21RUnrwEUru0nP&_nc_ohc=RAPsRwXGpXIAX8MBGLG&_nc_ht=scontent-dfw5-2.xx&oh=00_AfAcPG62VP3X6dBQsGrfFAK8ql_lBEJYJtZlI3xuuq-WqA&oe=63D1B318",
                            Description = "The Yoga Place is a yoga studio located in Debar Maalo, Skopje. It is open Monday through Thursday and it offers many different types of yoga."
                        },
                        new TrainingCenter()
                        {
                            Name = "SC Boris Trajkovski",
                            Logo = "https://sportmaster.mk/images/complex/2781586352425a0f81495b53619c53ecc682a759a25b8.jpg",
                            Description = "The BORIS TRAJKOVSKI Sports Center is an elite complex and is the only multi-functional center on the territory of the Republic of Macedonia."
                        },
                        new TrainingCenter()
                        {
                            Name = "Trinity",
                            Logo = "https://scontent-dfw5-2.xx.fbcdn.net/v/t1.18169-9/1797447_399853563491292_916855896_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=d57657&_nc_eui2=AeHQtZD0PoGdjgarAvvbsfuqJMMJNliMBwokwwk2WIwHCmkiabRE1suMslAhrgx49kZn7S6chmUEGBW1S_zzP67T&_nc_ohc=ESiFCDfAvcEAX9za4eG&_nc_ht=scontent-dfw5-2.xx&oh=00_AfCxVwhBSldcuOsuVTusgoX1hincadRWrNQLH_GYd8ws9g&oe=63F4E9BC",
                            Description = "Trinity is a fitness center located in the center of Skopje, North Macedonia. It offers programs like pilates and yoga."
                        },
                        new TrainingCenter()
                        {
                            Name = "Ultimatefit Alebras",
                            Logo = "https://scontent-dfw5-2.xx.fbcdn.net/v/t39.30808-6/310043689_513485604119393_4862758865012566748_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeFh640YTO5eecCxBfimf7FGkCFGonWMBTCQIUaidYwFMGSAWE6QwBK9VlJvBFfMbCYyUiuBJxEDyt_Vrct1iKjg&_nc_ohc=a5GdkFPPKH4AX8xf3IW&_nc_ht=scontent-dfw5-2.xx&oh=00_AfC0vGDqTJolA5HiETZ67In95ZOeLexXg1kJbvrPgXTndw&oe=63D219E0",
                            Description = "Ultimatefit Alebras is a fitness center that offers one of the best crossfit programs in Skopje, Macedonia. It is located next to the Josip Broz Tito high school in the center of Skopje."
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
                            Name = "Equipment 1",
                            Description = "This is the Bio of the first Equipment",
                            PictureURL = "https://m.media-amazon.com/images/I/41AMoDiOhyL._AC_SY1000_.jpg"

                        },
                        new Equipment()
                        {
                            Name = "Equipment 2",
                            Description = "This is the Bio of the second Equipment",
                            PictureURL = "https://m.media-amazon.com/images/I/41AMoDiOhyL._AC_SY1000_.jpg"
                        },
                        new Equipment()
                        {
                            Name = "Equipment 3",
                            Description = "This is the Bio of the second Equipment",
                            PictureURL = "https://m.media-amazon.com/images/I/41AMoDiOhyL._AC_SY1000_.jpg"
                        },
                        new Equipment()
                        {
                            Name = "Equipment 4",
                            Description = "This is the Bio of the second Equipment",
                            PictureURL = "https://m.media-amazon.com/images/I/41AMoDiOhyL._AC_SY1000_.jpg"
                        },
                        new Equipment()
                        {
                            Name = "Equipment 5",
                            Description = "This is the Bio of the second Equipment",
                            PictureURL = "https://m.media-amazon.com/images/I/41AMoDiOhyL._AC_SY1000_.jpg"
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
                            Name = "Coach 1",
                            Bio = "This is the Bio of the first Coach",
                            PictureURL = "https://hips.hearstapps.com/hmg-prod/images/mh-trainer-2-1533576998.png"

                        },
                        new Coach()
                        {
                            Name = "Coach 2",
                            Bio = "This is the Bio of the second Coach",
                            PictureURL = "https://hips.hearstapps.com/hmg-prod/images/mh-trainer-2-1533576998.png"
                        },
                        new Coach()
                        {
                            Name = "Coach 3",
                            Bio = "This is the Bio of the second Coach",
                            PictureURL = "https://hips.hearstapps.com/hmg-prod/images/mh-trainer-2-1533576998.png"
                        },
                        new Coach()
                        {
                            Name = "Coach 4",
                            Bio = "This is the Bio of the second Coach",
                            PictureURL = "https://hips.hearstapps.com/hmg-prod/images/mh-trainer-2-1533576998.png"
                        },
                        new Coach()
                        {
                            Name = "Coach 5",
                            Bio = "This is the Bio of the second Coach",
                            PictureURL = "https://hips.hearstapps.com/hmg-prod/images/mh-trainer-2-1533576998.png"
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
                            Name = "Functional training",
                            Description = "This is the Functional training description",
                            Price = 39.50,
                            ImageURL = "https://www.erjcchouston.org/clientuploads/Photos/Fitness_Center/Fitness_Group_Lunging_med_600x400.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            TrainingCenterId = 3,
                            CoachId = 3,
                            TrainingCategory = TrainingCategory.Beginner
                        },
                        new Training()
                        {
                            Name = "Yoga",
                            Description = "This is the yoga description",
                            Price = 29.50,
                            ImageURL = "https://www.erjcchouston.org/clientuploads/Photos/Fitness_Center/Fitness_Group_Lunging_med_600x400.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            TrainingCenterId = 1,
                            CoachId = 1,
                            TrainingCategory = TrainingCategory.Beginner
                        },
                        new Training()
                        {
                            Name = "Swimming",
                            Description = "This is the swimming description",
                            Price = 39.50,
                            ImageURL = "https://www.erjcchouston.org/clientuploads/Photos/Fitness_Center/Fitness_Group_Lunging_med_600x400.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            TrainingCenterId = 4,
                            CoachId = 4,
                            TrainingCategory =  TrainingCategory.Beginner
                        },
                        new Training()
                        {
                            Name = "Pilates",
                            Description = "This is the pilates description",
                            Price = 39.50,
                            ImageURL = "https://www.erjcchouston.org/clientuploads/Photos/Fitness_Center/Fitness_Group_Lunging_med_600x400.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            TrainingCenterId = 1,
                            CoachId = 2,
                            TrainingCategory = TrainingCategory.Beginner
                        },
                        new Training()
                        {
                            Name = "Crossfit",
                            Description = "This is the crossfit description",
                            Price = 39.50,
                            ImageURL = "https://www.erjcchouston.org/clientuploads/Photos/Fitness_Center/Fitness_Group_Lunging_med_600x400.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            TrainingCenterId = 1,
                            CoachId = 3,
                            TrainingCategory = TrainingCategory.Beginner
                        },
                        new Training()
                        {
                            Name = "HIIT",
                            Description = "This is the HIIT description",
                            Price = 39.50,
                            ImageURL = "https://www.erjcchouston.org/clientuploads/Photos/Fitness_Center/Fitness_Group_Lunging_med_600x400.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            TrainingCenterId = 1,
                            CoachId = 5,
                            TrainingCategory = TrainingCategory.Beginner
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
