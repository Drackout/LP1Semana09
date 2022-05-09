using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Animal[] AnimalArray = new Animal[10];
            int randomNumber = 0;

            //Fills the array with 10 random animals
            for (int i = 0; i < AnimalArray.Length; i++)
            {
                randomNumber = rnd.Next(0, 4);
                if (randomNumber==0)
                {
                    AnimalArray[i] = new Cat();
                }
                else if(randomNumber==1)
                {
                    AnimalArray[i] = new Dog();
                }
                else if(randomNumber==2)
                {
                    AnimalArray[i] = new Bat();
                }
                else 
                {
                    AnimalArray[i] = new Bee();
                }
                Console.WriteLine(AnimalArray[i].Sound());
            }
        }
    }
}
