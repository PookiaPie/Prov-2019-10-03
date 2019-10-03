using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_2019_10_03_H.O
{
    class Böcker
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator;

        public void Book()
        {
            Random generator = new Random();
            actualValue = generator.Next(100);
            rarity = generator.Next(100);


            Console.WriteLine(actualValue + rarity);

        }

        public void PrintInfo()
        {

        }

        public void Evalute()
        {

        }

        public void Getcategory()
        {

        }

        public void GetName()
        {

        }

        public void IsCursed()
        {

        }


    }
}
