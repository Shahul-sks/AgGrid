using AgGrid.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgGrid.Controllers
{
    public class DataController : Controller
    {
        private readonly ContextClass contextClass;

        public DataController(ContextClass _contextClass)
        {
            contextClass = _contextClass;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Aggrid()
        {
            return View();
        }
        public IActionResult Dynamic()
        {
            return View();
        }
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                contextClass.products.Add(product);
                contextClass.SaveChanges();
                return RedirectToAction("Dynamic", "Data");
            }
            return View();
        }
        [HttpPost]
        public IActionResult AddData(Product product) {
            if (ModelState.IsValid)
            {
                contextClass.products.Add(product);
                contextClass.SaveChanges();
                return RedirectToAction("Index", "Data");
            }
            return View();
        }
        public IActionResult ShowData()
        {
            var products = contextClass.products.ToList();
            return new JsonResult(products);
        }

        [HttpPost]
        public IActionResult UpdateData(Product prd)
        {
            contextClass.products.Update(prd);
            contextClass.SaveChanges();
            return Json (prd);
        }

        [HttpPost]
        public IActionResult deleteData(int id)
        {
            var e = contextClass.products.Find(id);
            if (e != null)
            {
                contextClass.products.Remove(e);
                contextClass.SaveChanges();
                return new JsonResult(new { success = true });
            }
            else
            {
                return new JsonResult(new { success = false });
            }
        }










    }
}
