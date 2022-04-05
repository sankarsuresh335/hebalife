using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Shop.Automation.Framework
{
    public static class WebElementExtension
    {
        public static string InputBoxValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static void SelectDropDownOption(this IWebElement element, string option)
        {
            try
            {
                new SelectElement(element).SelectByValue(option);
            }
            catch(Exception e)
            {
                
            }
            
        }

        public static void SelectDropDownIndex(this IWebElement element, int ind)
        {
            try
            {
                new SelectElement(element).SelectByIndex(ind);
            }
            catch (Exception e)
            {

            }

        }

        public static bool IsWebElementDisplayed(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

		public static bool IsAttributePresent(IWebElement element, string attribute	)
		{
			bool result = false;
			string value = null;
			try
			{
				value = element.GetAttribute(attribute);
				if (value == null)
				{
					result = true;
				}
			}
			catch (Exception e)
			{

				//throw;
			}

			return result;
		}

        /// <summary>
        /// Clear the input text, using selenium Clear() methodm,  and then send the text to the element using SendKeys() selenium method.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="inputElement"></param>
        /// <param name="text"></param>
        public static void SendTextToElement(this IWebElement inputElement, string text)
        {
            inputElement.Clear();
            inputElement.SendKeys(text);
        }

        /// <summary>
        /// Check the status of the checkbox, if the element is not select it then select it.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="inputElement"></param>
        /// <param name="text"></param>
        public static void DeselectCheck(this IWebElement checkbox)
        {
            if (checkbox.Selected)
            {
                checkbox.Click();
            }
        }

        /// <summary>
        /// Return top possition repect to viewport.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="inputElement"></param>
        /// <param name="text"></param>
        public static double GetYLocation(this IWebElement checkbox, Page page)
        {
            String elementPosition = "var elementTopPosition = arguments[0].getBoundingClientRect().top;" +
                                              "return elementTopPosition;";

            double scriptResult = Convert.ToDouble(((IJavaScriptExecutor)page.Driver).ExecuteScript(elementPosition, checkbox));

            return scriptResult;
        }

    }
}