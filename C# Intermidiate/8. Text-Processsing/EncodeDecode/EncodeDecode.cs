using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeDecode
{
    class EncodeDecode
    {

        static void Main()
        {
            string key;
            using (StreamReader keyStream = new StreamReader("../../key.txt"))
            {
                key = keyStream.ReadToEnd();
            }
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine(EncodeOrDecode(text, key));
            Console.WriteLine(EncodeOrDecode(EncodeOrDecode(text, key),key));

        }

        static string EncodeOrDecode(string text, string key)
        {
            StringBuilder EncodedDecoded = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                EncodedDecoded.Append(((int)text[i] ^ key[i % key.Length]).ToString());
            }
            return EncodedDecoded.ToString();
        }

    }
}
