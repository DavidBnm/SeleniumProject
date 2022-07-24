using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{

			IWebDriver ChromeDriver  = new ChromeDriver();
			ChromeDriver.Manage().Window.Maximize();
			ChromeDriver.Navigate().GoToUrl("https://www.yad2.co.il/");
			ChromeDriver.Navigate().GoToUrl("https://www.yad2.co.il/vehicles/cars");
			NavigateToadvanceSearch(ChromeDriver);
		}
		public static void NavigateToadvanceSearch(IWebDriver ChromeDriver)
		{
			var adavanceSearchCssSelector = "#__layout > div > main > div > div.main_body > div.LD_search_wrapper > div > div > form > ul > li.search_column.col_x3.advanced_search.advance_search_tooltip > div > div.dropdown_btn > div > button";
			IWebElement element = ChromeDriver.FindElement(By.CssSelector(adavanceSearchCssSelector));
			element.Click();
		}
	}

}
