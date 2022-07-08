using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_7_WebApi.Model;

namespace Group_7_WebApi.Helper
{
    public class ApplicationHelper : Profile
    {
        public ApplicationHelper()
        {
            CreateMap<EmployeeInfo, EmployeeInfo_DB>().ReverseMap();
        }
    }
}
