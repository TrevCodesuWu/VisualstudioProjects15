using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Migrations_EF.Models;
using Migrations_EF.DTOs; 
namespace Migrations_EF.App_Start
{
    public class mappingProfilem : Profile
    {
        public mappingProfilem()
        {
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MovieDTO, Movie>(); 

        }
    }
}