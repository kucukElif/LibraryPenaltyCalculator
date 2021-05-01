using LibraryPenalty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryPenalty.BLL.Abstract
{
  public  interface IBookService
    {
        List<Book> GetActive();
        Book GetById(Guid id);

        void Add(Book entity);
    }
}
