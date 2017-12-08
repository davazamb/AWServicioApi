using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WcfService.Models;

namespace AWServicioApi.APP.Controllers
{
    public class EmpleadosController : ApiController
    {
        public IEnumerable<Employees> Get()
        {
            using (EmployeeDBEntities2 entities = new EmployeeDBEntities2())
            {
                return entities.Employees.ToList();
            }
        }
        public Employees Get(int id)
        {
            using (EmployeeDBEntities2 entities = new EmployeeDBEntities2())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
