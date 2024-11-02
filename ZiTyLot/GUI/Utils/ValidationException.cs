using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZiTyLot.GUI.Utils
{
    public class ValidationException : BusinessException
    {
        public ValidationException(string message) : base(message) { }
    }
}
