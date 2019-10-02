    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{ Name="Customer1" },
                new Customer{ Name="Customer2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
        

            return View(viewModel);
        }
        // return Content("Hello World");
        // return HttpNotFound();
        // return new EmptyResult();

    }

       
        //public ActionResult Edit(int id)
        //{
        //    return Content("Id="+id);
        //}

        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year+"/"+month);
        //    //return Content("Year is "+year);
        //}


    
}