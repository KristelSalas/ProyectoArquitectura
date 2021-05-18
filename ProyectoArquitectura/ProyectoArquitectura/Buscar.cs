using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProyectoArquitectura
{
    class Buscar
    {
        public void BuscarMetacritic()
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
        }
        
    }
}
