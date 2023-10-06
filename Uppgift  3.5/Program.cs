using System;
namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal med mellanslag t.ex 10 11");
            string svar = Console.ReadLine();
            int mellanslagsindex = svar.IndexOf(" ");

            string tal3 = svar[..mellanslagsindex];
            string tal4 = svar[(mellanslagsindex + 1)..];
            int tal1 = int.Parse(tal3);
            int tal2 = int.Parse(tal4);

            Console.WriteLine("Välj räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            string räknesätt = Console.ReadLine();  

            switch (räknesätt)
            {
                case "1":
                    Console.WriteLine(tal1 + tal2);
                    break;

                case "2": 
                    Console.WriteLine(tal1 - tal2);
                    break;
                    
                case "3":
                    Console.WriteLine(tal1 * tal2);
                    break;
                    
                case "4":
                    Console.WriteLine(tal1 / tal2);
                    break;


            }

            Console.ReadKey();
        }
    }
}