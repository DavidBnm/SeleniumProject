using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
			//ChromeDriver.Navigate().GoToUrl("https://www.yad2.co.il/");
			ChromeDriver.Navigate().GoToUrl("https://www.yad2.co.il/vehicles/cars");
			NavigateToadvanceSearch(ChromeDriver);
			PickItemByCategory(ChromeDriver, "אאודי", "יצרן") ;
		}
		public static void NavigateToadvanceSearch(IWebDriver ChromeDriver)
		{
			var adavanceSearchCssSelector = "#__layout > div > main > div > div.main_body > div.LD_search_wrapper > div > div > form > ul > li.search_column.col_x3.advanced_search.advance_search_tooltip > div > div.dropdown_btn > div > button";
			IWebElement element = ChromeDriver.FindElement(By.CssSelector(adavanceSearchCssSelector));
			element.Click();

		}
		public static void PickItemByCategory(IWebDriver ChromeDriver, string itemName,string categoryName)
		{
			var categoryXpath = "//*[@id='__layout']/div/main/div/div[4]/div[4]/div/div/form/ul/li[1]/div/label/select";
			var itemListSelector = ChromeDriver.FindElement(By.XPath(categoryXpath));
			//object of SelectElement
			SelectElement s = new SelectElement(itemListSelector);
			//Options method to get all options
			s.SelectByText(itemName);
			var result = s.SelectedOption;
			var result1 = result;

		}
		public static By SelectorByAttributeValue(string p_strAttributeName, string p_strAttributeValue)
		{
			return (By.XPath(String.Format("//*[@{0} = '{1}']",
										   p_strAttributeName,
										   p_strAttributeValue)));
		}
	}

}
