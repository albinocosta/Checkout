using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaçãoCSharp.Pages
{
    class PesquisaPage
    {
        private IWebDriver driver;

        public PesquisaPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private WebDriverWait Esperar()
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private By ContadorDeProduto()
        {
            return By.CssSelector("div[class=product-count]");
        }


        public Boolean ValidarResultadoDaPesquisa()
        {
            if (Esperar().Until(ExpectedConditions.ElementIsVisible(ContadorDeProduto())).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
