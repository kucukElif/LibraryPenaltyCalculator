using LibraryPenalty.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryPenalty.DAL.Entity
{
   public class Book:CoreEntity
    {
        public string Name { get; set; }
        public virtual Penalty Penalty { get; set; }
    }
}
