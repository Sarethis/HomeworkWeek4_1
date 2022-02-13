using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaTydz4_1
{
    internal class Program
    {
        static public int GetInputData()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.WriteLine("Podana wartość nie jest liczbą, spróbuj ponownie.\nTwoja liczba: ");
                    continue;
                }
                return userNumber;
            }

        }
        static void Main(string[] args)
        {
            int userNumber;
            Console.WriteLine("Cześć, podaj liczbę, ja sprawdzę czy jest ona nieparzysta czy parzysta:");

            userNumber = GetInputData();

            if (userNumber % 2 == 0)
                Console.WriteLine("Liczba która podałeś jest parzysta!");
            else
                Console.WriteLine("Liczba którą podałeś jest nieparzysta!");
        }
    }
}
