using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "black");
            secondCat.Name = "Joe";

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";

            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());

            firstCat.Eat();
            //secondCat.Meow();

            Dog dog1 = new Dog("long", 18, "fast", 52.2);

            dog1.Run();
            Superhero sp1 = new Superhero(67, "X-Men", "Yellow and Blue", "Wolverine");
            sp1.SuperName();

        }   
    }
}
