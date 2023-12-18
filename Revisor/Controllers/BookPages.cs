using Microsoft.AspNetCore.Mvc;

namespace Revisor.Controllers
{
    public class BookPages : Controller
    {
        public ActionResult Homepage()
        {
            return View();
        }

        public ActionResult MyBooks()
        {
            return View();
        }

        public ActionResult BookPage()
        {
            return View();
        }

        public ActionResult AddBook()
        {
            return View();
        }
    }
}
