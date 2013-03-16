using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal : ISound
    {
        public enum Gender { Male, Female};

        protected byte age;
        protected string name;
        protected Gender sex;

        public Animal(string name, byte age, Gender sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }



        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public byte Age
        {
            get 
            {
                return this.age;
            }
        }

        public abstract string Sound();


        public static double AvarageAge(IEnumerable<Animal> animals)
        {
            double count =0;
            double ages = 0;
            foreach (Animal animal in animals)
            {
                ages += animal.Age;
                count++;
            }
            return ages / count;
        }
    }
}
