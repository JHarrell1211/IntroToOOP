using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {

        private string hairLength;
        private int height;
        private string runningSpeed;
        private double weight;

        public Dog()
        {

        }

        public Dog(string a, int b,string c, double d)
        {
            this.hairLength = a;
            this.height = b;
            this.runningSpeed = c;
            this.weight = d;
        }

        public void Run()
        {
            Console.WriteLine("My dog runs " + this.runningSpeed);
        }
        public void Bark()
        {

        }
        public void Potty()
        {

        }
        public void Cuddle()
        {

        }

    }
}
