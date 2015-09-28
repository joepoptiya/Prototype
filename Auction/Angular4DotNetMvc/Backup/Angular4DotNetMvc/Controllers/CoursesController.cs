namespace Angular4DotNetMvc.Controllers
{
    using Angular4DotNetMvc.Models.Courses;
    using Angular4DotNetMvc.Models.Registration;
    using System.Web.Http;
    using System.Web.Mvc;

    public class CoursesController : ApiController // JsonController //Controller
    {
        private readonly RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public CourseVm[] Get()
        {
            //return View("Index", "", _registrationVmBuilder.GetSerializedCourses());
            //return Json(_registrationVmBuilder.GetCourses(), JsonRequestBehavior.AllowGet);
            return _registrationVmBuilder.GetCourses();
        }
    }
}
