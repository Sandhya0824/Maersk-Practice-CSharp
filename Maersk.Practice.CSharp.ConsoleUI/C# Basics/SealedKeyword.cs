using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class SealedKeyword
    {
        public class Animal
        {
            public virtual void eat() 
            { 
               Console.WriteLine("Animal is eating"); 
            }
            public virtual void run() 
            { 
               Console.WriteLine("Animal is running"); 
            }

        }
        public class Dog : Animal
        {
            public override void eat() 
            { 
                Console.WriteLine("Dog is eating bread"); 
            }
            public sealed override void run()
            {
                Console.WriteLine("Dog is running very fast");
            }
        }
        public class BabyDog : Dog
        {
            public override void eat() 
            { 
                Console.WriteLine("Baby dog is eating biscuits"); 
            }
            public override void run() 
            { 
                Console.WriteLine("Baby dog is running slowly"); 
            }
        }
        public class TestSealed
        {
            public static void Main()
            {
                BabyDog d = new BabyDog();
                d.eat();
                d.run();
            }
        }
    }
}
