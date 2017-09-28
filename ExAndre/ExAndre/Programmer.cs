using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAndre
{
    class Programmer : Human
    {
        string language;
        string IDE;

        public Programmer(string language, string IDE, int age, int fatigue, string name, Pet doggo)
        {
            this.language = language;
            this.IDE = IDE;
            this.age = age;
            this.fatigue = fatigue;
            this.name = name;
            Pet pet = doggo;
        }
        public void Work()
        {
            if (fatigue > 70)
            {
                Console.WriteLine("Better not work now mate, you shall perish");
            }
            else
            {
                Console.WriteLine("Fatigue before work:  " + fatigue);
                fatigue = fatigue - 30;
                Console.WriteLine("Fatigue after work:  " + fatigue);
            }
        }
    }
}
