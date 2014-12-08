using inventory_control.Adapters;
using inventory_control.Adapters.Data;
using inventory_control.Controllers;
using inventory_control.Data;
using inventory_control.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace inventory_control.app.controllers
{
    [RoutePrefix("user")]
    public class UserController : ApiController
    {
        private IUserAdapter _adapter;

        public UserController()
        {
            _adapter = new UserDataAdapter();
        }

        //GET: user/all
        [Route("all")]
        public IHttpActionResult GetUsers()
        {

            UsersVM model = _adapter.GetUsers();

            return Ok(model);
        }

        //GET: user/{id}
        [Route("{id}")]
        public IHttpActionResult GetUser(string id)
        {

            UsersVM model = _adapter.GetUser(id);

            return Ok(model);
        }

        //GET: user/departments
        [Route("departments")]
        public IHttpActionResult GetDepartments()
        {

            DepartmentsVM model = _adapter.GetDepartments();

            return Ok(model);
        }
        
        //POST: user/update
        [Route("update")]
        public IHttpActionResult SaveUser(UserVM model)
        {
            var pass = KeyGenerator.GetUniqueKey(12);
            UsersVM users = _adapter.SaveUser(model, pass);
           

            Seeder.Seed();


            MailModel mail = new MailModel();
            mail.From = "Admin@inventorycontrol.tk";
            mail.To = model.Email;
            mail.Subject = "Access to inventory orders for " + model.FirstName + " " + model.LastName + ".";
            mail.Body = "Welcome " + model.FirstName + ".  You have been given access to the inventory order system for the " + model.DepartmentName + " department.  Your temporary password is " + pass;

            Email.Send(mail);

            

            return Ok(users);
        }
    }
}

