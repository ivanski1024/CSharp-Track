/*
 * 4. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
 * Override ToString() to display the information of a person and if age is not specified – to say so. Write a 
 * program to test this functionality.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformation
{
    class PersonInformation
    {
        static void Main()
        {
            Person pesho = new Person("Pesho");
            Person gosho = new Person("Gosho", 23);

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
