// See https://aka.ms/new-console-template for more information

using EjercicioPolimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Cat();
        myAnimal.SayHello();
        myAnimal.Speak();

        myAnimal = new Dog();
        myAnimal.SayHello();
        myAnimal.Speak();

        myAnimal = new Fish();
        myAnimal.SayHello();
        myAnimal.Speak();

        Console.ReadLine();
    }
}

