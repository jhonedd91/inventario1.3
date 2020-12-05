public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(LoginViewModel loginDataModel)
    {
        if (ModelState.IsValid)
        {
            // AQU� EL C�DIGO DE VALIDACI�N DEL USUARIO
            return RedirectToAction("LoginOk");
        }
        else
        {
            return View(loginDataModel);
        }
    }

    public ActionResult LoginOK()
    {
        // LA VALIDACI�N DEL USUARIO HA SIDO CORRECTA
        return View();
    }

      ...

    }