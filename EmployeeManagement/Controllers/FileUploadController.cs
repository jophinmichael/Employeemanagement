using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Web;
using System.IO;

namespace EmployeeManagement.Controllers
{
    public class DocFileController : ControllerBase
    {
        public HttpResponseMessage Post()
        {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Request;
            if (httpRequest.Form.Files.Count > 0)
            {
                var docfiles = new List<string>();
                foreach (IFormFile file in httpRequest.Form.Files)
                {
                    
                }
                result = new HttpResponseMessage(HttpStatusCode.OK);
            }
            return result;
        }
    }
}


