﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AWServicioApi.AD;

namespace AWServicioApi.APP.Controllers
{
    public class EmpleadosController : ApiController
    {
        public IEnumerable<Employees> Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
        public Employees Get(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
