using LibraryPenalty.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryPenalty.UI.Models
{
    public class BookVM
    {
        public Book Book { get; set; }

        public List<Penalty> Penalties { get; set; }

    }
}
