using System; 
 
namespace PosterObjectsClassesMessages 
{ 
    public class Person 
    { 
        public string name; 

        public string id; 

        public Person(string name, string id) 
        { 
            this.name = name; 
            this.id = id; 
        } 

        public void IntroduceYourself() 
        { 
            Console.WriteLine( 
                $"Soy {this.name} y mi cédula es {this.id}"); 
        } 
    } 
}