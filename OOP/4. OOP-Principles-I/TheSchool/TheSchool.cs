using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSchool
{
    class TheSchool
    {
        static void Main(string[] args)
        {
            List<Discipline> disciplines = new List<Discipline>();
            disciplines.Add(new Discipline("HTML", 1, 1));
            Teacher nakov = new Teacher("Svetlin", "Nakov", disciplines);
            Console.WriteLine(nakov.Disciplines.Count);


            nakov.Disciplines.Add(new Discipline("OOP", 1, 1));
            Console.WriteLine(nakov.Disciplines.Count);
            Console.WriteLine(nakov.LastName);
        }
    }
}
