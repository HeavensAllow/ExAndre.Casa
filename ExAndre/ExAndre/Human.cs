using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAndre
{
    class Human : Animal
    {
        protected string name;
        protected Pet pet;

        public void Sleep()
        {
            if (fatigue < 10)
            {
                Console.WriteLine("You aren't tired at all get working newb");
            }
            else
            {
                Console.Write("Minutes of sleep?");
                int time = Console.Read();
                Console.WriteLine("You went to sleep with {0}% of fatigue", fatigue);
                fatigue = Convert.ToInt32(fatigue - (time / 60 * 1.5));
                Console.WriteLine("You are well rested! You woke up with {0}% of fatigue", fatigue);
            }
        }

        public void Run()
        {
            if (fatigue > 80)
            {
                Console.WriteLine("Your fatigue is above 9000 mate! No run for you");
            }
            else
            {
                Console.Write("Distance to run (in meters)?");
                double distance = Console.Read();
                Console.WriteLine("You went to run with {0}% of fatigue", fatigue);
                fatigue = Convert.ToInt32(fatigue + (distance / 10));
                Console.WriteLine("You are well rested! You woke up with {0}% of fatigue", fatigue);
            }
        }

        public void Play(Pet pet)
        {
            if (fatigue > 65)
            {
                Console.WriteLine("Mate you see how tired you are? And you wanna play with doggo? Plz doggo will rekt you");
            }
            else if (pet.fatigue > 65)
            {
                Console.WriteLine("You dont wanna kill poor doggo do you? Let him rest for a while");
            }
            else
            {
                Console.WriteLine("Owner fatigue before playing: {0}%", fatigue);
                fatigue = fatigue + 35;
                Console.WriteLine("Owner fatigue after playing: {0}%", fatigue);
                Console.WriteLine("Pet fatigue before playing: {0}%", pet.fatigue);
                pet.fatigue = pet.fatigue + 35;
                Console.WriteLine("Pet fatigue after playing: {0}%", pet.fatigue);
            }
        }

        public void Play()
        {
            if (fatigue > 80)
            {
                Console.WriteLine("Bro you see how tired you are? We dont want you dying while playing some COD do we? Play denied!");
            }
            else
            {
                Console.WriteLine("Fatigue before play time: {0]", fatigue);
                fatigue = fatigue + 20;
                Console.WriteLine("Fatigue after playing:  {0}", fatigue);
            }
        }
    }

}
