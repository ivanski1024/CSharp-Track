using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main()
        {
            using (StreamReader file = new StreamReader("../../file.txt"))
            {
                using (StreamWriter boof = new StreamWriter("../../boof.txt"))
                {
                    int i = 1;
                    for (string line=file.ReadLine(); line!=null; line=file.ReadLine())
                    {
                        if (i % 2 == 0)
                        {
                            boof.WriteLine(line);
                        }
                        i++;
                    }
                }
            }
            File.Delete("../../file.txt");
            File.Move("../../boof.txt", "../../file.txt");
        }
    }
}
