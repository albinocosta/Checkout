using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaçãoCSharp.Pages
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AessarSite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        private IWebElement Busca()
        {
            return driver.FindElement(By.Id("search_query_top"));
        }

        private IWebElement Pesquisar()
        {
            return driver.FindElement(By.CssSelector("button[name=submit_search]"));
        }


        public void Consultar(string item)
        {
            //preencher campo de pesquisa
            Busca().SendKeys(item);

            //clicar no botão lupa para pesquisar
            Pesquisar().Click();
        }


    }
}
