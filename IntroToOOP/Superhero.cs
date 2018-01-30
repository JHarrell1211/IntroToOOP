using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Superhero
    {
        private int strengthLevel;
        private string affiliation;
        private bool cape;
        private string gear;
        private string name;
        private bool attacked;


        public Superhero()
        {

        }
        public Superhero(int a,string c, string d, bool e)
        {
            this.strengthLevel = a;
            this.gear = c;
            this.name = d;
        }
        public string SuperName
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public void SuperInfo()
        {
            Console.WriteLine(name + "'s strength level is " + strengthLevel + " and his gear is " + gear);
        }
        public void Cape()
        {
            if (cape)
            {
                cape = true;
            }
            else
            {
                cape = false;
            }
            Console.WriteLine(this.name + " wears a cape " + cape );
        }

        public void RedBull()
        {
            Console.WriteLine(name + " drank a red bull, new strength level is " + (strengthLevel * 3));
        }
        
        public void Attacked()
        {
            Console.WriteLine(name + " was hit by attack");
            Console.WriteLine(name + "'s new strength level is " + (strengthLevel - 100));
        }
    }
}
