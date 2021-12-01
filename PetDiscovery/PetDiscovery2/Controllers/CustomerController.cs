using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetDiscovery.Controller;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDiscovery2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LostPetView()
        {
            return View();
        }

        public ActionResult FoundedPetView()
        {
            return View();
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            var teste = new CustomerBaseController();

            try
            {
                teste.Insert(customer);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreateFoundedAnimal(Animals animals)
        {
            var teste = new CustomerBaseController();
            var loged = new LogedUser();
            try
            {
                teste.CreateAnimal(loged, animals);
                return RedirectToAction("Home", "Index");
            }
            catch
            {
                return View();
            }

        }

        [HttpPost]
        public ActionResult CreateLostAnimal(Animals animals)
        {
            var teste = new CustomerBaseController();
            var loged = new LogedUser();
            try
            {
                teste.CreateAnimal(loged, animals);
                return RedirectToAction("Home", "Index");
            }
            catch
            {
                return View();
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LostPetCallView(LogedUser loged)
        {
            return RedirectToAction("Customer","LostPetView", loged);
        }


        [HttpPost]
        public ActionResult CreateAnimal(Animals animals, LogedUser loged)
        {
            var teste = new CustomerBaseController();

            try
            {
                teste.CreateAnimal(loged, animals);
                return RedirectToAction("Home", "Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
