using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Employee
    {
        public int a;
        protected int b;
        private int c;
        internal int d;

        public void CalculateSalary(int bonus, int age)
        {
            int t = a + b + c + d;
        }
    }
    public class inharite : Employee
    {
        public void Dosomething()
        {
          int H= a + b + d; 
               
        }
            
            
              
    }
       

}



    

