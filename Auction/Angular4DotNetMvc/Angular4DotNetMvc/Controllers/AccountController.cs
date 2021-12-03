namespace Angular4DotNetMvc.Controllers
{
    using Angular4DotNetMvc.Models.Students;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Mvc;

    public class AccountController : ApiController
    {
        //[HttpPost]
        //public ActionResult Save(StudentVm student)
        //{
        //        _studentRegistrationService.Register(student);
        //        return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
        //}

        //public HttpResponseMessage Post(StudentVm student)
        //{
        //    //_studentRegistrationService.Register(student);
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}

        public HttpResponseMessage Post(HttpRequestMessage request, StudentVm student)
        {
            if (ModelState.IsValid)
            {
                //_studentRegistrationService.Register(student);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }

            return request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessage());
        }

        private IEnumerable<string> GetErrorMessage()
        {
            return ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage));
        }
    }
}
