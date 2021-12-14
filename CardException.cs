using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLoL
{
    class CardException : Exception
    {
        public CardException(string message) : base(message)
        {
        }
    }
}
