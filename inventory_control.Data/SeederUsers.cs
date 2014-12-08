using inventory_control.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data
{
    internal static class SeederUsers
    {
        internal static void Seed(ApplicationDbContext db)
        {
            UserManager<ApplicationUser> userManager =
                new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            RoleManager<Role> roleManager =
                new RoleManager<Role>(new RoleStore<Role>(db));

            //Seed roles
            if (!roleManager.RoleExists(Role.ADMIN))
            {
                roleManager.Create(new Role
                {
                    Name = Role.ADMIN
                });
            }

            if (!roleManager.RoleExists(Role.GENERAL))
            {
                roleManager.Create(new Role
                {
                    Name = Role.GENERAL
                });
            }

            db.SaveChanges();

            Department dept1 = db.Departments.FirstOrDefault(d => d.DepartmentName == "Admin");

            //Seed users
            ApplicationUser user1 = userManager.FindByEmail("admin@email.com");

            if (user1 == null)
            {
                userManager.Create(new ApplicationUser
                {
                    Email = "admin@email.com",
                    UserName = "admin@email.com",
                    FirstName = "Bill",
                    LastName = "Smith",
                    DepartmentId = dept1.DepartmentId
                }, "123456");
            }

            ApplicationUser user2 = userManager.FindByEmail("bill@email.com");

            if (user2 == null)
            {
                userManager.Create(new ApplicationUser
                {
                    Email = "user1@email.com",
                    UserName = "user1@email.com",
                    FirstName = "Mary",
                    LastName = "Jones",
                    DepartmentId = dept1.DepartmentId
                }, "123456");
            }

            ApplicationUser user3 = userManager.FindByEmail("mary@email.com");

            if (user3 == null)
            {
                userManager.Create(new ApplicationUser
                {
                    Email = "user2@email.com",
                    UserName = "user2@email.com",
                    FirstName = "Ted",
                    LastName = "Doe",
                    DepartmentId = dept1.DepartmentId
                }, "123456");
            }

            db.SaveChanges();

            user1 = userManager.FindByEmail("admin@email.com");

            if (!userManager.IsInRole(user1.Id, Role.ADMIN))
            {
                userManager.AddToRole(user1.Id, Role.ADMIN);
            }

            user2 = userManager.FindByEmail("user1@email.com");

            if (!userManager.IsInRole(user2.Id, Role.GENERAL))
            {
                userManager.AddToRole(user2.Id, Role.GENERAL);
            }

            user3 = userManager.FindByEmail("user2@email.com");

            if (!userManager.IsInRole(user3.Id, Role.GENERAL))
            {
                userManager.AddToRole(user3.Id, Role.GENERAL);
            }
        }
    }
}
