using System;

namespace AnimalKingdom
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Animal[] animals = new Animal[10];
            Random rnd = new Random();


            for (int i = 0; i < 10; i++)
            {
                switch (rnd.Next(4))
                {
                    case 0:
                        animals[i] = new Bat();
                        break;
                    case 1:
                        animals[i] = new Bee();
                        break;
                    case 2:
                        animals[i] = new Cat();
                        break;
                    case 3:
                        animals[i] = new Dog();
                        break;
                    default:
                        // This should NEVER happen
                        throw new ArgumentOutOfRangeException("Unknown animal!");
                }
            }

            foreach (Animal anim in animals)
            {
                Console.Write($"{anim.GetType().Name} {anim.Sound()}\n");

                if (anim is IMammal)
                {
                    Console.WriteLine($"{(anim as IMammal).NumberOfNipples}\n");
                }
                if (anim is ICanFly)
                {
                    Console.WriteLine($"{(anim as ICanFly).NumberOfWings}\n");
                }
            }

        }
    }
}
