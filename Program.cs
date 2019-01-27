using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MacAddressFinder
{
    class Program
    {
        static string GetMACAddress()
        {
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            string text = string.Empty;
            foreach (NetworkInterface networkInterface in allNetworkInterfaces)
            {
                if (text == string.Empty)
                {
                    networkInterface.GetIPProperties();
                    text = networkInterface.GetPhysicalAddress().ToString();
                }
            }
            return text;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Mac Address: " + GetMACAddress());
            Console.ReadKey();
        }
    }
}
