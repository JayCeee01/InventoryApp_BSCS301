using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp_BSCS301
{
    internal class StringFormatException : Exception
    {
        public StringFormatException(string str) : base(str)
        {
        }
    }
}

