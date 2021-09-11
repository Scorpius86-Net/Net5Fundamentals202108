using System;
using System.Collections.Generic;

namespace Net5.Fundamentals.Data.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            List<Customer> customers = data.ListCustomers();
            System.Console.WriteLine("1234567890123|" +
                "12345678901234567890123|" +
                "12345678901234567890123|" +
                "1234567890123456789012|" +
                "123|" +
                "1234567890|" +
                "1234567890123|" +
                "12345678901|" +
                "1234567890|");
            System.Console.WriteLine("CustomerCode | CustomerName          | CustomerAddress       | DistrictCode         | S | DNI      | RUC         | Telehone  | Mobile   |");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
            customers.ForEach(customer =>
            {
                System.Console.WriteLine($"" +
                    $"{customer.CustomerCode.PadRight(12,' ')} | " +
                    $"{customer.CustomerName.PadRight(21, ' ')} | " +
                    $"{customer.CustomerAddress.PadRight(21, ' ')} | " +
                    $"{customer.DistrictCode.PadRight(20,' ')} | " +
                    $"{customer.Sex.PadRight(1, ' ')} | " +
                    $"{customer.DNI.PadRight(8, ' ')} | " +
                    $"{customer.RUC.PadRight(11, ' ')} | " +
                    $"{customer.Telephone.ToString().PadRight(9, ' ')} | " +
                    $"{customer.Mobile.ToString().PadRight(8, ' ')}");
            });            
        }
    }
}
