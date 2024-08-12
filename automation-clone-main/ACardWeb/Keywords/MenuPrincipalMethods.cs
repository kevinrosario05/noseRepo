using ACardWeb.ObjectRepository;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACardWeb.Keywords
{
    public class MenuPrincipalMethods
    {
        public static void IngresarUsuario(WebDriver driver, string value, string val)
        {
            Thread.Sleep(9000);


            driver.FindElement(MenuPrincipalObjects.x).Click();
            Thread.Sleep(4000);
            driver.FindElement(MenuPrincipalObjects.like).Click();
            Thread.Sleep(4000);
            driver.FindElement(MenuPrincipalObjects.inputUser).SendKeys(value);
            driver.FindElement(MenuPrincipalObjects.inputClave).SendKeys(val);
            Thread.Sleep(3000);
            driver.FindElement(MenuPrincipalObjects.buttonEntrar).Click();
            Thread.Sleep(6000);
            driver.FindElement(MenuPrincipalObjects.NotNow).Click();
            Thread.Sleep(4000);
            driver.FindElement(MenuPrincipalObjects.MeGusta).Click();
            Thread.Sleep(5000);
            driver.FindElement(MenuPrincipalObjects.comment).Click();
            Thread.Sleep(5000);
            Random rnd = new Random();
            List<string> correos = new List<string>() { "Ejemplo 3", " Ejemplo 1", "Ejemplo 2" };
            int correosIndex = rnd.Next(correos.Count);
            string correosrandom = Convert.ToString(correos[correosIndex]);
         //   driver.FindElement(LoginObjects.BuscarInput).SendKeys(correosrandom);
            driver.FindElement(MenuPrincipalObjects.comment).SendKeys(correosrandom);
            Thread.Sleep(3000);
            driver.FindElement(MenuPrincipalObjects.post).Click();

        }
    }
}
