using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using RestuarantApplication.Models;
using RestuarantApplication.DTOs; 

namespace RestuarantApplication.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Food, FoodDto>();
            Mapper.CreateMap<FoodDto, Food>(); 
        }
    }
}