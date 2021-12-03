namespace Angular4DotNetMvc.Controllers
{
    using System.Web.Mvc;
    using Angular4DotNetMvc.Models.Registration;

    public class RegistrationController : Controller
    {

        // continue to 
        // https://www.youtube.com/watch?v=9ajCSLBq8NQ

        //private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            //return View(_registrationVmBuilder.BuildRegistrationVm());
            return View();
        }

    }
}
