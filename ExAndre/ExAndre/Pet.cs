using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAndre
{
    class Pet : Animal
    {
        protected string name;
        protected Human owner;

        public void Sleep()
        {
            if (fatigue < 10)
            {
                Console.WriteLine("You aren't tired at all go play boy!");
            }
            else
            {
                Console.Write("Minutes of sleep?");
                double time = Console.Read();
                Console.WriteLine("You went to sleep with {0}% of fatigue", fatigue);
                fatigue = Convert.ToInt32(fatigue - (time / 60 * 1.5));
                Console.WriteLine("You are well rested! You woke up with {0}% of fatigue", fatigue);
            }
        }

        public void Play()
        {
            if (fatigue > 80)
            {
                Console.WriteLine("Lets not kill poor doggo okay? Let him rest first");
            }
            else
            {
                Console.WriteLine("Pet fatigue before playing: {0}%", fatigue);
                fatigue = fatigue + 20;
                Console.WriteLine("Pet fatigue after playing: {0}%", fatigue);
            }
        }

        public void Play(Human owner)
        {
            if (fatigue > 65)
            {
                Console.WriteLine("Mate you see how tired you are? And you wanna play with doggo? Plz doggo will rekt you");
            }
            else if (owner.fatigue > 65)
            {
                Console.WriteLine("You dont wanna kill poor doggo do you? Let him rest for a while");
            }
            else
            {
                Console.WriteLine("Owner fatigue before playing: {0}%", owner.fatigue);
                owner.fatigue = owner.fatigue + 35;
                Console.WriteLine("Owner fatigue after playing: {0}%", owner.fatigue);
                Console.WriteLine("Pet fatigue before playing: {0}%", fatigue);
                fatigue = fatigue + 35;
                Console.WriteLine("Pet fatigue after playing: {0}%", fatigue);
            }
        }
    }
}
