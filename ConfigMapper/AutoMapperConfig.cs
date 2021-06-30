using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TF_FinanzasBackEnd.Dto;
using TF_FinanzasBackEnd.Model;
using TF_FinanzasBackEnd.Model.Identity;

namespace TF_FinanzasBackEnd.ConfigMapper
{
    public class AutoMapperConfig:Profile
    {

        public AutoMapperConfig()
        {

            CreateMap<Descuento, DescuentoCreateDto>();
            CreateMap<Descuento, DescuentoDto>();
            CreateMap<Girador, GiradorDto>();
            CreateMap<Girador, GiradorCreateDto>();
            CreateMap<Letra, LetraDto>();
            CreateMap<Usuario, UsuarioCreateDto>();
            CreateMap<Usuario, UsuarioDto>();
            //
            CreateMap<ApplicationUser, AplicationUserDto>();
        }
    }
}
