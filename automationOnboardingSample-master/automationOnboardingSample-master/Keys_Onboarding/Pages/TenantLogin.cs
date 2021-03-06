﻿using Keys_Onboarding.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Keys_Onboarding.Global.CommonMethods;

namespace Keys_Onboarding.Pages
{
    internal class TenantLogin
    {
        public TenantLogin()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        #region  Initialize Web Elements 
        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        private IWebElement Email { get; set; }

        // Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement PassWord { get; set; }

        // Finding the Login Button
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div/form/div[1]/div[4]/button")]
        private IWebElement loginButton { get; set; }

        // Finding the popupmyprops
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div[1]/div/div[2]/div/a[1]")]
        private IWebElement PopUp { get; set; }


        ////skipbutton
        //[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[3]")] 
        //public IWebElement NextButton { get; set; }  


        ////skipbutton
        //[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        //public IWebElement SkipButton { get; set; }
        #endregion

        internal void LoginSuccessfull()
        {
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "LoginPage");

            // Navigating to Login page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(3, "Url"));

            // Sending the username 
            Email.SendKeys(ExcelLib.ReadData(3, "Email"));

            // Sending the password
            PassWord.SendKeys(ExcelLib.ReadData(3, "Password"));

            // Clicking on the login button
            loginButton.Click();
            PopUp.Click();
            //clicking on skipbutton
            //NextButton.Click();
            //SkipButton.Click();
        }
    }
}
    
