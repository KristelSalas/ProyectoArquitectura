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
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Url = "https://www.metacritic.com"; // abrir el navegador
                var busqueda2 = driver.FindElement(By.Name("search_term"));//localiza la caja e texto del navegador por el nombre de etiqueta
                busqueda2.SendKeys(nombre); //simula escribir en la caja de texto
                busqueda2.Submit(); //realiza la busqueda
                var primerRe = driver.FindElement(By.ClassName("main_stats"));//la clase en donde está
                var score = primerRe.FindElement(By.TagName("span"));//entrar al tag
                Console.WriteLine(nombre + " / " + score.Text);
                driver.Quit(); //cierra el chrome
            }          
        }
        
        public void BuscarPrecio1(String nombre)
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Url = "https://store.steampowered.com/?l=spanish";// abrir el navegador
                var busqueda2 = driver.FindElement(By.Name("term"));//localiza la caja e texto del navegador por el nombre de etiqueta
                busqueda2.SendKeys(nombre);//simula escribir en la caja de texto
                busqueda2.Submit();//realiza la busqueda
                var cali1 = driver.FindElement(By.CssSelector(".col.search_price.responsive_secondrow"));//la clase en donde está
                Console.WriteLine(nombre + " / " + cali1.Text);
                driver.Close();
            } 
        }

        public void BuscarPrecio2(String nombre)
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                String url = "https://www.humblebundle.com/store/search?sort=bestselling&search=";
                url += nombre;
                driver.Url = url;// abrir el navegador
                var precio = driver.FindElement(By.CssSelector(".price"));
                Console.WriteLine(nombre + " / "+ precio.Text);
            }      
        }


        public void BuscarTiempo(String nombre)
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Url = "https://howlongtobeat.com/";// abrir el navegador
                var busqueda2 = driver.FindElement(By.Name("q"));//localiza la caja e texto del navegador por el nombre de etiqueta
                busqueda2.SendKeys(nombre);//simula escribir en la caja de texto
                busqueda2.Submit();//realiza la busqueda 
                var temp = driver.FindElement(By.ClassName("search_list_details_block"));
                var var1 = temp.FindElements(By.CssSelector(".search_list_tidbit.center.time_100"));
                foreach (var item in var1)
                {
                    Console.WriteLine(nombre + "/" + item.Text);
                }
                driver.Close();
            }   
        }
    }
}
