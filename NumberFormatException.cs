using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp_BSCS301
{
    internal class NumberFormatException : Exception
    {
        public NumberFormatException(string str) : base(str) { 
        }
    }
}
