using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Dog : Animal
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello, I'm a dog!");
        }

        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
}

