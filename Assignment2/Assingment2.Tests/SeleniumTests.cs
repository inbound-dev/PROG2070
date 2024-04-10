﻿using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Assingment2.Tests
{
    internal class SeleniumTest1
    {
        [Test]
        public void PageName_PageName()
        {
            //creates a new instance of chrome using the selenium chrome driver and then navigates to the calculator app
            IWebDriver driver =  new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/salary-calculator.html");

            //tests if the page name is correct
            ClassicAssert.That(driver.Title, Is.EqualTo("Salary Calculator"));

            //close the driver when done
            driver.Quit();
        }
    }

    internal class SeleniumTest2
    {
        [Test]
        public void VailidInputTest_ValidOutput()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/salary-calculator.html");
            
            //finds all input fields and then tests the program
            IWebElement hourlyRate = driver.FindElement(By.Id("camount"));
            IWebElement hoursPerWeek = driver.FindElement(By.Id("chours"));
            IWebElement daysPerWeek = driver.FindElement(By.Id("cdays"));
            IWebElement vacationDaysPerYear = driver.FindElement(By.Id("cvacation"));
            IWebElement holidaysPerYear = driver.FindElement(By.Id("cholidays"));

            hourlyRate.Clear();
            hoursPerWeek.Clear();
            daysPerWeek.Clear();
            vacationDaysPerYear.Clear();
            holidaysPerYear.Clear();

            hourlyRate.SendKeys("14");
            hoursPerWeek.SendKeys("56");
            daysPerWeek.SendKeys("7");
            vacationDaysPerYear.SendKeys("0");
            holidaysPerYear.SendKeys("0");

            IWebElement submitBtn = driver.FindElement(By.Name("x"));
            submitBtn.Click();

            IWebElement outputTable = driver.FindElement(By.ClassName("cinfoT"));

            //checks to see if the program ran sucsessfully
            ClassicAssert.That(outputTable, !Is.Null);

            driver.Quit();
        }
    }

    internal class SeleniumTest3 {
        [Test]
        public void InvalidHoursInput_OutputError()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/salary-calculator.html");

            //finds all input fields and then tests the program
            IWebElement hourlyRate = driver.FindElement(By.Id("camount"));
            IWebElement hoursPerWeek = driver.FindElement(By.Id("chours"));
            IWebElement daysPerWeek = driver.FindElement(By.Id("cdays"));
            IWebElement vacationDaysPerYear = driver.FindElement(By.Id("cvacation"));
            IWebElement holidaysPerYear = driver.FindElement(By.Id("cholidays"));

            hourlyRate.Clear();
            hoursPerWeek.Clear();
            daysPerWeek.Clear();
            vacationDaysPerYear.Clear();
            holidaysPerYear.Clear();

            hourlyRate.SendKeys("14");
            hoursPerWeek.SendKeys("0");
            daysPerWeek.SendKeys("7");
            vacationDaysPerYear.SendKeys("0");
            holidaysPerYear.SendKeys("0");

            IWebElement submitBtn = driver.FindElement(By.Name("x"));
            submitBtn.Click();

           // XPathExpression xpath = //*[@id="content"]/div[3]/div[2]/div/font;

            //this is the line i could never get to work
            String output = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div[2]/div/font")).GetAttribute("innerText");

            Console.WriteLine(output);

            //checks to see if the program ran sucsessfully
            Assert.That(output, Is.EqualTo("Please provide a positive hours per week value."));

            driver.Quit();
        } 
     }

    internal class SeleniumTest4
    {
        [Test]
        public void InvalidHourlyRate_OutputError()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/salary-calculator.html");

            //finds all input fields and then tests the program
            IWebElement hourlyRate = driver.FindElement(By.Id("camount"));
            IWebElement hoursPerWeek = driver.FindElement(By.Id("chours"));
            IWebElement daysPerWeek = driver.FindElement(By.Id("cdays"));
            IWebElement vacationDaysPerYear = driver.FindElement(By.Id("cvacation"));
            IWebElement holidaysPerYear = driver.FindElement(By.Id("cholidays"));

            hourlyRate.Clear();
            hoursPerWeek.Clear();
            daysPerWeek.Clear();
            vacationDaysPerYear.Clear();
            holidaysPerYear.Clear();

            hourlyRate.SendKeys("-1");
            hoursPerWeek.SendKeys("5");
            daysPerWeek.SendKeys("7");
            vacationDaysPerYear.SendKeys("0");
            holidaysPerYear.SendKeys("0");

            IWebElement submitBtn = driver.FindElement(By.Name("x"));
            submitBtn.Click();

            String output = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div[2]/div/font")).GetAttribute("innerText");

            Console.WriteLine(output);

            //checks to see if the program ran sucsessfully
            Assert.That(output, Is.EqualTo("Please provide a positive salary amount."));

            driver.Quit();
        }
    }

    internal class SeleniumTest5
    {
        [Test]
        public void ClearBtnPress_ClearFields()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calculator.net/salary-calculator.html");

            //finds all input fields and then tests the program
            IWebElement hourlyRate = driver.FindElement(By.Id("camount"));
            IWebElement hoursPerWeek = driver.FindElement(By.Id("chours"));
            IWebElement daysPerWeek = driver.FindElement(By.Id("cdays"));
            IWebElement vacationDaysPerYear = driver.FindElement(By.Id("cvacation"));
            IWebElement holidaysPerYear = driver.FindElement(By.Id("cholidays"));

            hourlyRate.Clear();
            hoursPerWeek.Clear();
            daysPerWeek.Clear();
            vacationDaysPerYear.Clear();
            holidaysPerYear.Clear();

            hourlyRate.SendKeys("14");
            hoursPerWeek.SendKeys("5");
            daysPerWeek.SendKeys("7");
            vacationDaysPerYear.SendKeys("10");
            holidaysPerYear.SendKeys("10");

            IWebElement clearBtn = driver.FindElement(By.XPath("//*[@value='Clear']"));
            clearBtn.Click();

            IWebElement submitBtn = driver.FindElement(By.Name("x"));
            submitBtn.Click();

            String output = driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div[2]/div/font")).GetAttribute("innerText");

            //checks to see if the program ran sucsessfully
            Assert.That(output, Is.EqualTo("Please provide a positive salary amount."));

            driver.Quit();
        }
    }
}
