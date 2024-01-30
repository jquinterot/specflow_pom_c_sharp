using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowCrashCourse.Pages;

namespace SpecFlowCrashCourse.Actions
{
    public class ProductActions
    {
        public ProductPage productPage;


        public ProductActions(IWebDriver driver)
        {
            this.productPage = new ProductPage(driver);
        }

        public void CheckProductTitleisCorrect(string product)
        {
           string productTitle = productPage.getProductTitle().Text;
            Assert.AreEqual(productTitle, product);
        }

        public void SelectAddButton()
        {
            productPage.getAddButton().Click();
        }
    }
}
