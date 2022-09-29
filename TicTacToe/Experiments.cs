using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class MyExperiments
    {
        class Number
        {
            public int x = 0;
            public int y = 0;

        }

        static void Run()
        {
            void MakeGenericSound()
            {
                Console.WriteLine("MakeGenericSound");
            }

            Animal animal1 = new Animal();
            animal1.MakeASound();
            animal1.MakeAnotherSound();
            Console.WriteLine(animal1.farts);

            Animal animal2 = new Animal();
            animal2.MakeAnotherSound();
            animal2.MakeASound();

            Dog dog1 = new Dog();
            dog1.MakeASound();
            dog1.MakeAnotherSound();

            Animal animalDog = new Dog();
            animalDog.MakeASound();
            animalDog.MakeAnotherSound();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Fox());
            animals.Add(new Fox());
            animals.Add(new Fox());

            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].MakeASound();
            }


            void ChangeNumber(Number myNum)
            {
                myNum.x = myNum.x + 1;
            }

            void ChangeNumber2(int myNum)
            {
                myNum = myNum + 1;
            }


            Number a = new Number();
            ChangeNumber(a);
            Console.WriteLine(a.x);

            int myNiceNum = 7;
            ChangeNumber2(myNiceNum);
            Console.WriteLine(myNiceNum);

            a.x = 6;

            Number b = a;
            Console.WriteLine(b.x);

            b.x = 8;
            Console.WriteLine(a.x);


            /*

            int testInt = 1;
            testInt = testInt + 1;
            testInt++;

            for (int i = 0; i < 10; i++)
            {
                animal1.MakeASound();
            }

            int times = 0;
            while(times < 10)
            {
                animal1.MakeASound();
                times++;
            }

            //
            string myCoolStr = "Marije";
            int index = 0;
            char currentVal = char.MaxValue;
            while(currentVal != 'j')
            {
                currentVal = myCoolStr[index];
                index++;
            }

            Console.WriteLine(index);
            //

            MakeGenericSound();

            int myInt = 0;
            myInt = 3;
            Console.WriteLine(myInt);

            myInt = 3 + 2;
            Console.WriteLine(myInt);

            int myOtherInt = 40;

            myInt = myInt + myOtherInt;
            Console.WriteLine(myInt);

            string myStr = "Bob";

            */
        }
    }

    class Animal
    {
        // varaibles section
        public int farts = 3;

        // functions 
        public virtual void MakeASound()
        {
            Console.WriteLine("Generic animal sound");
            Fart(farts);
            //Fart(4);   
        }

        public void MakeAnotherSound()
        {
            Console.WriteLine("Another Generic animal sound");
        }


        void Fart(int num)
        {
            //int localNum = num;
            Console.WriteLine(num);
        }
        // end functions
    }

    class Dog : Animal
    {
        public override void MakeASound()
        {
            Console.WriteLine("Woooooof");
        }
    }
    class Cat : Animal
    {
        public override void MakeASound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Fox : Animal
    {
        public override void MakeASound()
        {
            Console.WriteLine("Yip");
        }
    }
}
