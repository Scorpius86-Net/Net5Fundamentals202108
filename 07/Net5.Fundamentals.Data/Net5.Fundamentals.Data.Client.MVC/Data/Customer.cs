using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5.Fundamentals.Data.Client.MVC.Data
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string DistrictCode { get; set; }
        public string Sex { get; set; }
        public string DNI { get; set; }
        public string RUC { get; set; }
        public int Telephone { get; set; }
        public int Mobile { get; set; }
    }
}
