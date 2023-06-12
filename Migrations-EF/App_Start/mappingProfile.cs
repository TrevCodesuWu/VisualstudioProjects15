using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Migrations_EF.Models;
using Migrations_EF.DTOs;

namespace Migrations_EF.App_Start
{
    public class mappingProfile : Profile
    {
        public mappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, Customer>(); 
        }
    }
}