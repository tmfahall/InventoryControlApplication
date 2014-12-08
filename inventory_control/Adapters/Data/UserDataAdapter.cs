using inventory_control.Models;
using inventory_control.Data;
using inventory_control.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace inventory_control.Adapters.Data
{
    public class UserDataAdapter : IUserAdapter
    {
        public UsersVM GetUsers()
        {
            UsersVM model = new UsersVM();

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model.Users = db.Users.Select(u => new UserVM
                {
                    UserId = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    DepartmentName = u.Department.DepartmentName,
                    DepartmentId = u.Department.DepartmentId,
                    Email = u.Email,
                    UserName = u.UserName

                }).ToList();
            }
            return model;
        }

        public UsersVM GetUser(string userId)
        {
            UsersVM model = new UsersVM();

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model.Users = db.Users.Where(u => u.Id == userId).Select(u => new UserVM
                {
                    UserId = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    DepartmentName = u.Department.DepartmentName,
                    DepartmentId = u.Department.DepartmentId,
                    Email = u.Email,
                    UserName = u.UserName

                }).ToList();

                LookupDataAdapter lookups = new LookupDataAdapter();
                model.Departments = lookups.GetDepartments();

            }
            return model;
        }


        public UsersVM SaveUser(UserVM model, string pass)
        {

            UsersVM users = new UsersVM();

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                UserManager<ApplicationUser> userManager =
                    new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                RoleManager<Role> roleManager =
                    new RoleManager<Role>(new RoleStore<Role>(db));

                ApplicationUser dbUser = db.Users.FirstOrDefault(u => u.Id == model.UserId);
                ApplicationUser user = userManager.FindById(model.UserId);
                bool isNewUser = false;

                if (user == null)
                {
                    isNewUser = true;
                    userManager.Create(new ApplicationUser
                    {
                        Email = model.Email,
                        UserName = model.UserName,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        DepartmentId = model.DepartmentId
                    }, pass);
                }
                else
                {
                    user.Email = model.Email;
                    user.UserName = model.UserName;
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.DepartmentId = model.DepartmentId;
                }

                db.SaveChanges();                   
                user = userManager.FindByEmail(model.Email);

                if (isNewUser)
                {


                    if (!userManager.IsInRole(user.Id, Role.GENERAL))
                    {
                        userManager.AddToRole(user.Id, Role.GENERAL);
                    }
                    db.SaveChanges();

                }

                users = GetUser(user.Id);
            }
            return users;

        }


        public DepartmentsVM GetDepartments()
        {
            LookupDataAdapter lookups = new LookupDataAdapter();
            return lookups.GetDepartments();
        }
    }
}