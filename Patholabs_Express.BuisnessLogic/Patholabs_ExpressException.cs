using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patholabs_Express.BuisnessLogic
{
    public class Patholabs_ExpressException: Exception
    {
        public Patholabs_ExpressException(): base() { }
        public Patholabs_ExpressException(string message): base(message) { }
        public Patholabs_ExpressException(string message, Exception innerException) : base(message, innerException) { }
    }
}
