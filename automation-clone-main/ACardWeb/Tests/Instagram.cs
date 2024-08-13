using ACardWeb.Keywords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace ACardWeb.Tests
{
    [TestClass]
    public class instagram : BrowserDriver.DriverHelper
    {
        string ciudadrandom;
        string sector;
        [TestMethod ("Iniciar sesion con las credenciales correctas")]

        public void IniciarSesion()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);

            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(Profiles.QA.URL);

            LoginMethods.IngresarUsuario(driver);

            // MenuPrincipalMethods.IngresarUsuario(driver, Profiles.QA.Usuario, Profiles.QA.Clave);

            //Validaciones
        }
        /*(   [TestMethod("Iniciar sesion con las credenciales incorrectas")]
           public void IniciarSesion_CredencialesInorrectas()
           {
               Iniciar("CHROME");
               LoginMethods.IngresarUsuario(driver, Profiles.QA.Usuario);
               LoginMethods.IngresarClave(driver, "asasas");
               LoginMethods.PresionarEntrar(driver);
               //Validaciones
           } */
    }
}
