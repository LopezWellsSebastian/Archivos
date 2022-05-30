using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //El archivo debe crearse bin/debug
            Console.WriteLine();

            try
            {


                //Uso de streamreader
                StreamReader sr = new StreamReader("EjemploDeArchivo.txt");
                string Line;

                while ((Line = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine(Line);//Pintar en consola el texto

                }
                sr.Close();
            }
            //Cerrar el archivo
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encontro el archivo");
            }
            Console.ReadKey();
        }
    }
}
