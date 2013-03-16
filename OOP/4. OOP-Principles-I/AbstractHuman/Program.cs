using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AbstractHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> students = new List<Student>();
            students.Add(new Student("Svetlin", "Nakov", 5.90f));
            students.Add(new Student("Georgi", "Georgiev", 5.80f));
            students.Add(new Student("Nikolay", "Kostov", 6.00f));
            students.Add(new Student("Liubomir", "Qnchev", 5.50f));
            students.Add(new Student("Pavel", "Kolev", 5.00f));
            students.Add(new Student("Doncho", "Minkov", 5.70f));
            students.Add(new Student("Asq", "Georgieva", 5.00f));
            students.Add(new Student("Mihail", "Petrov", 5.10f));
            students.Add(new Student("Ninja", "Developer", 7));
            students.Add(new Student("Gosho", "otPochivka", 3.00f));

            var sortedByGrade =
                from student in students
                orderby student.Grade descending
                select student;
            foreach (Student student in sortedByGrade)
            {
                Console.WriteLine(student);
            }

            
            Console.WriteLine( new string('-', 70 )); //Seperator

            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Hitur", "Petur", 200, 1));
            workers.Add(new Worker("Dqdo", "Koleda", 0, 8));
            workers.Add(new Worker("Rumaneca", "iEnchev", 1000, 8));
            workers.Add(new Worker("Car", "Kiro", 5000, 3));
            workers.Add(new Worker("Mitko", "Mitkooo", 20, 1));
            workers.Add(new Worker("Harry", "Potter", 100, 6));
            workers.Add(new Worker("Worker", "1", 250, 8));
            workers.Add(new Worker("Worker", "2", 350, 8));
            workers.Add(new Worker("Worker", "3", 275, 8));
            workers.Add(new Worker("Worker", "4", 300, 8));

            var sortedBySallary =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;
            foreach (Worker worker in sortedBySallary)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine(new string('-', 70)); //Seperator

            var merged = students.Concat<Human>(workers).ToList();

            var sotedMerged =
                from human in merged
                orderby human.Name ascending
                select human;

            foreach (var human in sotedMerged)
            {
                Console.WriteLine(human);
            }
        }
    }
}
