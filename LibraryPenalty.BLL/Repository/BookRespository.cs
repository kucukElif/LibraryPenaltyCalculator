using LibraryPenalty.BLL.Abstract;
using LibraryPenalty.DAL.Context;
using LibraryPenalty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryPenalty.BLL.Repository
{
    public class BookRespository : IBookService
    {
        private readonly AppDbContext context;

        public BookRespository(AppDbContext context)
        {
            this.context = context;
        }
        public void Add(Book entity)
        {
            context.Books.Add(entity);
            context.SaveChanges();
        }

        public List<Book> GetActive()
        {
            return context.Books.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();
        }

        public Book GetById(Guid id)
        {
            return context.Books.FirstOrDefault(x => x.ID == id);
        }
    }
}
