using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExcepciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*******************Objetos************************************************
            SinControl sc1 = new SinControl();
            ConControl cc1 = new ConControl();
            ConControlGenerico cg1 = new ConControlGenerico();

            
            //*******************No Genericos*******************************************
            //sc1.DivideByZeroException(5,5);
            //sc1.DivideByZeroException(5,0);
            //cc1.DivideByZeroException(5,0);
            //Console.WriteLine("");

            //sc1.IndexOutOfRangeException(0);
            //sc1.IndexOutOfRangeException(3);
            //cc1.IndexOutOfRangeException(3);
            //Console.WriteLine("");

            //sc1.NullReferenceException("hola");
            //sc1.NullReferenceException(null);
            //cc1.NullReferenceException(null);
            //Console.WriteLine("");

            //sc1.FormatException("5");
            //sc1.FormatException("hola");
            //cc1.FormatException("hola");
            //Console.WriteLine("");

            //sc1.IOException("archivo.txt");
            //sc1.IOException("archivo2.txt");
            //cc1.IOException("archivo2.txt");
            //Console.WriteLine("");

            //sc1.OverFlowException(5);
            //sc1.OverFlowException(int.MaxValue);
            //cc1.OverFlowException(int.MaxValue);
            //Console.WriteLine("");

            
            //*******************Genericos**********************************************
            //Console.WriteLine("\nIngrese un ividendo y luego un divisor");
            //cg1.NumeroNatural(Console.ReadLine(),Console.ReadLine());
            //Console.WriteLine("");

            //cg1.IOExceptionDos("archivo.txt");
        }
    }
}


