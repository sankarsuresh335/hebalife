using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Shop.Automation.Framework
{
    public static class AssertHelpers
    {
        /// <summary>
        /// Asserts that the <paramref name="expected"/> string is a substring of the <paramref name="actual"/> value.
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        /// <remarks>
        /// The assertion performs a case-insensitive search on the actual value.</remarks>
        public static void ContainsCaseInsensitive(string expected, string actual)
        {
            if (actual.IndexOf(expected, 0, StringComparison.OrdinalIgnoreCase) != -1)
            {
                return;
            }
            Assert.Fail("{0} does not contain {1}", actual, expected);
        }

        /// <summary>
        /// Asserts that a string is not null or white space or empty.
        /// </summary>
        /// <param name="inputBoxValue">the value to check</param>
        /// <param name="name">The value's name - to report the failure source</param>
        public static void StringNotBlank(string inputBoxValue, string name)
        {
            if (string.IsNullOrWhiteSpace(inputBoxValue))
            {
                Assert.Fail("StringNotBlank failed for {0}", name);
            }
        }

        /// <summary>
        /// Asserts that a list of Web Elements are displayed in current page.
        /// </summary>
        /// <param name="elementList">List of Web Elements to validate</param>
        public static void WebElementsInListAreDisplayed(IList<IWebElement> elementList)
        {
            bool areElementsDisplayed = true;
            foreach(IWebElement element in elementList)
            {
                if (!WebElementExists(element))
                {
                  areElementsDisplayed = false;
                }
            }
            Assert.IsTrue(areElementsDisplayed,"Passed");
        }

        /// <summary>
        /// Asserts that a list of Web Elements are NOT displayed in current page.
        /// </summary>
        /// <param name="elementList">List of Web Elements to validate</param>
        public static void WebElementsInListAreNotDisplayed(IList<IWebElement> elementList)
        {
            int i = 0;
            foreach (IWebElement element in elementList)
            {
                i++;
                Assert.IsTrue(!CommonMethods.IsElementDisplayed(element));
            }
        }

        public static void WebElementsInListAreEnabled(IList<IWebElement> elementList)
        {
            int i = 0;
            foreach (IWebElement element in elementList)
            {
                i++;
                Assert.IsTrue(element.GetAttribute("disabled") == null);
            }
        }

        public static void WebElementsInListAreDisabled(IList<IWebElement> elementList)
        {
            int i = 0;
            foreach (IWebElement element in elementList)
            {
                i++;
                Assert.IsTrue(IsAttributePresent(element,"disabled"));
            }
        }

        public static bool WebElementExists(IWebElement element)
        {
            try
            {
                var displayed = element.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            return true;
        }

        public static bool IsAttributePresent(IWebElement element, string attribute)
        {
            bool result = false;
            try
            {
                string value = element.GetAttribute(attribute);
                if (value != null)
                {
                    result = true;
                }
            }
            catch (Exception e) { }
            return result;
        }
    }
}
