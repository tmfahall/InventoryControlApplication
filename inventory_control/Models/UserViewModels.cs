using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventory_control.Models
{
    public class UserVM
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Email { get; set; }    }
    public class UsersVM
    {
        public List<UserVM> Users { get; set; }
        public DepartmentsVM Departments { get; set; }
    }
}