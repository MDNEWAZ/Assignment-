using System;

namespace SecontClass
{
    class Program
    {
        static void Main(string[] args)
        {


            // int x = 1;
            // float f = x;//implecit(No data lose)
            // int k = 1;
            // byte b = k;//explecit (data lose)

            // var person = new//annanomous type
            {
                //FirstName = "Shah",
                // LastName = "Newaz",
                // Age = 24
            }
            ;

            // dynamic newaz = 100;
            // newaz = "shah";
            // newaz = true;
            //newaz = 2.56;
            //Console.WriteLine(newaz);
            //  Console.WriteLine(person.FirstName);
            int f = 0;
            int s = 3;
            for(int j=0;j>10;j++)
            {
                Console.WriteLine("");
            }
            while(f>s)
             {
                f++; 
             }
            do
            {
                Console.WriteLine("hi");
            }
            while(f<10)
            string[] names = new string[10];

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            var missial = new missial();
            {
                missial.Fire();
            }
            var gun = new MachineGun();
            {
                gun.Fire();
            }

            var card = new ShippingCard();
            {
                for (int i = 0; i < card.Items.Length; i++)
                {
                    Console.WriteLine(card.Items[i].GetVat());
                }
            }
        }

    }
    

        public class Inter


        {

        }

        public interface Iweapen
        {

        }

        public abstract class Weapen
        {

        }

        public class missial
        {
            public int Damagepower; //keep it private

            public missial()
            {
                Damagepower = 200;
            }

            public void Fire()
            {
                Console.WriteLine("Missile was failed:{0}", Damagepower);
            }


        }

        public class MachineGun
        {
            public int Damagepower; //keep it private

            public MachineGun()
            {
                Damagepower = 100;
            }

            public void Fire()
            {
                Console.WriteLine("Missile was failed:{0}", Damagepower);

            }
        }

         public  abstract class Item
        {
            public string imageUrl;
            public double Price;
            public abstract double GetVat();
        }

        public class product : Item
        {
            public string Name;

            public override double GetVat()
            {
                return Price * 15 / 100;

            }

        }

       public class GivtCard:Item

        {
            public String ReceiverMailAddress;

            public override double GetVat()
            {
                return 0;
            }
        }

        class ShippingCard
       {
           public Item[] Items;


       }
}




