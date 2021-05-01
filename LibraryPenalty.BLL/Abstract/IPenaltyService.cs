using LibraryPenalty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LibraryPenalty.BLL.Abstract
{
   public interface IPenaltyService
    {
        List<Penalty> GetActive();
        void Add(Penalty entity);
        void Update(Penalty entity);
        void Remove(Guid id);
        Penalty GetById(Guid id);
        bool Any(Expression<Func<Penalty, bool>> exp);
    }
}
