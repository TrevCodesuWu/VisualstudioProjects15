using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using JobApplicationForm.Models;
using JobApplicationForm.DTOs; 

namespace JobApplicationForm.App_Start
{
    public class mappingProfile : Profile
    {
        public mappingProfile()
        {
            Mapper.CreateMap<JobForm, JobFormDTO>();
            Mapper.CreateMap<JobFormDTO, JobForm>();
            Mapper.CreateMap<Position, PositionDto>(); 

        }
    }
}