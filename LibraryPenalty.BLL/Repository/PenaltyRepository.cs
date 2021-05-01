using LibraryPenalty.BLL.Abstract;
using LibraryPenalty.DAL.Context;
using LibraryPenalty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LibraryPenalty.BLL.Repository
{
   public  class PenaltyRepository : IPenaltyService
    {
        private readonly AppDbContext context;

        public PenaltyRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Penalty entity)
        {
            context.Penalties.Add(entity);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<Penalty, bool>> exp)
        {
           return context.Penalties.Any(exp);
        }

        public List<Penalty> GetActive()
        {
            return context.Penalties.Where(x => x.Status == DAL.Entity.Enum.Status.Active).ToList();

        }

        public Penalty GetById(Guid id)
        {
            return context.Penalties.FirstOrDefault(x => x.ID == id);
        }

        public void Remove(Guid id)
        {
            Penalty penalty = GetById(id);
            penalty.Status = DAL.Entity.Enum.Status.Deleted;
            Update(penalty);
        }

       

        public void Update(Penalty entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
