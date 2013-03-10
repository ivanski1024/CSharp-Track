using System;
using System.Linq;
using System.IO;

namespace ReadFile
{
    class ReadFile
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter full file path: ");
                    string filePath = Console.ReadLine();
                    string file = File.ReadAllText(filePath);
                    string seperator = new String('-', Console.WindowWidth);
                    Console.WriteLine("{0}:\n{1}\n{2}\n{1}", filePath, seperator, file);

                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("This is not a file!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The path file you entered is invalid!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("The path file you entered is invalid!");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Such file doesn't exist!");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Such directory doesn't exist!");
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("The path is too long! 248 characters is the maximum!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception cought!\n{0}:{1}", e.GetType().Name, e.Message);
                }
            }
        }
    }
}