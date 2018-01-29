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
        private string disguiseColor;
        private string name;



        public Superhero()
        {

        }
        public Superhero(int a, string b,string c, string d )
        {
            this.strengthLevel = a;
            this.affiliation = b;
            this.disguiseColor = c;
            this.name = d;
        }
        public void SuperName()
        {
            Console.WriteLine(name);
        }
        
    }
}
