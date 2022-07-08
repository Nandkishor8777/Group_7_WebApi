using Group_7_WebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group_7_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpInfoController : ControllerBase
    {
        static List<Employee> lstemp = new List<Employee>()
        {
            new Employee{Id=1,EmpName="Ajay",Salary=11111},
             new Employee{Id=2,EmpName="jay",Salary=22222},
              new Employee{Id=3,EmpName="Vijay",Salary=33333},
               new Employee{Id=4,EmpName="Sujay",Salary=44444}
        };
        [HttpGet("Showall")]
        public ActionResult<List<Employee>> GetAllEmp()
        {
            return lstemp;
        }
        [HttpGet("search/{id?}")]
        //http://localhost:30063/api/EmpInfo/search/2
        public ActionResult<Employee> Search(int? id)

        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            return ar;
        }
        [HttpPost]
        public ActionResult<List<Employee>> Insert(Employee employee)
        {
            lstemp.Add(employee);
            return lstemp;
        }
        [HttpDelete]
        public int Delete(int id)
        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            if(ar != null)
            {
                lstemp.Remove(ar);
            }
            return 1;
        }
        [HttpPut]
        public ActionResult<List<Employee>> Update(int id, Employee model)
        {
            var ar = lstemp.FirstOrDefault(x => x.Id == id);
            if (ar != null)
            {
                ar.EmpName = model.EmpName;
                ar.Salary = model.Salary;

            }
            return lstemp;
        }


    }
}
