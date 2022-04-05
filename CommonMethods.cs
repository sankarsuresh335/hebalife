
using System;
using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Net.Http;
using System.Runtime;
using System.IO;

namespace Shop.Automation.Framework
{
    public static class CommonMethods
    {
        

        //Sorting order enum
        public enum SortingOrder
        {
            Ascending,
            Descending
        }
        /// <summary>
        ///     Sort IReadOnlyList in ascending/descending order, and returns list sorted.
        /// </summary>
        /// <typeparam name="list">IReadOnly<String> list of elements to be sorted</typeparam>
        /// <param name="order">Specify if sorting order is ascending or descending</param>
        /// <returns>IReadOnlyLis<String> sorted list</String></returns>
        public static IReadOnlyList<string> SortListElements(IReadOnlyList<string> list, SortingOrder order)
        {
            var unsortedList = list.Select(item => item.Replace(System.Environment.NewLine, ""));
            var sortedList = new List<string>();
            sortedList.AddRange(unsortedList.OrderBy(o => o));
            if (order == SortingOrder.Descending)
            {
                sortedList.Reverse();
            }
            return sortedList;
        }
    
        /// <summary>
        ///     Sort IReadOnlyList in ascending/descending order, and returns list sorted.
        /// </summary>
        /// <typeparam name="list">IReadOnly<Double> list of elements to be sorted</typeparam>
        /// <param name="order">Specify if sorting order is ascending or descending</param>
        /// <returns>IReadOnlyLis<Double> sorted list</String></returns>
        public static IReadOnlyList<double> SortListElements(IReadOnlyList<double> list, SortingOrder order)
        {
            var sortedList = new List<double>();
            foreach (Double item in list)
            {
                sortedList.Add(item);
            }
            sortedList.Sort();
            if (order == SortingOrder.Descending)
            {
                sortedList.Reverse();
            }
            return sortedList;
        }

        public static IList<double> SortListElement(IList<double> list, SortingOrder order)
        {
            var sortedList = new List<double>();
            foreach (Double item in list)
            {
                sortedList.Add(item);
            }
            sortedList.Sort();
            if (order == SortingOrder.Descending)
            {
                sortedList.Reverse();
            }
            return sortedList;
        }
        /// <summary>
        ///     Returns a boolean true when an element is displayed in page, if no elemen is 
        ///     displayed it returns false
        /// </summary>
        /// <typeparam name="element">IWebElement</typeparam>
        /// <returns>bool</String></returns>
        public static bool IsElementDisplayed(IWebElement element)
        {
            try
            {
                if (element.Displayed)
                    return true;
                else
                    return false;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        ///     Returns a boolean true when an element is enabled in page, if no elemen is 
        ///     displayed it returns false
        /// </summary>
        /// <typeparam name="element">IWebElement</typeparam>
        /// <returns>bool</String></returns>
        public static bool IsElementEnabledAndDisplayed(IWebElement element)
        {
            try
            {
                if (element.Enabled)
                    return true;
                else
                    return false;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                return false;
            }
        }


        public static bool IsElementEnabled(IWebElement element)
        {
            try
            {
                var hasAttribute = element.GetAttribute("disabled");
                if (hasAttribute != null)
                    return false;
                else
                    return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public static IWebElement FindElement(IWebElement element, string xpath)
        {
            try
            {
                return element.FindElement(By.XPath(xpath));

            }
            catch (Exception)
            {
                return null;
            }

        }

        public static bool IsElementSelected(IWebElement element)
        {
            try
            {
                if (element.Selected)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ValidateLink(IList<IWebElement> list, string attribute, CookieContainer cookies = null)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            // Skip validation of SSL/TLS certificate
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => true;
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
            HttpStatusCode status = HttpStatusCode.NoContent;
            HttpWebRequest request = null;
            foreach (IWebElement element in list)
            {
                try
                {
                    request = (HttpWebRequest)WebRequest.Create(element.GetAttribute(attribute));
                    request.CookieContainer = cookies;
                    request.Timeout = 5000;
                    //request.Timeout = 150000;
                    var response = (HttpWebResponse)request.GetResponse();
                    status = response.StatusCode;
                    Debug.WriteLine($"URL: {element.GetAttribute("href")} status is :{response.StatusCode}");
                    response.Close();
                    response.Dispose();
                }

                catch (Exception ex)
                {
                    using (var handler = new HttpClientHandler() { CookieContainer = cookies })
                    using (var client = new HttpClient(handler))
                    {
                        var response = client.GetAsync(element.GetAttribute(attribute)).Result;
                        status = response.StatusCode;
                    }
                }
            }

            if (status.Equals(HttpStatusCode.OK) || status.Equals(HttpStatusCode.Found))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }



        public static bool ValidateLink(Uri link, CookieContainer cookies = null) //send to extension,
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) => true;
            HttpStatusCode status = HttpStatusCode.NoContent;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                request.CookieContainer = cookies;
                request.Timeout = 5000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                status = response.StatusCode;
                Debug.WriteLine($"URL: {link} status is :{response.StatusCode}");
                response.Close();
                response.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(link + " - " + ex.Message);
                Console.WriteLine(link + " - " + ex.Message);
                //using (var handler = new HttpClientHandler() { CookieContainer = cookies })
                using (var handler = new HttpClientHandler())
                using (var client = new HttpClient(handler))
                {
                    var response = client.GetAsync(link).Result;
                    status = response.StatusCode;
                }
            }


            if (status.Equals(HttpStatusCode.OK) || status.Equals(HttpStatusCode.Found))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        /// <summary>
        /// Generate a random number between two numbers.
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max);
        }


        /// <summary>
        /// If the directory does not exist we create it.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool CreateFolder(string directoryPath)
        {
            bool directoryCreated = false;

            if (!Directory.Exists(directoryPath))
            {
                Debug.WriteLine("Creating Directory");
                Directory.CreateDirectory(directoryPath);

                directoryCreated = true;
            }

            return directoryCreated;
        }


        /// <summary>
        /// Delete all the files that matches with the file name provided and are inside the directory. E.g. all the files that start with PriceListGeneratorTable will be deleted.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool DeleteFilesWithPrefix(string prefixFileName, string path)
        {
            bool filesDeleted = false;

            var dir = new DirectoryInfo(path);

            foreach (var file in dir.EnumerateFiles(prefixFileName + "*"))
            {
                file.Delete();

                filesDeleted = true;
            }

            return filesDeleted;
        }
    }
}
