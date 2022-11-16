using AutoMapper;
using Domain.Entities;
using Service.DTOs.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mappings
{
    public class MappingBook : Profile
    {
        public MappingBook()
        {
            CreateMap<BookCreateDTO, Book>();
        }
    }
}
