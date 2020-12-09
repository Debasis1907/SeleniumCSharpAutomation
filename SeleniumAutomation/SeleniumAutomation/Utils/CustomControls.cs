using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAutomation.Utils
{
    public class CustomControls: DriverHelper
    {
        public static void comboBox(string controlName,string value)
        {
            IWebElement comboControl = Driver.FindElement(By.Id($"{controlName}-awed"));
            comboControl.Clear();
            comboControl.SendKeys("Almond");
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']/div/ul/li[text()='{value}']")).Click();
        }
    }
}
