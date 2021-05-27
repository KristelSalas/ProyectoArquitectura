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
            string[] lines = File.ReadAllLines("Juegos.txt"); //meter todo el archivo en un arreglo 
            String Inicio = "<Html><Head><style>th{padding:9px;background-color:rgb(117, 163, 165);border:3px solid rgb(117,163,165)}td{border:3px solid rgb(117,163,165);padding:13px;background-color:rgb(235,241,241)}table{width:20%;height:100px;border-collapse:separate;border-spacing:2px 2px}body{background-color:rgb(253, 252, 252)}</style><title>Busqueda Juegos</title><h2 align='center'>Resultados Videojuegos</h2></Head><body>";
            File.WriteAllText("PaginaWeb.html", Inicio);
            foreach (string line in lines) 
            {
                String nombre = line;
                Parallel.Invoke(
                () =>
                {
                    String nota = meta.BuscarMetacritic(line);
                    LlenarHtml(nombre,nota);        
                },
                () =>
                {
                    String precio1 = meta.BuscarPrecio1(line);
                    String precio2 = meta.BuscarPrecio2(line);
                    LlenarPrecios(precio1,precio2);              
                },
                () =>
                {
                    //String tiempo = meta.BuscarTiempo(line);
                    //LlenarHtml2(tiempo);
                }
                );
                String cerrarTabla = "</table>";
                File.AppendAllLines("PaginaWeb.html", new String[] { cerrarTabla });
            }
            String Final = "</body></Html>";
            File.AppendAllLines("PaginaWeb.html", new String[] { Final });

            var proc = Process.Start(@"cmd.exe ", @"/c PaginaWeb.html"); // Iniciar la página
        }

        public static void LlenarHtml(String nom, String cali)
        {
            String relleno = "<table align='left'><tr><tr align='center'><th colspan='2'>" + nom + "</th></tr><tr align='center'><th>Calificación Metacritic</th><td>" + cali + "</td></tr>";
            File.AppendAllLines("PaginaWeb.html", new String[] { relleno });
        }

        public static void LlenarPrecios(String pre1, String pre2)
        {
            String Relleno = "<tr align='center'><th>Precio en Steam</th><td>" + pre1 + "</td></tr><tr align='center'><th>Precio en HumbleBundle</th><td>" + pre2 + "</td></tr>";
            File.AppendAllLines("PaginaWeb.html", new String[] { Relleno });
        }
        public static void LlenarHtml2(String temp)
        {
            String Relleno = "<tr align='center'><th>Duracion Historia Principal</th><td>" + temp + "</td></tr>";
            File.AppendAllLines("PaginaWeb.html", new String[] { Relleno });
        }
    }
}

