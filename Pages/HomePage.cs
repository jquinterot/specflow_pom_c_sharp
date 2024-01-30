using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowCrashCourse.Pages
{
    public class HomePage
    {
        IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }


        public IWebElement getProductByName(string product)
        {
            string productLink = $"//*[@class='card-title'][contains(.,'{product}')]";
            IWebElement productElement =  wait.Until(driver => driver.FindElement(By.XPath(productLink)));
            return productElement;
        }

        public IWebElement getCategoryByName(string category)
        {
            string categoryLink = $"//*[@id='itemc'][contains(.,'{category}')]";
            IWebElement categoryLinkElement = wait.Until(driver => driver.FindElement(By.XPath(categoryLink)));
            return categoryLinkElement;
        }
    }
}
