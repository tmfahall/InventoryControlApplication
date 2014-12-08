using inventory_control.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace inventory_control.Data
{
    internal static class SeederOrder
    {
        internal static void Seed(ApplicationDbContext db)
        {
            UserManager<ApplicationUser> userManager =
                new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            RoleManager<Role> roleManager =
                new RoleManager<Role>(new RoleStore<Role>(db));

            ApplicationUser user1 = userManager.FindByEmail("admin@email.com");
            ApplicationUser user2 = userManager.FindByEmail("user2@email.com");
            ApplicationUser user3 = userManager.FindByEmail("user1@email.com");

            db.Orders.RemoveRange(db.Orders.ToList());
            db.SaveChanges();

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 1,
                UserId = user1.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 100,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 100,
                AdminConfirmDeleted = false,
                CompleteTimestamp = null,
                IsComplete = false,
                IsApproved = false,
                IsDenied = false,
                DeniedReason = null,
                IsQtyModified = false,
                UserDeleted = false,
                
            });

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 2,
                UserId = user2.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 400,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 400,
                AdminConfirmDeleted = false,
                CompleteTimestamp = DateTime.Now,
                IsComplete = true,
                IsApproved = true,
                IsDenied = false,
                DeniedReason = null,
                IsQtyModified = false,
                UserDeleted = false,

            });

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 3,
                UserId = user3.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 200,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 200,
                AdminConfirmDeleted = false,
                CompleteTimestamp = null,
                IsComplete = false,
                IsApproved = false,
                IsDenied = false,
                DeniedReason = null,
                IsQtyModified = false,
                UserDeleted = true,

            });

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 4,
                UserId = user1.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 900,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 900,
                AdminConfirmDeleted = true,
                CompleteTimestamp = DateTime.Now,
                IsComplete = false,
                IsApproved = false,
                IsDenied = false,
                DeniedReason = null,
                IsQtyModified = false,
                UserDeleted = true,

            });

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 5,
                UserId = user2.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 300,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 300,
                AdminConfirmDeleted = false,
                CompleteTimestamp = DateTime.Now,
                IsComplete = true,
                IsApproved = false,
                IsDenied = true,
                DeniedReason = "Example of reason denied",
                IsQtyModified = false,
                UserDeleted = false,

            });

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 6,
                UserId = user3.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 400,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 600,
                AdminConfirmDeleted = false,
                CompleteTimestamp = null,
                IsComplete = false,
                IsApproved = false,
                IsDenied = false,
                DeniedReason = null,
                IsQtyModified = true,
                UserDeleted = false,

            });

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 7,
                UserId = user1.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 100,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 100,
                AdminConfirmDeleted = false,
                CompleteTimestamp = null,
                IsComplete = false,
                IsApproved = false,
                IsDenied = false,
                DeniedReason = null,
                IsQtyModified = false,
                UserDeleted = false,

            });

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 8,
                UserId = user2.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 50,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 50,
                AdminConfirmDeleted = false,
                CompleteTimestamp = null,
                IsComplete = false,
                IsApproved = false,
                IsDenied = false,
                DeniedReason = null,
                IsQtyModified = false,
                UserDeleted = false,

            });

            db.Orders.AddOrUpdate(o => o.ItemId, new Order
            {
                ItemId = 9,
                UserId = user3.Id,
                DepartmentId = user1.DepartmentId,
                OrderQuantity = 1234,
                BeginTimestamp = DateTime.Now,
                OriginalQty = 1234,
                AdminConfirmDeleted = false,
                CompleteTimestamp = null,
                IsComplete = false,
                IsApproved = false,
                IsDenied = false,
                DeniedReason = null,
                IsQtyModified = false,
                UserDeleted = false,

            });
            db.SaveChanges();

        }

    }
}
