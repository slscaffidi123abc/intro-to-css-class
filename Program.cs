using System;

namespace CS_Intro1
{
    class Program //this our main class

    {   
        static void Main(string[] args)

        {    
            Console.WriteLine ("what time is bed time?");

            //string variable
            string sleepy = "what time is bed time?";
            string hour = "NOT FOR FOUR MORE HOURS";
            string sad = " i wish i was dreaming";


            //numbers variable
            int number1 = 10;
            float time1 = 10.00F;
            float time8 = 11.00F;
            double time2 = 10.3333;

            //boolean variable
            bool boolean = true;
            Console.WriteLine(sleepy);
            Console.WriteLine(time1);
            Console.WriteLine(time2);
            Console.WriteLine(boolean);

            //concatanate
            
            string concate1 = sleepy + hour + time1 + sad;
            Console.WriteLine(concate1);

            //multiply variable
            float multiply = time1 * time8;
            Console.WriteLine(multiply);


            //constant
            const int years = 100;
            const int ages = 500;
            Console.WriteLine(years);
            Console.WriteLine(ages);

            //interpolate 
            string interpolate=  (sad + hour);
            Console.WriteLine(interpolate);















        }
    }
}
