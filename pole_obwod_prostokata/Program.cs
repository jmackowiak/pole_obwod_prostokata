using System;

namespace pole_obwod_prostokata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość pierwszego boku:");
            string stra = Console.ReadLine();
            Console.WriteLine("Podaj długość drugiego boku:");
            string strb = Console.ReadLine();
            Console.WriteLine();

            if (float.TryParse(stra, out float boka) && float.TryParse(strb, out float bokb) == true)
            {
                float pole = boka * bokb;
                float obwod = 2 * boka + 2 * bokb;

                Console.WriteLine("Pole prostokąta wynosi: {0}", pole);
                Console.WriteLine("Obwód prostokąta wynosi: {0}", obwod);
            }
            else
            {
                Console.WriteLine("Podałeś błędne dane!");
            }

            Console.ReadKey();
        }
    }
}
