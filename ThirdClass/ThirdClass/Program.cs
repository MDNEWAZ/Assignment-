using System;

namespace ThirdClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "shah-newaz";
            Console.WriteLine(weekDays.Saterday);
            var user = new User();
            if (user.Status == registrationStatus.Active && user.Types == UserType.Admin)
            {
                Console.WriteLine("Registration Successful");
            }
            


            
        }
    }
     class Person 
    {
     
        public string Name { get; set; }

    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public registrationStatus Status { get; set; }
        public UserType Types { get; set; }
    }
    enum weekDays
       {
          Saterday,
          Sunday,
          Monday,
          Tuesday,
          Wednesday,
          Thursday,
          Friday
         
       }
    public enum registrationStatus
    {
        Inactive,
        Active,
        Block,
    }
    public enum UserType
    {
        Admin,
        SuperAdmin,
        User,
        Support,

    }
}

