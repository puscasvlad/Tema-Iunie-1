using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Iunie
{
    class Program
    {
        static void Main(string[] args)
        {

            //introducem un user name si parola validare, incercam de 3 ori.

            Console.WriteLine("Introduceti usernameul: ");
            string user = Console.ReadLine();
            Console.WriteLine("Introduceti parola: ");
            string parola = Console.ReadLine();

            Validator validator = new Validator();

            if(validator.Valideaza(user,parola))
            {
                Console.WriteLine("Succes");
            }
            else
            {
                Console.WriteLine("Date gresite");
            }



            Console.ReadLine();
        }
    }
}
