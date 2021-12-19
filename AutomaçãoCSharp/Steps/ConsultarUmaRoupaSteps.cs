using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomaçãoCSharp.Steps
{
    [Binding]
    public class ConsultarUmaRoupaSteps
    {

        string url = "http://automationpractice.com/index.php";
        IWebDriver driver;
        Pages.PesquisaPage pesquisa;
        Pages.HomePage home;

        [Given(@"eu acesse o site My Store")]
        public void DadoEuAcesseOSiteMyStore()
        {
            //Iniciando as classes
            driver = Util.Util.IniciarDriver();
            home = new Pages.HomePage(driver);
            pesquisa = new Pages.PesquisaPage(driver);

            //Acessar o site
            home.AessarSite(url);
        }
        
        [When(@"eu desejar procurar uma camiseta")]
        public void QuandoEuDesejarProcurarUmaCamiseta()
        {
            //consultar item
            home.Consultar("dresses");
        }
        
        [Then(@"o site me retorna as camisetas disponíveis")]
        public void EntaoOSiteMeRetornaAsCamisetasDisponiveis()
        {
            //retorno de itens
            pesquisa.ValidarResultadoDaPesquisa();
            Util.Util.FinalizarDriver(driver);
        }
    }
}
