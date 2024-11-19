using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiTyLot.DTOS
{
    public class RevenueStatistic
    {
        public string Period { get; set; }
        public decimal ResidentAmount { get; set; }
        public decimal VisitorAmount { get; set; }
        public decimal totalAmount => ResidentAmount + VisitorAmount;
    }
}
