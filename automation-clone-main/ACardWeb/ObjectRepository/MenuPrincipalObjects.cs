using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACardWeb.ObjectRepository
{
    public class MenuPrincipalObjects
    {
       
        public static By inputUser = By.XPath("//*[@id='loginForm']/div/div[1]/div/label/input");
        public static By inputClave = By.XPath("//*[@id='loginForm']/div/div[2]/div/label/input");
        public static By buttonEntrar = By.XPath("//*[@id='loginForm']/div/div[3]/button/div");
        public static By buscador = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[1]/div/div/div/div/div[2]/div[2]/span/div/a/div");
        public static By buscadorImput = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[1]/div/div/div[2]/div/div/div[2]/div/div/div[1]/div/div/input");
        public static By perfil = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[1]/div/div/div[2]/div/div/div[2]/div/div/div[2]/div/a[1]/div[1]/div/div/div[2]/div/div");
        public static By post = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div[1]/div/div[2]/div/div[4]/section/div/form/div/div[2]");       
        public static By comment = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div[1]/div/div[2]/div/div[4]/section/div/form/div/textarea");
        public static By enviarComent = By.XPath("/html/body/div[7]/div[1]/div/div[3]/div/div/div/div/div[2]/div/article/div/div[2]/div/div/div[2]/section[3]/div/form/div/div[2]/div");
        public static By like = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/div[1]/div[1]/article/div/div[2]/div/div[2]/section[1]/span[1]/div");
        public static By MeGusta = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div[1]/div/div[2]/div/div[3]/div[1]/div[1]/span[1]/div/div");
        
        public static By NotNow = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div/div");
        public static By x = By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/nav/div[2]/div/div/div[2]/div/div/div[1]/div/button");
        
    }
}
