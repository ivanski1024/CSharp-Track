using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractDataFromURL
{
    class ExtractDataFromURL
    {
        static void Main()
        {
            Console.WriteLine("Enter URL: ");
            string url = Console.ReadLine();
            string protocol, server, resource;
            int index = url.IndexOf("://");
            protocol = url.Substring(0, index);
            url=url.Remove(0, index + 3);
            index = url.IndexOf('/');
            if (index > 0)
            {
                server = url.Substring(0, index);
                url = url.Remove(0, index);
                resource = url;
            }
            else
            {
                server = url;
                resource = null;
            }
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);

        }
    }
}
