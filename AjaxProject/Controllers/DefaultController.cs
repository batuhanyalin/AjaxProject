using AjaxProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AjaxProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            var values = _context.Products.ToList();
            var jsonValues= JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
    }
}
