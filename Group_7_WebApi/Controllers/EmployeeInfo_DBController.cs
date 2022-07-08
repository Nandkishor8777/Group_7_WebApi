using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_7_WebApi.Repository;
using Group_7_WebApi.Model;
using AutoMapper;

namespace Group_7_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInfo_DBController : ControllerBase
    {
        private readonly IEmployee_Repo employee_Repo;
        private readonly IMapper mapper;

        public EmployeeInfo_DBController(IEmployee_Repo employee_Repo, IMapper mapper)
        {
            this.employee_Repo = employee_Repo;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<EmployeeInfo>> ShowAll()
        {
            var ar = employee_Repo.ShowAll();
            var data = mapper.Map<List<EmployeeInfo>>(ar);
            return data;
        }
        [HttpPost]
        public int insert(EmployeeInfo employeeModelDB)
        {
            var w = mapper.Map<EmployeeInfo_DB>(employeeModelDB);
            int data = employee_Repo.Insert(w);
            return 1;
        }
        [HttpDelete]
        public int delete(int? id)
        {

            var ar = employee_Repo.Delete(id);

            return 1;
        }
        [HttpPut]
        public int Update(int? id, EmployeeInfo empModel)
        {

            var ar = employee_Repo.Update(id, empModel);

            return 1;
        }
    }
}
