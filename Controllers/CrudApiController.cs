using RestApiCrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApiCrudProject.Controllers
{
    public class CrudApiController : ApiController
    {
        regformEntities db = new regformEntities();

        public IHttpActionResult GetStudent()
        {
            List<Task2> list = db.Task2.ToList();
            return Ok(list);
        }
        public IHttpActionResult GetStudentById(int id)
        {
            var emp = db.Task2.Where(Models => Models.Id == id).FirstOrDefault();
            return Ok(emp);
        }
    }
}
