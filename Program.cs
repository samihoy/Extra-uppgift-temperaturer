using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace run_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ange en temperatur");
            int temp = 0;

            do
            {
                temp = Convert.ToInt32(Console.ReadLine());

                if (temp >= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("jättevarm");
                    Console.ResetColor();
                }
                else if (temp >= 20 && temp < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("varmt");
                    Console.ResetColor();

                }
                else if (temp < 20)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Hösttemperatur");
                    Console.ResetColor();
                }
            } 
            while (Convert.ToString(temp) != "exit");
        }
    }
}
