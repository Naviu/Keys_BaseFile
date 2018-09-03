using Keys_Onboarding.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys_Onboarding.Pages
{
    public class TenantMyRequest
    {
        public TenantMyRequest()
        {
            PageFactory.InitElements(Global.Driver.driver, this);
        }
        //Define Tenant tab
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Tenanttab { set; get; }

        //Define MyRequest page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[3]")]
        private IWebElement MyRequesttab { set; get; }
        //add requesttab
         [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[2]/div/div[2]/a")]
        private IWebElement Addrequesttab { set; get; }
        //add select property
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/fieldset/div[2]/div[1]/div[1]/div[1]/div/i")]
        private IWebElement SelectProperty { set; get; }
        //add dropdown select
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/fieldset/div[2]/div[1]/div[1]/div[1]/div/div[2]/div")]
        private IWebElement SelectPropertydropdown { set; get; }
        //selectType
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/fieldset/div[2]/div[1]/div[1]/div[2]/div/i")]
        private IWebElement TypeDropDown { set; get; }
        //selecect general request
        [FindsBy(How = How.XPath, Using ="/html/body/div[2]/div/div/form/fieldset/div[2]/div[1]/div[1]/div[2]/div/div[2]/div[2]")]
        private IWebElement TypeOption { set; get; }
        //selecect message 
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/fieldset/div[2]/div[1]/div[2]/textarea")]
        private IWebElement Message { set; get; }
        //selecect savebutton
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/fieldset/div[2]/div[4]/button")]
        private IWebElement SaveButton { set; get; }
        //for verification to navigate to tenant page again
        //Define Tenant tab
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Tenanttab2 { set; get; }

        //Define MyRequest page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[3]")]
        private IWebElement MyRequesttab2 { set; get; }
        //Define search bar        
        [FindsBy(How = How.XPath, Using = "//*[@id='SearchBox']")]
        private IWebElement SearchBar { set; get; }

        //Define search button

        [FindsBy(How = How.XPath, Using = "//*[@id='icon - submitt']")]
        private IWebElement SearchButton { set; get; }





        public void Common_methods()
        {
            Global.Driver.wait(5);
            //Click on the Owners tab
            Tenanttab.Click();

            //Click MyRequest tab
            MyRequesttab.Click();
            //click add request tab
            Addrequesttab.Click();
            //click Select property 
            SelectProperty.Click();
            //select dropdown
            SelectPropertydropdown.Click();
            //Type dropdown
            TypeDropDown.Click();
            TypeOption.Click();
            Message.SendKeys("automate test for verification");
            SaveButton.Click();
            Tenanttab2.Click();
            MyRequesttab2.Click();
            //Enter the value in the search bar
            SearchBar.SendKeys("automate test for verification");
            Global.Driver.wait(5);

            //Click on the search button
            SearchButton.Click();

        }
        internal void TenantAddMyRequest()
        {
            try
            {
                //Calling the common methods
                Common_methods();
                Driver.wait(5);
                string ExpectedValue = "automate test for verification";
                string ActualValue = Global.Driver.driver.FindElement(By.XPath("//*[@id='SearchBox']")).Text;
                //Assert.AreEqual(ExpectedValue, ActualValue);
                if (ExpectedValue == ActualValue)

                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, Search successfull");

                else
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Search Unsuccessfull");
            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Search Unsuccessfull", e.Message);

            }
        }
    }
}
 