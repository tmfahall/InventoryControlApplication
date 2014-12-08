using inventory_control.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_control.Data
{
    internal static class SeederDepartments
    {
        internal static void Seed(ApplicationDbContext db)
        {
            Department dept1 = db.Departments.FirstOrDefault(d => d.DepartmentName == "Admin");
            if (dept1 == null)
            {
                db.Departments.Add(new Department { DepartmentName = "Admin" });
            }

            Department dept2 = db.Departments.FirstOrDefault(d => d.DepartmentName == "Pre-Assembly Staging");
            if (dept2 == null)
            {
                db.Departments.Add(new Department { DepartmentName = "Pre-Assembly Staging" });
            }

            Department dept3 = db.Departments.FirstOrDefault(d => d.DepartmentName == "Assembly Phase 1");
            if (dept3 == null)
            {
                db.Departments.Add(new Department { DepartmentName = "Assembly Phase 1" });
            }

            Department dept4 = db.Departments.FirstOrDefault(d => d.DepartmentName == "Assembly Phase 2");
            if (dept4 == null)
            {
                db.Departments.Add(new Department { DepartmentName = "Assembly Phase 2" });
            }

            Department dept5 = db.Departments.FirstOrDefault(d => d.DepartmentName == "Paintshop");
            if (dept5 == null)
            {
                db.Departments.Add(new Department { DepartmentName = "Paintshop" });
            }

            db.SaveChanges();

            //throw new NotImplementedException();
        }
    }
}
