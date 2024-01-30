using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCrashCourse.Pages
{
    public class ProductPage
    {
        IWebDriver driver;
        private WebDriverWait wait;
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

        public IWebElement getProductTitle()
        {
            IWebElement productTitleElement = wait.Until(driver => driver.FindElement(By.CssSelector("h2.name")));
            return productTitleElement;
        }

        public IWebElement getAddButton()
        {
            IWebElement addButtonElement = wait.Until(driver => driver.FindElement(By.CssSelector(".btn-success")));
            return addButtonElement;
        }
    }
}
