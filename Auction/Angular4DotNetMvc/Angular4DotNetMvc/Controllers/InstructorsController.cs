namespace Angular4DotNetMvc.Controllers
{
    using Angular4DotNetMvc.Models.Instructors;
    using Angular4DotNetMvc.Models.Registration;
    using System.Threading;
    using System.Web.Http;
    using System.Web.Mvc;

    public class InstructorsController : ApiController // JsonController //Controller
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public InstructorVm[] Get()
        {
            //return View("Index", "", _registrationVmBuilder.GetSerializedInstructors());
            //return Json(_registrationVmBuilder.GetInstructors(), JsonRequestBehavior.AllowGet);
            return _registrationVmBuilder.GetInstructors();
        }
    }
}
