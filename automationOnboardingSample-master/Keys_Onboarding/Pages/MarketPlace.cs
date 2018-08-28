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
    public class MarketPlace
    {
        public MarketPlace()
        {
            PageFactory.InitElements(Global.Driver.driver, this);

        }
        //Define ServiceSupplier
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement ServiceSupplier { set; get; }
        //Define MyQuote
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[1]")]  
        private IWebElement MyQuote { set; get; }
//Define MyEdit
[FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/table/tbody/tr[1]/td[5]/button[2]")] 
        private IWebElement EditButton { set; get; }
        //Define note text
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[4]/div[2]/form/fieldset/div[1]/div[3]/textarea")]
        private IWebElement Text { set; get; }

        //Define note enter
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[4]/div[2]/form/fieldset/div[1]/div[3]/textarea")]
        private IWebElement Text2 { set; get; }
        //Define savebutton
        [FindsBy(How = How.XPath, Using = "//*[@id='saveButton']")]
        private IWebElement SaveButton { set; get; }


        public void Common_methods()
        {
            Global.Driver.wait(5);
            //Click on the Owners tab
            ServiceSupplier.Click();
            //click MyQuote
            MyQuote.Click();
            //Edit
            EditButton.Click();
            //Text
            Text.Clear();
            //enter in text
            Text2.SendKeys("Automating it again 12345");
            SaveButton.Click();
        }

        internal void AddQuote()
        {
            //Calling the common methods
            Common_methods();
            Driver.wait(5);
        }



    }
}
   