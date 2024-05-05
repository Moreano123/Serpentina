using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo3
{
    public static class Algoritmo1
    {
        public static int mcd(int nro1, int nro2)
        {
            while (nro2 != 0)
            {
                int temp = nro2;
                nro2 = nro1 % nro2;
                nro1 = temp;
            }
            return nro1;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo para calcular el MCD de cuatro números");

            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            int num4 = int.Parse(Console.ReadLine());

            int mcd12 = mcd(num1, num2);
            int mcd123 = mcd(mcd12, num3);
            int Total = mcd(mcd123, num4);

            Console.WriteLine("El MCD de los cuatro números es: " + Total);
        }
    }

}