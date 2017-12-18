﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;

namespace Calculator.Selenium
{
	[TestFixture]
	public class CalculatorSeleniumTest
	{
		private IWebDriver driver;
		private StringBuilder verificationErrors;
		private string baseURL;
		private bool acceptNextAlert = true;

		[SetUp]
		public void SetupTest()
		{
            // The following statement was generated by Selenium IDE:
            // driver new FirefoxDriver();
            // I use the ChromeDriver instead. 
            // Notice the Environment.CurrentDirectory parameter. It specifies the
            // path where the driver can find the chromedriver.exe file. It was
            // added automatically to the bin folder by the Nuget package.
            //driver = new ChromeDriver(Environment.CurrentDirectory);
            //driver = new FirefoxDriver();
            driver = new PhantomJSDriver();
            baseURL = "http://localhost:5001/";
			verificationErrors = new StringBuilder();
		}

		[TearDown]
		public void TeardownTest()
		{
			try
			{
				driver.Quit();
			}
			catch (Exception)
			{
				// Ignore errors if unable to close the browser
			}
			Assert.AreEqual("", verificationErrors.ToString());
		}

		[Test]
		public void TheCalculatorSeleniumTest()
		{
			// The following statement was generated by Selenium IDE, but does not work
			// driver.Navigate().GoToUrl(baseURL + "/");
			// Use instead:
			driver.Navigate().GoToUrl(baseURL);


			driver.FindElement(By.Id("FirstNumber")).Clear();
		    driver.FindElement(By.Id("FirstNumber")).SendKeys("30");
			driver.FindElement(By.Id("SecondNumber")).Clear();
			driver.FindElement(By.Id("SecondNumber")).SendKeys("20");
			driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
			Assert.AreEqual("50,00", driver.FindElement(By.Id("result")).Text);

		}

		private bool IsElementPresent(By by)
		{
			try
			{
				driver.FindElement(by);
				return true;
			}
			catch (NoSuchElementException)
			{
				return false;
			}
		}

		private bool IsAlertPresent()
		{
			try
			{
				driver.SwitchTo().Alert();
				return true;
			}
			catch (NoAlertPresentException)
			{
				return false;
			}
		}

		private string CloseAlertAndGetItsText()
		{
			try
			{
				IAlert alert = driver.SwitchTo().Alert();
				string alertText = alert.Text;
				if (acceptNextAlert)
				{
					alert.Accept();
				}
				else
				{
					alert.Dismiss();
				}
				return alertText;
			}
			finally
			{
				acceptNextAlert = true;
			}
		}
	}
}
