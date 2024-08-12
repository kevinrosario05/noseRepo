using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserDriver;
using ACardWeb.ObjectRepository;
using System.Threading;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ACardWeb.Keywords
{
    public class LoginMethods
    {
        public static void IngresarUsuario(WebDriver driver)
        {
            Random rnd = new Random();

            string baseFija = "98422500";
            // Definir el contador inicial
            int contador = 14;
            Thread.Sleep(4000);
            driver.FindElement(LoginObjects.inputCode).Click();
            
            for (int i = 0; i < 3; i++)
            {
                string numeroAutoIncremental = baseFija + contador.ToString("D2");
                Thread.Sleep(4000);
                IWebElement inputElement = driver.FindElement(LoginObjects.inputCode);
                inputElement.Clear();
                inputElement.SendKeys(numeroAutoIncremental);
                contador++;
                Thread.Sleep(4000);
                driver.FindElement(LoginObjects.Button).Click();
                Thread.Sleep(4000);
                IWebElement extract = driver.FindElement(LoginObjects.NotFound);
                string extractedText = extract.Text;

                // Imprimir el texto extraído
                Console.WriteLine("Texto extraído: " + extractedText);
                if(extractedText == "User Not Found")
                {
                    driver.Navigate().GoToUrl(Profiles.QA.URL);
                }
                else
                {
                    List<string> textosExtraidos = new List<string>();
                    foreach (var elemento in numeroAutoIncremental)
                    {
                        string texto = elemento.ToString();
                        //textosExtraidos.Add(texto);
                        Console.WriteLine("Texto : " + texto);
                    }

                    // Imprimir los textos extraídos en la consola
                    foreach (var texto in textosExtraidos)
                    {
                        Console.WriteLine("Texto : " + texto);
                    }
                    driver.Navigate().GoToUrl(Profiles.QA.URL);
                }

            }

        }
    }
}
