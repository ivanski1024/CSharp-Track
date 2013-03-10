using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter URL: ");
                string url = Console.ReadLine();
                Console.Write("Enter how file should be named: ");
                string fileName = Console.ReadLine();
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile(url, fileName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception cought!\n{0}:{1}", e.GetType().Name, e.Message);
            }
            finally 
            {
                Console.WriteLine("File successfully downloaded!");
            }

        }
    }
}
