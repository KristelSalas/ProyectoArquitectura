using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProyectoArquitectura
{
    class Buscar
    {
        public void BuscarMetacritic(String nombre)
        {
            IWebDriver driver = new ChromeDriver();
            //var ventana = driver.Manage().Window;
            //ventana.Minimize(); // minimiza la ventana de chrome
            driver.Url = "https://www.metacritic.com";// abrir el navegador
            var busqueda2 = driver.FindElement(By.Name("search_term"));//localiza la caja e texto del navegador por el nombre de etiqueta
            busqueda2.SendKeys(nombre);//simula escribir en la caja de texto
            busqueda2.Submit();//realiza la busqueda

            var primerRe = driver.FindElement(By.ClassName("main_stats"));//la clase en donde está
            var score = primerRe.FindElement(By.TagName("span"));//entrar al tag
            Console.WriteLine(nombre + " / "+ score.Text);
            driver.Close(); //cierra el chrome
        }

        public void BuscarPrecio1(String nombre)
        {
            IWebDriver driver = new ChromeDriver();
            //var ventana = driver.Manage().Window;
            //ventana.Minimize(); // minimiza la ventana de chrome
            driver.Url = "https://store.steampowered.com/?l=spanish";// abrir el navegador
            var busqueda2 = driver.FindElement(By.Name("term"));//localiza la caja e texto del navegador por el nombre de etiqueta
            busqueda2.SendKeys(nombre);//simula escribir en la caja de texto
            busqueda2.Submit();//realiza la busqueda

            var cali1 = driver.FindElement(By.CssSelector(".col.search_price.responsive_secondrow"));//la clase en donde está
            Console.WriteLine(nombre + " / " + cali1.Text);
            driver.Close();
        }

        public void BuscarPrecio2()
        {

        }

        public void BuscarTiempo()
        {
            IWebDriver driver = new ChromeDriver();
            //var ventana = driver.Manage().Window;
            //ventana.Minimize(); // minimiza la ventana de chrome
            driver.Url = "https://howlongtobeat.com/";// abrir el navegador
            var busqueda2 = driver.FindElement(By.Name("q"));//localiza la caja e texto del navegador por el nombre de etiqueta
            busqueda2.SendKeys("BioShock");//simula escribir en la caja de texto
            busqueda2.Submit();//realiza la busqueda 

            ///var temp1 = driver.FindElement(By.CssSelector(".search_list_tidbit.center time_100"));//la clase en donde está
            //Console.WriteLine("Hola diosito soy yo de nuevo" + " / " + temp1.Text);
        }


        //esto sirve de jemplo para ver masomenos cómo funciona xd
        /*public void BuscarMetacritic()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");// abrir el navegador

            var busqueda = driver.FindElement(By.Name("q"));//localiza la caja e texto del navegador por el nombre de etiqueta
            busqueda.SendKeys("meta score");//simula escribir en la caja de texto
            busqueda.Submit();//realiza la busqueda

            var primerRe = driver.FindElement(By.ClassName("yuRUbf"));//la clase en donde está
            var link = primerRe.FindElement(By.TagName("a"));//entrar al tag
            driver.Navigate().GoToUrl(link.GetAttribute("href"));//usar la direccion url

            var busqueda2 = driver.FindElement(By.Name("search_term"));//localiza la caja e texto del navegador por el nombre de etiqueta
            busqueda2.SendKeys("halo infinite");//simula escribir en la caja de texto
            busqueda2.Submit();//realiza la busqueda
        }*/

    }
}
