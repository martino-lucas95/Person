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
            Person john = new Person("John Doe", "1.234.567-8");
            Person jane = new Person("Jane Doe", "8.765.432-1");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
