using Keys_Onboarding.Global;
using Keys_Onboarding.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys_Onboarding.Test
{
    class Sprint 
    {
      [TestFixture]
      [Category("Sprint1")]
       class Tenant : Base
       {
        
            [Test]
            public void PO_AddNewProperty()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Search for a Property");               

                // Create an class and object to call the method
                PropertyOwner obj = new PropertyOwner();
                obj.SearchAProperty();

            }
            [Test]
            public void Po_AddMyRequest()
            {
                test = extent.StartTest("Add My Request");
                MyRequest obj = new MyRequest();
                obj.AddMyRequest();
            }
            [Test]
            public void Po_TenantAddMyRequest()
            {
                test = extent.StartTest("Add My Request");
                TenantMyRequest obj = new TenantMyRequest();
                obj.TenantAddMyRequest();
            }
            [Test]
            public void Po_AddQuote()
            {
                test = extent.StartTest("Add My quote");
                MarketPlace obj = new MarketPlace();
                obj.AddQuote();


            }


        }
    }
}
