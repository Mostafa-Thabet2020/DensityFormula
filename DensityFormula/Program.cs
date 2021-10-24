using System;

namespace DensityFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Density Formula");
            Console.WriteLine("The density of material shows \n the denseness of it in a specific given area.");
            // output
            Console.WriteLine("Mass of the body: ");
            //input
            decimal m = Convert.ToDecimal(Console.ReadLine());

            //output
            Console.WriteLine("The volume of the body: ");
            //input
            decimal v = Convert.ToDecimal(Console.ReadLine());

            //Equation
            decimal p = m / v;
            //result output 
            Console.WriteLine("Density: "+p+" g/cm3");
            
            Console.ReadLine();
        }
    }
}
