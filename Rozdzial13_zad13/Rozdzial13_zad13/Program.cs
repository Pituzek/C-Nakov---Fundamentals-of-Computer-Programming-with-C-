using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Rozdzial13_zad13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("13. Write a program that parses an URL in following format:");
            //  [protocol]://[server]/[resource]

            //It should extract from the URL the protocol, server and resource parts.
            //For example, when http://www.cnn.com/video is passed, the result is:
            //[protocol]= "http"
            //[server] = "www.cnn.com"
            //[resource] = "/video"

            Console.WriteLine("Wpisz adres www");
            string address = Console.ReadLine();

            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-extract-a-protocol-and-port-number-from-a-url
            
            Regex r = new Regex(@"^(?<protocol>\w+)://(?<server>[a-z0-9\.:]+)(?<resource>[a-z0-9\/.:-]+)");

            Match m = r.Match(address);
            if (m.Success)
                Console.WriteLine(m.Result("\n[protocol]= \"${protocol}\" \n[server] = \"${server}\" \n[resource] = \"${resource}\" "));

            Console.ReadKey();
        }
    }
}
