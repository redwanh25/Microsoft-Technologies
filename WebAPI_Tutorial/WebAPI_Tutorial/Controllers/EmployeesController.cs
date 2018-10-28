using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebAPI_Tutorial.Controllers
{
    public class EmployeesController : ApiController
    {
        // ai ta disi karon amra Get() function k call na kore Emp likhsi. but, code to r Emp() k chine na. tai.
        // code chine Get(), GetSomething() k. emon [HttpPut], [HttpPost], [HttpDelete] ase
        //[HttpGet]
        //public IEnumerable<Employee> amrShonarBangla()
        //{
        //    using (WebAPI_Tutorial_DatabaseEntities entities = new WebAPI_Tutorial_DatabaseEntities())
        //    {
        //        return entities.Employees.ToList();
        //    }
        //}

        public HttpResponseMessage Get(string gender = "all")
        {
            using (WebAPI_Tutorial_DatabaseEntities entities = new WebAPI_Tutorial_DatabaseEntities())
            {
                if (gender.ToLower().Equals("all"))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.ToList());
                }
                else if (gender.ToLower().Equals("male"))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where(e => e.Gender.ToLower() == gender).ToList());
                }
                else if (gender.ToLower().Equals("female"))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entities.Employees.Where(e => e.Gender.ToLower() == gender).ToList());
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, gender + " not found");
                }

            }
        }

        //public Employee Get(int id)
        //{
        //    using (WebAPI_Tutorial_DatabaseEntities entities = new WebAPI_Tutorial_DatabaseEntities())
        //    {
        //        //return entities.Employees.Find(id);
        //        return entities.Employees.FirstOrDefault(e => e.ID == id);
        //    }
        //}

        public HttpResponseMessage Get(int id)
        {
            using (WebAPI_Tutorial_DatabaseEntities entities = new WebAPI_Tutorial_DatabaseEntities())
            {
                //return entities.Employees.Find(id);
                var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee ID " + id + " not found");
                }
            }
        }

        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            try
            {
                using(WebAPI_Tutorial_DatabaseEntities entities = new WebAPI_Tutorial_DatabaseEntities())
                {
                    entities.Employees.Add(employee);
                    entities.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.Created, employee);

                    //var message = Request.CreateResponse(HttpStatusCode.Created, employee);

                //-- nicher ai ta likhle path shoho fixed hoye jabe.. tutorial-7 (09:20)

                    //message.Headers.Location = new Uri(Request.RequestUri + "/" + employee.ID.ToString());
                    //return message;

                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (WebAPI_Tutorial_DatabaseEntities entities = new WebAPI_Tutorial_DatabaseEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, id + " not found");
                    }
                    else
                    {
                        entities.Employees.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }
        public HttpResponseMessage Put([FromBody]int id, [FromUri] Employee employee)
        {
            try
            {
                using (WebAPI_Tutorial_DatabaseEntities entities = new WebAPI_Tutorial_DatabaseEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                    if(entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, id + " not found");
                    }
                    else
                    {
                        entity.First_Name = employee.First_Name;
                        entity.Last_Name = employee.Last_Name;
                        entity.Gender = employee.Gender;
                        entity.Salary = employee.Salary;

                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
