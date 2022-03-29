using System.Globalization;
using System; 
 
namespace PosterObjectsClassesMessages 
{ 
    public class Person 
    { 
        public string name{ get; private set; }
        public string id{ get; private set; }

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

        public void NameIsValid() 
        { 
            if(IdUtils.IdIsValid(this.id) && this.name.Trim() != ""){
                this.IntroduceYourself();
            }
            else{
                Console.WriteLine("Nombre o Cedula invalido");
            }
        } 

    } 
}