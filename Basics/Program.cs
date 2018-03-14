using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void log(string s) { Console.WriteLine(s); }
        static void Main(string[] args)
        {
            byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.8f;
            float mass = 14.6f;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            if (sample1 == sample2)
                log("The samples are equal.");
            else
                log("The samples are not equal.");

            if (heartRate >= 40 && heartRate <= 80)
                log("Heart rate is normal.");
            else
                log("Heart rate is not normal.");

            if (deposits >= 100000000)
                log("You are exceedingly wealthy.");
            else
                log("Sorry you are so poor.");

            float force = mass * acceleration;

            log("force = " + force);
            log(distance.ToString() + " is the distance.");

            if (lost && expensive)
                log("I am really sorry! I will get the manager.");
            else if (lost && expensive == false)
                log("Here is coupon for 10% off.");

            switch (choice)
            {
                case 1:
                    log("You chose 1.");
                    break;
                case 2:
                    log("You chose 2.");
                    break;
                case 3:
                    log("You chose 3.");
                    break;
                default:
                    log("You made an unkown choice.");
                    break;
            }

            log(integral + " is an integral.");

            for (int i = 5; i <= 10; i++)
                log("i = " + i.ToString());

            int age = 0;

            while (age < 6)
            {
                log("age = " + age.ToString());
                age++;
            }

            log(greeting + " " + name);
            Console.ReadKey();
        }
        
    }
}
