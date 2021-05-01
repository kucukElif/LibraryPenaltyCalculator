using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryPenalty.DAL.Entity.Base
{
    public interface IEntity<T>
    {
        T ID { get; set; }
    }
}
