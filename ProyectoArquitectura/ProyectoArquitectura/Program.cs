using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProyectoArquitectura
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Juegos.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {                   
                    Console.WriteLine(line); //write the line to console window                  
                    line = sr.ReadLine(); //Read the next line
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }


}

