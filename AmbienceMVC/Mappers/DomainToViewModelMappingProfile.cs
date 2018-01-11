using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModel;

namespace AmbienceMVC.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            //Mapper.CreateMap<Cliente, ClienteViewModel>();
        }
    }
}