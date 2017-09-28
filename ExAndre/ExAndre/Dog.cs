using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAndre
{
    class Dog : Pet
    {
        string race;
        string petname;

        public Dog(string race, int age, int fatigue, string petname)
        {
            this.race = race;
            this.age = age;
            this.fatigue = fatigue;
            this.petname = petname;
        }
    }
}
