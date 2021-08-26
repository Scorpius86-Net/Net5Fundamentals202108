using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypeAndOperators
{
    enum Season
    {
        Spring,
        Summer,
        Autum,
        Winter
    }

    enum ErrorCode : ushort
    {
        None = 0,
        unknown = 1,
        ConnectionLost = 100,
        OutLierReading = 200
    }
}
