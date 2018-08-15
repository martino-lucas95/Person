using System;

namespace PosterObjectsClassesMessages
{
    public class Person
    {
        public Person(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }
        public string Name { get; set; }
        public string ID { get; set; }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person juan = new Person("Juan Pérez", "1.234.567-8");
            Person maria = new Person("María García", "8.765.432-1");
            juan.IntroduceYourself();
            maria.IntroduceYourself();
        }
    }
}
