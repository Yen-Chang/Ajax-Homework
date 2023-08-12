using Microsoft.AspNetCore.Mvc;
using prjAjaxHomework.Models;

namespace prjAjaxHomework.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _context;
        private readonly IWebHostEnvironment _host;

        public ApiController(DemoContext context, IWebHostEnvironment host)
        {
            _context = context;
            _host = host;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cities()
        {
            var cities = _context.Address.Select(c => c.City).Distinct();

            return Json(cities);
        }

        public IActionResult Districts(string city)
        {
            var districts = _context.Address.Where(x => x.City == city).Select(x => x.SiteId).Distinct();
            return Json(districts);
        }

        public IActionResult Roads(string districts)
        {
            var roads = _context.Address.Where(o => o.SiteId == districts).Select(x => x.Road).Distinct();
            return Json(roads);
        }

        public IActionResult CheckAcount(string name)
        {
            var confirm = _context.Members.FirstOrDefault(x => x.Name == name);
            return Json(confirm);
        }

    }
}
