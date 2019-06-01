using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestamos
{
    class Program
    {
        public double N { get; }

        static void Main(string[] args)
        {
            double capital, interes, plazo, pago, mensualidad;

            Console.WriteLine("Bienbenido! \n ");

            Console.WriteLine("Digite la cantidad de su prestamo");
            capital = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la taza de interes ");
            interes = (Double.Parse(Console.ReadLine())/ 12) ;

            Console.WriteLine("Digite el plazo de su prestamo (En años)");
            plazo = Double.Parse(Console.ReadLine())*12;


            pago = capital * (interes / (1- Math.Pow((1 + interes), (plazo*-1))));



            Console.WriteLine(pago);

            double interesM, pagoM;

            double brutoM = capital / plazo;
           // pagoM = brutoM * (interes / (1 - Math.Pow((1 + interes), (plazo * -1))));

            for (double i = 1; i < plazo; i++)
            {
                
            } 

            Console.ReadLine();

            
            
            double residuo = capital - brutoM;

        }
        public formula(double i, double a, double n) {

            double pagoM = a * (i / (1 - Math.Pow((1 + i), (n * -1))));

            return pagoM;
            N = n;
        }
       
        
    }
}
