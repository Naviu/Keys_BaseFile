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
            Description.SendKeys("new automated description");
            //click savebutton
            SaveButton.Click();

        }
        internal void AddMyRequest()
        {
            //Calling the common methods
            Common_methods();
            Driver.wait(5);
        }

    }
}
