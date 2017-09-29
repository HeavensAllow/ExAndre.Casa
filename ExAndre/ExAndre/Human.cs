using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAndre
{
    class Human : Animal
    {
        private string name;
        private Pet pet;
        public Pet Pet {
            get
            {
                return pet;
            }
            set
            {
                pet = value;
                value.owner = this;
            }
        }

        public Human(string classification, int age, string name) : base(classification, age)
        {
            this.name = name;
        }

        public void Run(int distance)
        {
            int modifier = distance / 10;
            
            if(fatigue >= 100 - modifier)
            {
                Console.WriteLine("(RUN) Too tired - fatigue = {0}", fatigue);
            }
            else
            {
                int oldFatigue = fatigue;
                fatigue += modifier;
                Console.WriteLine("(RUN) Old Fatigue = {0}, New fatigue = {1}", oldFatigue, fatigue);
            }
        }

        public void Play(Pet p)
        {
            if (fatigue >= 65 || p.Fatigue >= 65)
            {
                if(fatigue >= 65)
                {
                    Console.WriteLine("(Play) Human too tired - fatigue = {0}", fatigue);
                }
                else
                {
                    Console.WriteLine("(Play) Pet too tired - fatigue = {0}", p.Fatigue);
                }
            }
            else
            {
                int oldFatigue = fatigue;
                int petFatigue = p.Fatigue;
                fatigue += 35;
                p.Fatigue += 35;
                Console.WriteLine("(Play) Human - Old fatigue = {0}, New Fatigue = {1}", oldFatigue, fatigue);
                Console.WriteLine("(Play) Pet - Old fatigue = {0}, New Fatigue = {1}", petFatigue, p.Fatigue);
            }
        }

        //public void DeclareOwner(Pet doggo)
        //{
        //    Pet pet = doggo;
        //}

        //public void Sleep()
        //{
        //    if (fatigue < 10)
        //    {
        //        Console.WriteLine("You aren't tired at all get working newb");
        //    }
        //    else
        //    {
        //        Console.Write("Minutes of sleep?");
        //        int time = Console.Read();
        //        Console.WriteLine("You went to sleep with {0}% of fatigue", fatigue);
        //        fatigue = Convert.ToInt32(fatigue - (time / 60 * 1.5));
        //        Console.WriteLine("You are well rested! You woke up with {0}% of fatigue", fatigue);
        //    }
        //}

        //public void Run()
        //{
        //    if (fatigue > 80)
        //    {
        //        Console.WriteLine("Your fatigue is above 9000 mate! No run for you");
        //    }
        //    else
        //    {
        //        Console.Write("Distance to run (in meters)?");
        //        double distance = Console.Read();
        //        Console.WriteLine("You went to run with {0}% of fatigue", fatigue);
        //        fatigue = Convert.ToInt32(fatigue + (distance / 10));
        //        Console.WriteLine("You are well rested! You woke up with {0}% of fatigue", fatigue);
        //    }
        //}

        //public void Play(Pet pet)
        //{
        //    if (fatigue > 65)
        //    {
        //        Console.WriteLine("Mate you see how tired you are? And you wanna play with doggo? Plz doggo will rekt you");
        //    }
        //    else if (pet.fatigue > 65)
        //    {
        //        Console.WriteLine("You dont wanna kill poor doggo do you? Let him rest for a while");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Owner fatigue before playing: {0}%", fatigue);
        //        fatigue = fatigue + 35;
        //        Console.WriteLine("Owner fatigue after playing: {0}%", fatigue);
        //        Console.WriteLine("Pet fatigue before playing: {0}%", pet.fatigue);
        //        pet.fatigue = pet.fatigue + 35;
        //        Console.WriteLine("Pet fatigue after playing: {0}%", pet.fatigue);
        //    }
        //}

        //public void Play()
        //{
        //    if (fatigue > 80)
        //    {
        //        Console.WriteLine("Bro you see how tired you are? We dont want you dying while playing some COD do we? Play denied!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fatigue before play time: {0]", fatigue);
        //        fatigue = fatigue + 20;
        //        Console.WriteLine("Fatigue after playing:  {0}", fatigue);
        //    }
        //}
    }

}
