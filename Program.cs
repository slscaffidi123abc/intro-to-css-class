using System;

namespace Class
{
    class Program
    {
        public class Animal
        {
            public string Name, breed;


            public void Greeting()
            {
                Console.WriteLine("woof, my name is " + Name + " and my breed is " + breed);
            }

        }
        public class Cat
        {
            public string Name;
            public bool SixorNot;

            public void Greeting2()
            {
                Console.WriteLine("meow, my name is" + Name + " and I am not a six toed cat");
            }
        }
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Sonny";
            animal.breed = "German Shepard";

            animal.Greeting();

            Cat cat = new Cat();
            cat.Name = " felix";


            cat.Greeting2();

            int num = 5;

            if (num == 6)
            {
                Console.WriteLine("felix has six toes");
            }
            else if (num == 5)
            {
                Console.WriteLine("felix has five toes");
            }
        }
    }
}
