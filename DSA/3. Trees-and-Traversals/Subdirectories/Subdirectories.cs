using System;
using System.Linq;
using System.IO;

namespace Subdirectories
{
    class Subdirectories
    {
        public const string folderPath = "C:\\WINDOWS";
        public const string mask = "*.exe";

        static void Main()
        {
            GetAllSubExeFiles(folderPath, mask);
        }

        public static void GetAllSubExeFiles(string folderPath, string mask)
        {
            string[] foundedFiles = Directory.GetFiles(folderPath, mask);
            foreach (var file in foundedFiles)
            {
                Console.WriteLine(file);
            }
            string[] subFolders = Directory.GetDirectories(folderPath);
            foreach (var folder in subFolders)
            {
                try
                {
                    GetAllSubExeFiles(folder, mask);
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
            }
        }
    }
}