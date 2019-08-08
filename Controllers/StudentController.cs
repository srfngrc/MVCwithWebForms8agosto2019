using MVCwithWebForms8agosto2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCwithWebForms8agosto2019.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentModel myStudent = new StudentModel();
            myStudent.firstName = "Serafin";
            myStudent.lastName = "Garcia";
            myStudent.studentId = "IE8438490303";
            return View(myStudent);
        }
    }
}