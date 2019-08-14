﻿using MVCwithWebForms8agosto2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//THIS IS THE CONTROLLER, THAT I CREATED 2ND, WITH THE FIRST PART OF THE NAME = THE MODEL ALREADY CREATED

namespace MVCwithWebForms8agosto2019.Controllers
{
    public class UserDemographicsController : Controller
    {
        // GET: UserDemographics
        public ActionResult Index()
        {
            using (RentMyWroxContext context = new RentMyWroxContext())
            {
                var list = context.UserDemographics.OrderBy(x => x.Birthdate).ToList();
                return View(list);
            }
        }

        // GET: UserDemographics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserDemographics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserDemographics/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDemographics/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new UserDemographics();
            return View("Manage", model);
        }

        // POST: UserDemographics/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDemographics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserDemographics/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
