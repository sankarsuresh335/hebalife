using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Shop.Automation.Framework
{
    public static class PageExtension
    {
        public static bool WaitUntil(this Page page, Func<IWebDriver, bool> condition, int timeoutSeconds = 30)
        {
            try
            {
                var isSuccess = new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                  .Until(condition);
                return isSuccess;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public static bool LoginAvailable()
        {
            return true;
        }

        public static bool WaitForElement(this Page page, By findBy, int timeoutSeconds = 60)
        {
            try
            {
                return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
               .Until(d =>
               {
                   try
                   {
                       return d.FindElement(findBy) != null;
                   }

                   catch (NoSuchElementException)
                   {
                       return false;
                   }
               });
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public static void WaitForDocumentReady(this IWebDriver driver, int timeoutSeconds = 60)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            wait.Until(x =>
            {
                try
                {
                    return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }


        public static DefaultWait<IWebDriver> FluentWait(this IWebDriver driver,int timeOut, int pollingInterval)
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(timeOut);
            wait.PollingInterval = TimeSpan.FromMilliseconds(pollingInterval);
            return wait;
        }

        public static bool WaitForElementGone(this Page page, By findBy, int timeoutSeconds = 60)
        {

            return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                .Until(ExpectedConditions.InvisibilityOfElementLocated(findBy));
        }

        public static bool WaitForElementGone(this Page page, IWebElement element, int timeoutSeconds = 30)
        {

            return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                .Until(d =>
                {
                    try
                    {
                        return element.Displayed == false;
                    }

                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                });
        }

        public static bool WaitForElementPresentAndVisible(this Page page, By findBy, int timeoutSeconds = 30)
        {
            return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                .Until(d =>
                {
                    try
                    {
                        return ExpectedConditions.ElementIsVisible(findBy)(d) != null;
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                });
        }


        public static bool WaitForElementPresentAndVisible(this Page page, IWebElement element, int timeoutSeconds = 30)
        {
            try
            {
                return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                .Until(d =>
                {
                    try
                    {
                        return element.Displayed && element.Enabled == true;
                    }

                    catch (Exception e)
                    {
                        return false;
                    }
                });
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        ///  waits for perticular elements    
        ///  scroll and view
        /// </summary>
        /// <typeparam name="element">IWebElement</typeparam>
        public static void ScrollIntoView(this Page page, IWebElement webElement, double timeoutSeconds = 1)
        {
            try
            {
                var wait = new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds));
                wait.Until(x => ((IJavaScriptExecutor)page.Driver).ExecuteScript("arguments[0].scrollIntoView();", webElement));
            }
            catch (Exception ex)
            {

            }
        }

    /// <summary>
    ///  waits for perticular elements    
    ///  scroll and view into center of the screen
    /// </summary>
    /// <typeparam name="element">IWebElement</typeparam>
    public static void ScrollElementIntoMiddle(this Page page, IWebElement webElement, double timeoutSeconds = 1, int WaitForAnimationTimeMiliSeconds = 1000)
        {
            try
            {
                String scrollElementIntoMiddle = "var viewPortHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);"
                                            + "var elementTop = arguments[0].getBoundingClientRect().top;"
                                            + "window.scrollBy(0, elementTop-(viewPortHeight/2));";

                var wait = new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds));
                wait.Until(x => ((IJavaScriptExecutor)page.Driver).ExecuteScript(scrollElementIntoMiddle, webElement));
                WaitForTimeSpan(WaitForAnimationTimeMiliSeconds);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        /// <summary>
        ///  It will simply scroll into top
        /// </summary>
        /// <typeparam name="element">IWebElement</typeparam>
        public static void ScrollToTop(this Page page)
        {
            try
            {
                ((IJavaScriptExecutor)page.Driver).ExecuteScript("scroll(0,0);");
            }
            catch (Exception ex) { }
        }

        public static void WaitForTimeSpan(int time)
        {
            Thread.Sleep(time);
        }
       
        public static IWebElement WaitForElementClicklable(this Page page, IWebElement element, int timeoutSeconds = 30)
        {

            return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                .Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void PerformClick(Page page, IWebElement element)
        {
            if (IsElementAvalaible(page, element))
            {
                element.Click();
            }
        }


        public static bool IsElementAvalaible(Page page, IWebElement element)
        {
            try
            {
                return (WaitUntil(page, d => element.Displayed) && WaitUntil(page, d => element.Enabled));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void EnterValue(Page page, IWebElement element, string Value)
        {
            if (IsElementAvalaible(page, element))
            {
                element.Clear();
                element.SendKeys(Value);
            }
        }

        public static bool WaitForElementPresentAndEnable(this Page page, IWebElement element, int timeoutSeconds = 30)
        {
            try
            {
                return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                .Until(d =>
                {
                    try
                    {
                        return element.Enabled == true;
                    }

                    catch (Exception e)
                    {
                        return false;
                    }
                });
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool WaitForElementPresentAndDisable(this Page page, IWebElement element, int timeoutSeconds = 5)
        {
            try
            {
                return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                .Until(d =>
                {
                    try
                    {
                        return element.Enabled == false;
                    }

                    catch (Exception e)
                    {
                        return true;
                    }
                });
            }
            catch (Exception e)
            {
                return true;
            }
        }

        public static bool WaitForElementPresentAndDisplayed(this Page page, IWebElement element, int timeoutSeconds = 30)
        {
            try
            {
                return new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                .Until(d =>
                {
                    try
                    {
                        return element.Displayed == true;
                    }

                    catch (Exception e)
                    {
                        return false;
                    }
                });
            }
            catch (Exception e)
            {
                return false;
            }
        }
       
        #region Catalog page extensions
        //TODO: Catalog - Move this methods to a class for catalog use.
        //TODO: ValidateElementAreLoadedInList should be part of a assert class
        /// <summary>
        /// Wait until the list provided in the parameter has more 1 or more elements available. If there no values after the specified timeout, an exception will be thrown 
        /// </summary>
        /// <param name="elementList"></param>
        /// <param name="timeout"></param>
        public static void ValidateElementsAreLoadedInList(this Page page, IList<IWebElement> elementList, int timeout = 2)
        {
            if (!page.WaitUntil(d => elementList.Count > 0, timeout))
            {
                Assert.Fail($"0 elemements were loaded in list{elementList.ToString()} after {3} seconds. Please validate page {page.Driver.Url}");
            }
        }

        /// <summary>
        /// The element will be scroll just below the banner to avoid issues when controling the element.
        /// </summary>
        /// <param name="page"></param>
        public static void ScrollElementBelowBanner(this Page page, IWebElement webElement)
        {
            //Get the height of the banner
            int bannerHeight = 0;
            try
            {
                IWebElement banner = page.Driver.FindElement(CommonFindBy.PageBanner);
                bannerHeight = banner.Size.Height;
            }
            catch (Exception)
            {
                bannerHeight = 0;
            }

            //scroll the element subtracting the height of the banner
            String scrollElementIntoMiddle = "var elementTopPosition = arguments[0].getBoundingClientRect().top;" +
                                              "var scrollPositionY = window.scrollY;" +
                                              "var moveScrollTo = (elementTopPosition + scrollPositionY) - arguments[1];" +
                                              "window.scroll(0, moveScrollTo);";

            ((IJavaScriptExecutor)page.Driver).ExecuteScript(scrollElementIntoMiddle, webElement, bannerHeight);
        }

        /// <summary>
        /// Method waits till the visible text of the element is different of "" and returns the value. If timeout, it will return "". Default timeout 5 seconds
        /// </summary>
        /// <param name="page">POM, Child of Page</param>
        /// <param name="element">Element where the text should be retrieved</param>
        /// <param name="timeoutSeconds">Timeout for WebDriverWait</param>
        /// <returns></returns>
        public static string WaitForElementTextToBeDisplayed(this Page page, IWebElement element, int timeoutSeconds = 5)
        {
            try
            {

                var isSuccess = new WebDriverWait(page.Driver, TimeSpan.FromSeconds(timeoutSeconds))
                  .Until(d => !element.Text.Trim().Equals(""));
                return element.Text;
            }
            catch (WebDriverTimeoutException)
            {
                return "";
            }
        }

        //TODO: Check where ScrollElementBelowBanner() is being used and used the below method to click if needed.
        /// <summary>
        /// Move a web element to a visible part of the page (below the banner) and perform a click
        /// </summary>
        /// <param name="page"></param>
        /// <param name="webElement"></param>
        public static void DoClick(this Page page, IWebElement webElement)
        {
            PrepareToClick(page, webElement);

            ClickElement(page, webElement);

        }


        /// <summary>
        /// Move the cursor to the element and then do a click. This method uses Actions class from selenium to concatenate some actions.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="webElement"></param>
        public static void MoveToElementAndClick(this Page page, IWebElement webElement)
        {
            Actions builderActions = new Actions(page.Driver);
            builderActions.MoveToElement(webElement).Click().Perform();

            page.WaitForElementGone(CommonFindBy.BusyIndicator);
            page.Driver.WaitForDocumentReady();
        }

        /// <summary>
        /// Move a web element to a visible part of the page (below the banner) and perform a click. Use it 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="listOfElements"></param>
        /// <param name="indexTClick"></param>
        public static void DoClick(this Page page, IList<IWebElement> listOfElements, int indexTClick)
        {
            page.ScrollElementBelowBanner(listOfElements[indexTClick]);
            page.WaitForElementGone(CommonFindBy.BusyIndicator);
            page.Driver.WaitForDocumentReady();
            page.WaitForElementClicklable(listOfElements[indexTClick]);
            page.WaitForElementGone(CommonFindBy.BusyIndicator);

            ClickElement(page, listOfElements[indexTClick]);
        }

        private static void PrepareToClick(Page page, IWebElement webElement)
        {
            page.ScrollElementBelowBanner(webElement);
            page.WaitForElementGone(CommonFindBy.BusyIndicator);
            page.Driver.WaitForDocumentReady();
            page.WaitForElementClicklable(webElement);
            page.WaitForElementGone(CommonFindBy.BusyIndicator);
        }

        private static void ClickElement(Page page, IWebElement elementToClick)
        {
            //It is really common to face this issue when the enviroment is slow. In order to avoid to retest because the page is not rendered, catch the exeption and try again after one second
            try
            {
                elementToClick.Click();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("is not clickable at point"))
                {
                    WaitForTimeSpan(1000);
                    elementToClick.Click();
                }
            }

            page.WaitForElementGone(CommonFindBy.BusyIndicator);
            page.Driver.WaitForDocumentReady();
        }

        /// <summary>
        /// Close all the tables except the current window. It will keep the focus on current window when the method was called.
        /// </summary>
        /// <param name="page"></param>
        public static void CloseAllWindowsButCurrent(this Page page)
        {
            //If homepage is loaded, close admin
            string currentWindow = page.Driver.CurrentWindowHandle;
            ReadOnlyCollection<string> windowHandles = page.Driver.WindowHandles;

            foreach (string handle in windowHandles)
            {
                if (handle != currentWindow)
                {
                    page.Driver.SwitchTo().Window(handle);
                    page.Driver.Close();
                }
            }

            page.Driver.SwitchTo().Window(currentWindow);
        }

        /// <summary>
        /// Check if the file exist, if not do a polling of 1 second until reach the timeout
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static bool WaitTillFileIsDownloaded(this Page page, string filePath, int timeout = 10)
        {
            bool fileDownloaded = false;

            for (int i = 0; i < timeout; i++)
            {
                if (File.Exists(filePath))
                {
                    fileDownloaded = true;
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }

            return fileDownloaded;
        }

        #endregion
    }
}