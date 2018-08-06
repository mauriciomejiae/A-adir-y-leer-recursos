using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //LIbreria I and Output
namespace Añadir_y_leer_recursos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TextWriter texto = new StreamWriter("prueba.txt");
            texto.WriteLine("Hola mundo");
            texto.Close(); */

            //Añadir texto
            StreamWriter texto = File.AppendText("prueba.txt");
            texto.WriteLine("Hola mundito");
            texto.Close();


            //Leer texto
            TextReader texto2 = new StreamReader("prueba.txt");
            Console.WriteLine(texto2.ReadLine());
            texto2.Close();
            Console.ReadKey();
        }
    }
}

