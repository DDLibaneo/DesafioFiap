using AutoMapper;
using DesafioFiap.Dtos;
using DesafioFiap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesafioFiap.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to DtoOut
            Mapper.CreateMap<UsuarioNewsletter, UsuarioNewsletterDtoOut>();

            // DtoIn to Domain
            Mapper.CreateMap<UsuarioNewsletterDtoIn, UsuarioNewsletter>();
        }

    }
}