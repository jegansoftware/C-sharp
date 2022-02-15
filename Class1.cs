using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public void jegan()
        {
            int a, b, c, d, e = 0;
            int condition = 0;

            String user_name;
            String password;

            String user_name1 = "Jegan";
            String Password1 = "Selvan143!";
            String yes;
            String yes1 = "Yes";
            String yes11 = "YES";
            String Yes111 = "yes";

            Console.WriteLine("\nEnter  your User Name ::");
            user_name = Console.ReadLine();


            Console.WriteLine("\nEnter your Password ::");
            password = Console.ReadLine();




            if ((user_name.Equals(user_name1)) && (password.Equals(Password1)))
            {


                Console.WriteLine("\nEnter A value  ::");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter B value  ::");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEnter C value  ::");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nENTER D value  :: ");
                d = Convert.ToInt32(Console.ReadLine());


                condition = (a * 1000) + (b * 100) + (c * 10) + (d * 1);

                Console.WriteLine("Are you ready to see the result ??");
                yes = Console.ReadLine();

                if (yes.Equals(yes1) || yes.Equals(yes11) || yes.Equals(Yes111))
                {
                    Console.WriteLine("The Answer is {0}", condition);

                    Console.ReadLine();
                }


            }
            else
            {

                Console.WriteLine("\nSorry Dear Friend \n");

                Console.WriteLine("Wrong USER NAME OR PASSWORD has been entered  ");

                Console.ReadLine();
               
            }


        }

    }
}
