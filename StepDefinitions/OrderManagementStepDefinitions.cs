
using OpenQA.Selenium;
using SpecFlowCrashCourse.Actions;

namespace SpecFlowCrashCourse.StepDefinitions
{
    [Binding]
    public sealed class OrderManagementStepDefinitions
    {
        private IWebDriver driver;
        private HomeActions homeActions;
        private ProductActions productActions;
        public OrderManagementStepDefinitions(IWebDriver driver) {
        //This catch the instance from the object located in Hooks
            this.driver = driver;
            this.homeActions = new HomeActions(driver);
            this.productActions = new ProductActions(driver);
        }

        [Given(@"the user visits Demoblaze page")]
        public void GivenUserVisitsDemoblazePage()
        {
            homeActions.DemoblazeTitleIsCorrect();
         }

        [When(@"selects (.*) category")]
        public void WhenSelectsPhoneCategory(string category)
        {
            homeActions.SelectCategory(category);

        }

        [When(@"selects (.*) product")]
        public void WhenSlectsProduct(string product)
        {
            homeActions.SelectProduct(product);
        }

        [Then(@"(.*) is displayed in product summary page")]
        public void ThenProductIsDisplayedInSummaryPage(string product)
        {
            productActions.CheckProductTitleisCorrect(product);
        }

        [When(@"adds the product to the cart")]
        public void WhenAddsProductToCart()
        {
            productActions.SelectAddButton();
        }
    }
}
