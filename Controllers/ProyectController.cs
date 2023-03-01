using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoMVC2.Controllers
{
    [Authorize]
    public class ProyectController : Controller
    {
        [AllowAnonymous]
        // GET: ProyectoController
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        // GET: ProyectoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProyectoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProyectoController/Create
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

        // GET: ProyectoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProyectoController/Edit/5
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

        // GET: ProyectoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProyectoController/Delete/5
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
