using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_provet_del_2_Benjamin_Bergfors
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int amount = 0;
            
            Console.WriteLine("Hur många bilar ska skapas?");
            Console.ReadLine();
            amount++;
            if (amount < 1)
            {
                Console.WriteLine("Måste skapa minst en bil");
                Console.WriteLine("Hur många bilar ska skapas?");
                Console.ReadLine();
            }
            if (amount > 0)
            {
                
                    Console.WriteLine(amount + " bilar");
                    Console.WriteLine("Vilken bil vill du kolla på?");
                    Console.ReadLine();
            
            }
        }
    }
}
