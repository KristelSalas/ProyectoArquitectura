using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProyectoArquitectura
{
    class Buscar
    {
        public String BuscarMetacritic(String nombre)
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                String url = "https://www.metacritic.com/search/all/";
                url += nombre+"/results";
                driver.Url = url; // abrir el navegador
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
                var primerRe = driver.FindElement(By.ClassName("main_stats"));//la clase en donde está
                var score = primerRe.FindElement(By.TagName("span")).Text;//entrar al tag
                driver.Quit(); //cierra el chrome
                return score;
            }          
        }
        
        public String BuscarPrecio1(String nombre)
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                String url = "https://store.steampowered.com/search/?term=";
                url += nombre;
                driver.Url = url;// abrir el navegador
                var cali1 = driver.FindElement(By.CssSelector(".col.search_price.responsive_secondrow")).Text;//la clase en donde está
                driver.Quit();
                return cali1;
            } 
        }

        public String BuscarPrecio2(String nombre)
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                String url = "https://www.humblebundle.com/store/search?sort=bestselling&search=";
                url += nombre;
                driver.Url = url;// abrir el navegador
                var precio = driver.FindElement(By.CssSelector(".price")).Text;
                driver.Quit();
                return precio;
            }      
        }

        public String BuscarTiempo(String nombre)
        {
            var options = new ChromeOptions();
            options.AddArguments("headless");
            using (IWebDriver driver = new ChromeDriver(options))
            {
                driver.Url = "https://howlongtobeat.com/#search";// abrir el navegador
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
                var busqueda2 = driver.FindElement(By.Name("q"));//localiza la caja e texto del navegador por el nombre de etiqueta
                busqueda2.SendKeys(nombre);//simula escribir en la caja de texto
                busqueda2.Submit();//realiza la busqueda 
                //var primer = driver.FindElement(By.ClassName("search_list_details"));
                var temp = driver.FindElement(By.ClassName("search_list_details_block"));
                var var1 = temp.FindElements(By.CssSelector(".search_list_tidbit.center.time_100"));
                driver.Quit();
                String resultados = var1.ToString();
                return resultados;
            }   
        }
    }
}
