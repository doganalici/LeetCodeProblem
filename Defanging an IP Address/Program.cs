using System.Net;

namespace Defanging_an_IP_Address
{
    internal class Program
    {
        static void Main(string[] args)
        {

           string address = "255.100.50.0";
           string result = DefangIPaddr(address);
           Console.WriteLine(result);

            string DefangIPaddr(string address)
            {
                
                string result = address.Replace(".", "[.]");
                return result;
            }
        }
    }
}
