using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAndre
{
    class Dog : Pet
    {
        private string race;

            public Dog(string classification, int age, string name, string race) : base(classification, age, name)
        {
            this.race = race;
        }

        //public Dog(string race, int age, int fatigue, string petname, Human humano)
        //{
        //    this.race = race;
        //    this.age = age;
        //    this.fatigue = fatigue;
        //    this.petname = petname;
        //    Human owner = humano;
        //}
    }
}
