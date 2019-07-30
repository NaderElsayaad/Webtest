using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Methods;

namespace WebTest
{
    class Program
    {
        static void Main(string[] args)
        {
            public Elements El = new WebTest.Elements();
        }
        [SetUp]
        public void intialize()
        {

            
        }
        [Test]
        public void SearchTicket()
        {
           Methods.Start("https://www.fly365.com/");
           Methods.SendKeys(El.origin,ExcelLibrary.excelread(1, 2));
           Methods.SendKeys(El.destination,ExcelLibrary.excelread(2, 2));
           Methods.SendKeys(El.dtime,ExcelLibrary.excelread(3, 2));
           Methods.SendKeys(El.atime,ExcelLibrary.excelread(4, 2));
           Methods.Click(El.passengers);
           Methods.Clear(El.adult);
           Methods.SendKeys(El.adult,ExcelLibrary.excelread(5, 2));
           Methods.Clear(El.child);
           Methods.SendKeys(El.child,ExcelLibrary.excelread(6, 2));
           Methods.Clear(El.infant);
           Methods.SendKeys(El.infant,ExcelLibrary.excelread(7, 2));
           if(ExcelLibrary.excelread(8, 2)=="Economy")
           {
            Methods.Click(El.Economy);
           }
           else if(ExcelLibrary.excelread(8, 2)=="Premium")
           {
            Methods.Click(El.Premium);
           }

           else if(ExcelLibrary.excelread(8, 2)=="Business")
           {
            Methods.Click(El.Business);
           }
           else if(ExcelLibrary.excelread(8, 2)=="first")
           {
            Methods.Click(El.first);
           }
           Methods.Click(El.Search);
           if (Methods.driver.URL=="https://www.fly365.com/")
          {
          Assert.Pass();
           }
          else Assert.fail();
         
        }
        [Test]
        public void register()
        {
          Methods.Start("https://www.fly365.com/en/register");
          Methods.SendKeys(El.firstname,"Nader");
          Methods.SendKeys(El.lastname,"Elsayad");
          Methods.SendKeys(El.email,"Nader_elsayaad@outlook.com");
          Methods.SendKeys(El.password,"Nader123456");
          Methods.Click(EL.submit)
           if (Methods.driver.URL=="https://www.fly365.com/en/register")
          {
          Assert.Pass();
           }
          else Assert.fail();

         }
         [Test]
         public void contact()  
         { 
           Methods.Start("https://www.fly365.com/en/contact-us");
           Methods.SendKeys(C_firstname ,"Nader");
           Methods.SendKeys(C_email  ,"Nader.elsayaad@gmail.com");
           Methods.Select_DropDownMenu(El.category,"Other");
           Methods.SendKeys(El.Message,"Just testing");
           Methods.Click(El.send)
            if (El.thanks.Text == "Thank you for contacting us")
            {
                Assert.Pass();
            }
            else Assert.Fail();
          
            }

        [TearDown]
        public void cleanUp()
        {
            
        }
    }
}
