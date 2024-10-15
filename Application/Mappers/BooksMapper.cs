using Application.Model;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class BooksMapper : Profile
    {
        public BooksMapper()
        {
            CreateMap<Book, BookModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BookId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.BookTitle));
        }
    }
}
