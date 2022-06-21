using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina3
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            Ejercicios Facture = new Ejercicios();

            Console.WriteLine("Welcome to the main payroll menu");
            Console.WriteLine("1. Enter new employee");
            Console.WriteLine("2. Exit of console");

            string Opc = Console.ReadLine();

            int Opc1;

            switch (Opc)
            {
                case "1":
                    do
                    {
                        Facture.CalculatePayroll();
                        Facture.Printdata();
                        Console.WriteLine("1. Enter new employee");
                        Console.WriteLine("2. Exit of console");

                        Opc1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    while (Opc1 !=2 );
                    break;


                case "2":
                    Console.WriteLine("Exit of program");
                    break;
            }
        }
    }
}
