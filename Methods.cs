using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;

namespace WebTest
{
    public static class Methods
    {
        public static IWebDriver driver { get; set; }

        // Select browser type & Navigate to url Methode
        public static void Start(string url)
        {
            driver = new ChromeDriver();
           // driver = new FirefoxDriver();
            driver.Url = url;
        }
       // fill text box Methode
        public static void SendKeys(IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        //Click Methode
        public static void Click(IWebElement element)
        {
            element.Click();
        }
        //Select item for dropdown box
        public static void Select_DropDownMenu(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

    }
}
