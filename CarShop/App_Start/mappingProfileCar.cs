using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using CarShop.DTOs;
using CarShop.Models; 
namespace CarShop.App_Start
{
    public class mappingProfileCar : Profile
    {
        public mappingProfileCar()
        {
            Mapper.CreateMap<Car, CarDTO>();
            Mapper.CreateMap<Class, ClassDto>();


            Mapper.CreateMap<CarDTO, Car>();
        }
    }
}