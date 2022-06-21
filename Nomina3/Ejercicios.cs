using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Nomina3
{
    internal class Ejercicios
    {
        Datos myExercises = new Datos();
        
        public void CalculatePayroll()
        {
            try
            {
                Console.WriteLine("Enter firts name: ");
                myExercises.FirtsName1 = Console.ReadLine();

                Console.WriteLine("Enter last name: ");
                myExercises.LastName1 = Console.ReadLine();

                Console.WriteLine("Enter document: ");
                myExercises.Document1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter salary: ");
                myExercises.Salary1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter worked days: ");
                myExercises.WorkedDays1 = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Value NOT Valied, insert other");
            }
            myExercises.TotalAccrued1 = myExercises.Salary1 / 30;
            myExercises.TotalAccrued1 = myExercises.TotalAccrued1 * myExercises.WorkedDays1;

            myExercises.TransportationAssistance1 = 117172 / 30;
            myExercises.TransportationAssistance1 = myExercises.TransportationAssistance1 * myExercises.WorkedDays1;

            myExercises.Health1 = myExercises.Health1 * 0.04;
            myExercises.Health1 = myExercises.TotalAccrued1 * 0.04;

            if (myExercises.Salary1 <= 2000000)
            {
                myExercises.TotalAccrued1 = myExercises.TotalAccrued1 + myExercises.TransportationAssistance1;
            }
            else
            {
                myExercises.TotalAccrued1 = myExercises.TotalAccrued1;
            }
        }

        public void Printdata()
        {
            StreamWriter write = File.AppendText("Payroll.txt");
            write.WriteLine($"FirtsName: {myExercises.FirtsName1}");
            write.WriteLine($"LastName: {myExercises.LastName1}");
            write.WriteLine($"Document: {myExercises.Document1}");
            write.WriteLine($"FirtsName: {myExercises.Salary1}");
            write.WriteLine($"WorkedDays1: {myExercises.WorkedDays1}");
            write.WriteLine($"Health: {myExercises.Health1}");
            write.WriteLine($"Pension: {myExercises.Pension1}");
            write.WriteLine($"TransportationAssistance: {myExercises.TransportationAssistance1}");
            write.Close();
        }
    }
}
