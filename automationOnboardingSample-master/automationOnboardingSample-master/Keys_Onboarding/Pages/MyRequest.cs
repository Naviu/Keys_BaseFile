using Keys_Onboarding.Global;
using NUnit.Core;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using RelevantCodes.ExtentReports.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Keys_Onboarding.Global.CommonMethods;
using static System.Net.Mime.MediaTypeNames;

namespace Keys_Onboarding.Pages
{
    public class MyRequest
    {
        //created constructor
        public MyRequest()
        {
            PageFactory.InitElements(Global.Driver.driver, this);

        }
        //Define Owners tab
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Ownertab { set; get; }

        //Define MyRequest page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[6]")]
        private IWebElement MyRequesttab { set; get; }

        //Define AddRequest
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/div[2]/div/div[2]/a")]
        private IWebElement AddRequesttab { set; get; }

        //Define duedate
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/form/fieldset/div[1]/div[2]/div[1]/div[3]/input")]
        private IWebElement DueDate { set; get; }

        //Define Description
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/form/fieldset/div[1]/div[2]/div[2]/div/textarea")]
        private IWebElement Description { set; get; }

        //Define Savebutton
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/form/fieldset/div[4]/button")]
        private IWebElement SaveButton { set; get; }

        //to get the screen shot navigathing to my requests page again
        //Define Owners tab
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Ownertab2 { set; get; }

        //Define MyRequest page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[6]")]
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
            Ownertab.Click();

            //Click MyRequest tab
            MyRequesttab.Click();

            // CLick AddRequest tab
            AddRequesttab.Click();

            // CLick Duedate tab
            DueDate.Click();

            //send keys Description
            Description.SendKeys(ExcelLib.ReadData(3, "TestData"));
            //click savebutton
            SaveButton.Click();
            //click owner again
            Ownertab2.Click();
            //My Request again
            MyRequesttab2.Click();
            //Enter the value in the search bar
            SearchBar.SendKeys("Added for verification");
            Global.Driver.wait(5);

            //Click on the search button
            SearchButton.Click();

        }
        internal void AddMyRequest()
        {
            try
            {
                //Calling the common methods
                Common_methods();
                Driver.wait(5);
                string ExpectedValue = "Added for verification";
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