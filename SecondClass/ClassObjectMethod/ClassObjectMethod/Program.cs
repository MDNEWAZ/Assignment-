using System;

namespace ClassObjectMethod
{
    public class Person
    {
        public string FirstName;
        public String LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " +FirstName+ "" +LastName);
        }

    }





    public class Program
    {
        static void Main(string[] args)
        {

            var jon = new Person();
            
                     jon.FirstName = "shah";
                     jon.LastName = "newaz";
                     jon.Introduce();

        }
    
     

    }
       
    
}
