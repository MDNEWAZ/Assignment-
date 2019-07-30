using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program

    {
        public int myPublicClass;
        static void Main(string[] args)
        {

            Student s1=new Student();
            s1.name = "shah newaz";
            s1.age = 24;

            Student s2 = s1;

            s2.name = "hania";
            s2.age = 14;
         
            Student s3 = s1;

            s3.name = "sima";
            s3.age = 13;
            Console.WriteLine("student 3 name:{0},student 3 age :{1}", s3.name, s3.age);
            Console.WriteLine("student 2 name:{0},student 2 age :{1}", s2.name, s2.age);
            Console.WriteLine("student 1 name:{0},student 1 age :{1}", s1.name, s1.age);
           
            point p1=new point();
            p1.y = 24;
            p1.z = 14;
            point p2 = p1;
            p2.y = 17;
            p2.z = 34;
            Console.WriteLine("print p1 y :{0},print p1 z :{1}",p1.y,p1.z);
            Console.WriteLine("print p2 y :{0},print p2 z :{1}", p2.y, p2.z);


            Employee k = new Employee();
       
            Console.ReadKey();

        }
    }

    struct point
    {
        public int z;
        public int y;
    }

    class  Student
    {
        public String name;
        public int age;
        

    }
  

}
