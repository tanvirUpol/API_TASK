using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.BOs;
using BLL.Services;

namespace PresentationLayer.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/news")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = NewsService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/news/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = NewsService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/news/update")]
        [HttpPost]
        public HttpResponseMessage Update(NewsModel n)
        {
            var data = NewsService.Update(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/news/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = NewsService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/news/create")]
        [HttpPost]
        public HttpResponseMessage Create(NewsModel n)
        {
            var data = NewsService.Create(n);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
