using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Book
{
    public class BookCreateDTO
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public int Page { get; set; }
    }
}
