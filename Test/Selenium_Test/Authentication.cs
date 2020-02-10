using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Automation_Testing
{
    [TestFixture]
    public class Authentication
    {
        [Test]
        public void clickFieldsUserAuthenticationChrome()
        {
            IWebDriver driver;
            WebDriverWait wait;
            try
            {
                driver = new ChromeDriver();

                //navega a la url de la pagina de prueba  
                driver.Navigate().GoToUrl("C:\\Users\\Dachury\\Documents\\Proyecto.net\\Automation_Testing\\web\\login.html");
                //Maximiza  la ventana del navegador
                //driver.Manage().Window.Maximize();
                //Declara los elementos y busca por identificador en el html
                IWebElement textUsername = driver.FindElement(By.Id("uname1"));
                IWebElement textPass = driver.FindElement(By.Id("pwd1"));

                //Ingresa valores predeterminados para la prueba
                textUsername.SendKeys("Daniel");
                textPass.SendKeys("SuperSecret");

                //Se da click en el boton de login
                IWebElement clickBoton = driver.FindElement(By.XPath("//*[@id='btnLogin']"));

                //Se configura un tiempo al navegador
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                clickBoton.Click();
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException("Element not Found", e);
            }

            driver.Close();
            driver.Quit();

        }


        [Test]
        public void clickFieldsUserAuthenticationFireFox()
        {
            IWebDriver driverFirefox;
            WebDriverWait wait;

            try
            {
                driverFirefox = new FirefoxDriver();
                //navega a la url de la pagina de prueba  
                driverFirefox.Navigate().Refresh();
                driverFirefox.Navigate().GoToUrl("https://es-la.facebook.com/");
                //Maximiza  la ventana del navegador
                // driver.Manage().Window.Maximize();
                //Declara los elementos y busca por identificador en el html
                IWebElement textUsername = driverFirefox.FindElement(By.Id("email"));
                IWebElement textPass = driverFirefox.FindElement(By.Id("pass"));

                //Ingresa valores predeterminados para la prueba
                textUsername.SendKeys("Daniel");
                textPass.SendKeys("SuperSecret");

                //Se da click en el boton de login
                IWebElement clickBoton = driverFirefox.FindElement(By.XPath("//*[@id='u_0_b']"));

                //Se configura un tiempo al navegador
                wait = new WebDriverWait(driverFirefox, TimeSpan.FromSeconds(60));
                clickBoton.Click();

                driverFirefox.Close();
                driverFirefox.Quit();
            }
            catch (Exception e)
            {
                throw new DriverServiceNotFoundException("Element not Found", e);
            }



        }
    }
}