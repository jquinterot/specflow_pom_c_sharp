using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowCrashCourse.Pages;

namespace SpecFlowCrashCourse.Actions
{
    public class HomeActions
    {
        public HomePage homePage;


        public HomeActions(IWebDriver driver) {
       
            this.homePage = new HomePage(driver);
        }

        public void SelectProduct(string product)
        {
            homePage.getProductByName(product).Click();
        }

        public void SelectCategory(string category)
        {
            homePage.getCategoryByName(category).Click();
        }

        public void DemoblazeTitleIsCorrect()
        {
            Assert.AreEqual("STORE", homePage.getTitle());
        }
    }
}
