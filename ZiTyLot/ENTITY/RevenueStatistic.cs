using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiTyLot.ENTITY
{
    public class RevenueStatistic
    {
        public string Period { get; set; }
        public decimal TotalAmount { get; set; }

        public RevenueStatistic(string period, decimal totalAmount)
        {
            Period = period;
            TotalAmount = totalAmount;
        }
    }
}
