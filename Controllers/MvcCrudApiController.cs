using RestApiCrudProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace RestApiCrudProject.Controllers
{
    public class MvcCrudApiController : Controller
    {
        HttpClient client = new HttpClient();
        // GET: MvcCrudApi
        public ActionResult Index()
        {
            List<Task2> stu=new List<Task2>();
            client.BaseAddress = new Uri("https://localhost:44389/api/CrudApi");
            var response = client.GetAsync("CrudApi");
            response.Wait();
            var test = response.Result;
            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Task2>>();
                display.Wait();
                stu = display.Result;
            }
            return View(stu);
        }
    }
}