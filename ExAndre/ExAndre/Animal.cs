using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAndre
{
    class Animal
    {
        private string classification;
        protected int age;
        protected int fatigue = 0;
       
        //public int Fatigue { get; set; }

        public int Fatigue { get => fatigue; set { fatigue = value; if(fatigue>100) fatigue = 100;} }
        //public int Fatigue
        //{
        //    get
        //    {
        //        return fatigue;
        //    }
        //    set
        //    {
        //        fatigue = value;
        //        if (fatigue > 100) fatigue = 100;
        //    }
        //}

        public Animal(string classification, int age)
        {
            this.classification = classification;
            this.age = age;
        }

        public void Sleep(int time)
        {
            if (fatigue > 10)
            {
                int oldFatigue = fatigue;
                fatigue -= Convert.ToInt32(time / 60 * 1.5);
                Console.WriteLine("(SLEEP) Old fatigue = {0}, New Fatigue = {1}", oldFatigue, fatigue);
            }
            else
            {
                Console.WriteLine("(SLEEP) Not tired - fatigue = {0}", fatigue);
            }
        }

        public void Play()
        {
            if (fatigue >= 80)
            {
                Console.WriteLine("(Play) Too tired - fatigue = {0}", fatigue);
            }
            else
            {
                int oldFatigue = fatigue;
                fatigue += 20;
                Console.WriteLine("(SLEEP) Old fatigue = {0}, New Fatigue = {1}", oldFatigue, fatigue);
            }
        }
    }
}
