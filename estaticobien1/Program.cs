using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estaticobien1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematicas matematicas = new Matematicas();
            double sumando1 = 10;
            double sumando2 = 43;
            double resultado = Matematicas.sumar(sumando1, sumando2);

            Console.WriteLine("PI:" + Matematicas.PI);
            Console.WriteLine("PI:" + Matematicas.PI);

            Console.WriteLine(sumando1.ToString() + " + " + sumando2.ToString() + " = " + resultado.ToString());
            Console.Read();


        }
    }
}
