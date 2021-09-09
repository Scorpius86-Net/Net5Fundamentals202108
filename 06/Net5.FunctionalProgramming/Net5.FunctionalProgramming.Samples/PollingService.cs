using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.FunctionalProgramming.Samples
{
    public sealed class ErrorResponse
    {
        public List<ErrorInfo> rows {get; set;}
        public string Token { get; set; }

        public int Multiply(int a, int b)
        {
            return a*b;
        }
    }

    public sealed class ErrorInfo
    {
        public string Date { get; set; }
        public string ErrorType { get; set; }
        public string ErrorCode { get; set; }
        public string TankSerial { get; set; }
        public int ErroId { get; set; }
    }

    public class child
    {
        public static void getChid()
        {
            ErrorResponse errorResponse = new ErrorResponse();
        }
    }
}
