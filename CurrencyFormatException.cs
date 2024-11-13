using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp_BSCS301
{
    internal class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string str) : base(str)
        {

        }
    }
}
