using Application.ViewModels.ProductViewModels;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Mapper
{
    public class MapperConfigProfile : Profile
    {
        public MapperConfigProfile() 
        {
            CreateMap<CreateProductViewModel, Product>();
        }
    }
}
