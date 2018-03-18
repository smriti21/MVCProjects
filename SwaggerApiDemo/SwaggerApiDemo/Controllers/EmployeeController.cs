using SwaggerApiDemo.Models;
using SwaggerApiDemo.Services;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerApiDemo.Controllers
{
    [RoutePrefix("employee")]
    public class EmployeeController : ApiController
    {
        private readonly EmployeeManager employeeManager;

        public EmployeeController()
        {
            employeeManager = new EmployeeManager();
        }

        /// <summary>
        /// Method to get all employees
        /// </summary>
        /// <returns></returns>
        [Route("getall")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type = typeof(HttpResponseException))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(List<Employee>))]
        public HttpResponseMessage GetAllEmployees()
        {
            var employees = employeeManager.GetAllEmployees();
            return Request.CreateResponse(HttpStatusCode.OK,
                 employees);
        }
    }
}
