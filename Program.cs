using System;

namespace PosterObjectsClassesMessages

{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-2");
            Person jane = new Person("Jane Doe", "8.765.432-7");
            Person prueba1 = new Person("  ", "1.234.567-2");
            Person prueba2 = new Person("Lucas", "1.234.567-8");
        }
    }
}
