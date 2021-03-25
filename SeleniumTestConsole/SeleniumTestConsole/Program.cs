using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//using System;
//using System;


namespace SeleniumTestConsole
{
    class Program
    {
       //public IWebDriver driver;
        static void Main(string[] args)
        {
            //Sample1 sample1 = new Sample1();
            //sample1.Initialize();
            //sample1.ExecuteTest();
            IWebDriver driver;
            Console.Write("test case started ");
            //create the reference for the browser  
            

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");
            options.AddArgument("--disable-extensions");
            options.AddArgument("--test-type");
            options.AddArgument("--log-level=3");
            options.AddArgument("--incognito");
            options.AddArgument("disable-infobars");

            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(Environment.CurrentDirectory);
            chromeDriverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(chromeDriverService, options);
           
            driver.Manage().Window.Maximize();
            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(2000);
            // identify the Google search text box  
            IWebElement ele = driver.FindElement(By.Name("q"));
            //enter the value in the google search text box  
            ele.SendKeys("javatpoint tutorials");
            Thread.Sleep(2000);
            //identify the google search button  
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            // click on the Google search button  
            ele1.Click();
            Thread.Sleep(3000);
            //close the browser  
            driver.Close();
            Console.Write("test case ended ");
        }
    }
}