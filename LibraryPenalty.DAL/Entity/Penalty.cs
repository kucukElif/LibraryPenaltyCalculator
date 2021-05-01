using Castle.MicroKernel.SubSystems.Conversion;
using LibraryPenalty.DAL.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryPenalty.DAL.Entity
{
   public class Penalty:CoreEntity
    {
        public DateTime NonPanelty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Country { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public decimal GetTotalPenalty() 
        {
            if (StartDate>EndDate)
            {
                throw new NotSupportedException("ERROR: [startDate] cannot be greater than [endDate].");

            }
            int cnt = 0;
            if (NonPanelty <= EndDate )
            {
                cnt = cnt * 0;
                cnt++;
            }
            for (var current = StartDate; current < EndDate; current = current.AddDays(1))
            {
                if (current.DayOfWeek == DayOfWeek.Saturday|| current.DayOfWeek == DayOfWeek.Sunday)
                {
                   cnt = cnt * 0;
                    cnt++;
                }

                else cnt++;
            }
            return Convert.ToDecimal(cnt*Price);
        }

       

    }
}
