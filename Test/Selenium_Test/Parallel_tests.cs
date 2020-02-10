using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Automation_Testing
{
    [TestFixture]
    [Parallelizable]
    public class ParallelizableTest1
    {

        [Test]
        public void Chrome1()
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

    }


    [TestFixture]
    [Parallelizable]
    public class ParallelizableTest2
    {

        [Test]
        public void chrome2()
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

    }


    [TestFixture]
    [Parallelizable]
    public class ParallelizableTest3
    {

        [Test]
        public void chrome3()
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

    }

}