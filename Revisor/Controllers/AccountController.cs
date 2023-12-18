using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    // GET: /Account/Login
    public ActionResult SignIn()
    {
        return View();
    }
    public ActionResult SignUp()
    {
        return View();
    }
    public ActionResult Profile()
    {
        return View();
    }
    public ActionResult Deletion()
    {
        return View();
    }
}
