﻿using AutoMapper;
using VidlyProject.Dtos;
using VidlyProject.Models;

namespace VidlyProject.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /*Domain to DTO*/
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();


            /*DTO to Domain*/
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}