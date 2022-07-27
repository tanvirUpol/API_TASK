using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/user/")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var data = UserServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = UserServices.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/user/{id}/news")]
        [HttpGet]
        public HttpResponseMessage GetStudents(int id)
        {
            var data = UserServices.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
