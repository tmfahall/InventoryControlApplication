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
    public static class Seeder
    {

        public static void Seed()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            SeederDepartments.Seed(db);

            SeederUsers.Seed(db);

            SeederLocations.Seed(db);

            SeederSupplier.Seed(db);

            SeederSupplierPart.Seed(db);

            SeederItem.Seed(db);

            SeederItemLocation.Seed(db);

            SeederOrder.Seed(db);
        }   
    }
}
