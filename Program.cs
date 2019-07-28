using System;

namespace AnimalFeed
{
    class Program
    {
        static void Main(string[] args)
        {
            var puppy = new Puppy();

            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            int integer = 500;

            var cat = new Cat();
            cat.Eat();

            for (int i = integer; i > 0; i--)
            {
                Console.Beep(i, i);
                i += 100;
                Console.Beep(i, i);
                if (i < 0)
                {
                    break;
                }
            }
          

        }
    }
}
