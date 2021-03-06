using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomation.Utils;
using System;

namespace SeleniumAutomation
{
    public class Tests:DriverHelper
    {
        

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("SetUp");
            Driver = new ChromeDriver();
            
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1");
            Driver.Url = "https://demowf.aspnetawesome.com/";
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            CustomControls.comboBox("ContentPlaceHolder1_AllMealsCombo","Almond");
            Driver.Close();
        }
    }
}