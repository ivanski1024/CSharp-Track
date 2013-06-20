using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            //... 
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            //...
            return new Carrot();
        }

        private Potato GetPotato()
        {
            //...
            return new Potato();
        }

        public void Cook()
        {
            Bowl bowl = GetBowl();

            Potato potato = GetPotato();
            AddVegetable(potato, bowl);

            Carrot carrot = GetCarrot();
            AddVegetable(carrot, bowl);
        }

        public void AddVegetable(Vegetable vegetable, Bowl bowl)
        {
            Peel(vegetable);
            Cut(vegetable);
            bowl.Add(vegetable);
        }

        private void Cut(Vegetable potato)
        {
            //...
        }

        private void Peel(Vegetable vegetable)
        {
            //...
        }
    }
}
