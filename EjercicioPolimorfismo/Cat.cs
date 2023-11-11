using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Cat : Animal
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello, I'm a cat!");
        }

        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

}

