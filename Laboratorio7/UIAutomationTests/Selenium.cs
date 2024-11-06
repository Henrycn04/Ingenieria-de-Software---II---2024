using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UIAutomationTests
{
    public class CountryCreationTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CreateCountryTest()
        {
            var baseURL = "http://localhost:8080";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(baseURL);

            var addCountryButton = _driver.FindElement(By.XPath("//button[contains(text(),'Agregar pais')]"));
            addCountryButton.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var countryNameInput = _driver.FindElement(By.Id("name"));
            string countryName = "Chile";
            countryNameInput.SendKeys(countryName);

            var continentSelect = _driver.FindElement(By.Id("continente"));
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(continentSelect);
            string continentName = "América";
            selectElement.SelectByText(continentName);

            var languageInput = _driver.FindElement(By.Id("idioma"));
            string language = "Español";
            languageInput.SendKeys(language);

            var submitButton = _driver.FindElement(By.XPath("//button[contains(text(),'Guardar')]"));
            submitButton.Click();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var lastRowName = _driver.FindElement(By.CssSelector("#list tr:last-child td:nth-child(1)")).Text;
            var lastRowContinent = _driver.FindElement(By.CssSelector("#list tr:last-child td:nth-child(2)")).Text;
            var lastRowLanguage = _driver.FindElement(By.CssSelector("#list tr:last-child td:nth-child(3)")).Text;

            Assert.AreEqual(countryName, lastRowName, "Chile");
            Assert.AreEqual(continentName, lastRowContinent, "América");
            Assert.AreEqual(language, lastRowLanguage, "Español");
        }

        [Test]
        public void EnterToListOfCountriesTest()
        {
            var URL = "http://localhost:8080/";

            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);
            Assert.IsNotNull(_driver);
        }
    }
}
