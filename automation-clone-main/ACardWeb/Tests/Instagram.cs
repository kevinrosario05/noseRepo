using ACardWeb.Keywords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Iniciar("CHROME");
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
