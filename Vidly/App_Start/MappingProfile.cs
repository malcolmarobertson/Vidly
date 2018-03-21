using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.DTO;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
                
            CreateMap<CustomerDTO, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<MembershipType, MembershipTypeDTO>();
            CreateMap<Genre, GenreDTO>();

            CreateMap<Movie, MovieDTO>();
            CreateMap<MovieDTO, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());

        }
    }
}