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
            // AQUÍ EL CÓDIGO DE VALIDACIÓN DEL USUARIO
            return RedirectToAction("LoginOk");
        }
        else
        {
            return View(loginDataModel);
        }
    }

    public ActionResult LoginOK()
    {
        // LA VALIDACIÓN DEL USUARIO HA SIDO CORRECTA
        return View();
    }

      ...

    }