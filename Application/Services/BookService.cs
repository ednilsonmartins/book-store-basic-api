using Application.Interfaces;
using AutoMapper;
using Application.Model;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBooksRepository _booksRepository;
        private readonly IMapper _mapper;

        public BookService(IBooksRepository booksRepository, IMapper mapper)
        {
            _booksRepository = booksRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookModel>> GetBooksAsync()
        {
            var booksEntity = await _booksRepository.GetAllAsync();
            var booksModel = _mapper.Map<IEnumerable<BookModel>>(booksEntity);

            return booksModel;
        }
    }
}
