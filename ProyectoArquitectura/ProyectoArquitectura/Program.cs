using System;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProyectoArquitectura
{
    class Program
    {
        static void Main(string[] args)
        {
            Buscar meta = new Buscar();
            //meta.BuscarMetacritic();

            //meta.BuscarPrecio1();

            meta.BuscarTiempo();

            //string[] lines = File.ReadAllLines("Juegos.txt");//meter todo el archivo en un arreglo good good
            /*var sw = Stopwatch.StartNew();//iniciar el reloj feo
            Parallel.ForEach(lines, line => //el parallel foreach duh
            {
                meta.BuscarMetacritic(line);
                //Console.WriteLine(line);//escribe cada linea
            });
            Console.WriteLine("Ciclo paralelo: " + sw.Elapsed.TotalSeconds);//da el tiempo*/


            /*foreach (string line in lines) 
            { 
                meta.BuscarMetacritic(line); 
            }*/




            /*Parallel.Invoke(
            () =>
            {
                leerJuegos();
            },
            () =>
            {
                Console.WriteLine("Hola esto es una prueba");
            },
            () =>
            {
                Console.WriteLine("Hola la segunda prueba");
            }
            );*/

            //Lo de la pagina web
            //string html = "<html><head> <tittle> Resultados Juegos </tittle></head><body><table><tr><th> Nombre</th><td></td></tr><tr><th> Calificación</th><td></td></tr><tr><th> Precioen Steam</th><td></td></tr><tr><th> Precio en G2a</th><td></td></tr><tr><th> Tiempo para completar</th><td></td></tr></table></body></html>";

            //File.WriteAllText("PaginaWeb.html", html);

            //var proc = Process.Start(@"cmd.exe ", @"/c PaginaWeb.html");
            
        }
        
    }
}

