namespace ExtendingEpiserverEdit.Controllers
{
    using System.Web.Mvc;

    [Authorize(Roles = "Administrators, WebAdmins, WebEditors")]
    public class ProfileAdminController : Controller
    {
        // GET: ProfileAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profiles()
        {
            return View();
        }
    }
}