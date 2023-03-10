using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoMVC2.Controllers
{
    public class EducationController : Controller
    {
        // GET: EducationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EducationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EducationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EducationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: EducationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EducationController/Edit/5
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

        // GET: EducationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EducationController/Delete/5
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
