using System;
using System.Collections.Generic;
using FormSubmission.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormSubmission.Controllers {
    public class HomeController : Controller
    {
       
        [HttpGet ("")] 
        public IActionResult Index () 
        {
            return View ();
        }

        [HttpPost ("result")] 
        public IActionResult Create (User student) {
            if (ModelState.IsValid) {
                ViewBag.FirstName = student.FirstName;
                ViewBag.LastName = student.LastName;
                ViewBag.Age = student.Age;
                ViewBag.Email = student.Email;
               
                return View("Result");
            } else {

                return View("Index");
            }
        }
    }
}