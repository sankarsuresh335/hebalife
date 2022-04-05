using Newtonsoft.Json;
using Shop.Catalog.Service.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Automation.Framework.Helpers
{
    public class CatalogAPIConsumer
    {
        private string environment;
        private string locale;

        private readonly string baseURL;
        private readonly string port = ":8230";

        private readonly string productAPIPrefix = "/api/product/V2/";
        private readonly string productAPISufix = "/Shop/";

        public CatalogAPIConsumer(string environment, string locale)
        {
            this.environment = environment;
            this.locale = locale;
            this.baseURL = GetBaseAPIURL();
        }

        /// <summary>
        /// Set the value of the base URL. Depending of the enviroment to test the URL API is different, please check: https://hrbl-mts.atlassian.net/wiki/spaces/SCatalog/pages/273252488/API+Validations
        /// </summary>
        /// <returns></returns>
        //TODO: Get Base URL from a general config properties files when available
        private string GetBaseAPIURL()
        {
            string url;

            switch (environment.Trim().ToLower())
            {
                case "qa":
                    url = "http://zuswqa4svc01.hrbl.net";
                    break;
                case "qa5":
                    url = "http://zuswqa5svc01.hrbl.net";
                    break;
                case "afarm":
                case "afarmonprem":
                    //url = "https://usslcprodsvcva.hrbl.net";
                    url = "http://usslcprodsvc00.hrbl.net";
                    break;
                case "green":
                    url = "http://zuswpsssg000001.hrbl.net";
                    break;
                case "black":
                    url = "http://zuswpsssb000001.hrbl.net";
                    break;
                case "prod":
                    url = "https://usslcprodsvcv.hrbl.net";
                    break;
                case "bfarm":
                    url = "http://usslcprodsvc01.hrbl.net";
                    break;
                case "cfarm":
                    url = "http://usslcprodsvc09.hrbl.net";
                    break;
                case "dfarm":
                    url = "http://usslcprodsvc17.hrbl.net";
                    break;
                case "efarm":
                    url = "http://usslcprodsvc25.hrbl.net";
                    break;
                default:
                    url = "";
                    break;
            }
            
            return url;
        }

        /// <summary>
        /// Use WebClient to read the API and return
        /// </summary>
        /// <param name="apiURL"></param>
        /// <param name="elementIndex"></param>
        /// <returns></returns>
        private string ConsumeAPI(string apiURL)
        {
            string api = baseURL + port + apiURL;

            using (var webClient = new WebClient())
            {
                string rawApiData = webClient.DownloadString(api);
                return rawApiData;
            }
        }

        private string GetProductAPIURL(string filter = "")
        {
            return productAPIPrefix + locale + productAPISufix + filter;
        }

        private IList<ProductDocument> GetDeserializeObjectOfAllProducts()
        {
            string apiURL = GetProductAPIURL();

            return JsonConvert.DeserializeObject<IList<ProductDocument>>(ConsumeAPI(apiURL)); ;
        }

        //**************************************EVENTS
        private IList<ProductDocument> GetDeserializeObjectCEventList()
        {
            string apiURL = GetProductAPIURL("?DetailLevel=ListingContent&productType=EventTicket");

            return JsonConvert.DeserializeObject<IList<ProductDocument>>(ConsumeAPI(apiURL)); ;
        }

        /// <summary>
        ///  Return a Sku that is considered valid, the event should have the property Content.IsDisplayable and also should not be part of the category 'Annual Processing Fee'. 
        ///  If the number of ProductDocument is 0 or we are trying to retrieve a element index that is not accesible return null
        /// </summary>
        /// <param name="elementIndex"></param>
        /// <returns></returns>
        private ProductDocument GetValidEvent(int elementIndex)
        {
            IList<ProductDocument> apiResults = GetDeserializeObjectCEventList();

            try
            {
                ProductDocument validEvent = apiResults.Where(p => p.Content.IsDisplayable).ToList().Where(p => p.Content.Categories.Any(d => !d.Name.ToLower().Contains("Annual Processing Fee"))).ElementAt(elementIndex);

                return validEvent;
            }
            catch (ArgumentOutOfRangeException)
            {

                return null;
            }
        }

        /// <summary>
        /// Return the value of a valid Event SKU.
        /// </summary>
        /// <returns></returns>
        public string GetEventSKU(int elementIndex = 0)
        {
            ProductDocument validEvent = GetValidEvent(elementIndex);

            return validEvent == null ? "" : validEvent.SKU;

        }

        /// <summary>
        ///  Consume Product API return a valid Event Category. If not valid SKU is found or not API does not return values the methods retun and empty string.
        /// </summary>
        /// <returns></returns>
        public string GetEventCategoryID(int elementIndex = 0)
        {
            ProductDocument validEvent = GetValidEvent(elementIndex);

            return validEvent == null ? "" : validEvent.Content.Categories[0].Id;
        }
        //**************************************

        //**************************************Apparels
        /// <summary>
        ///  Return a Sku that is considered valid, the apparel should have the property IsApparel and IsDisplayable should be true and Pricing IsActive is true and IsDiscontinued is false. 
        ///  If the number of ProductDocument is 0 or we are trying to retrieve a element index that is not accesible return null
        /// </summary>
        /// <param name="elementIndex"></param>
        /// <returns></returns>
        private ProductDocument GetValidApparel(int elementIndex)
        {
            IList<ProductDocument> apiResults = GetDeserializeObjectOfAllProducts();

            try
            {
                ProductDocument validEvent = apiResults.Where(p => p.Content.IsDisplayable && p.Content.IsApparel && p.Pricing.IsActive && !p.Pricing.IsDiscontinued).ToList().ElementAt(elementIndex);

                return validEvent;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        /// <summary>
        /// Return the value of a valid Apparel SKU.
        /// </summary>
        /// <returns></returns>
        public string GetApparelSKU(int elementIndex = 0)
        {
            ProductDocument validApparel = GetValidApparel(elementIndex);

            return validApparel == null ? "" : validApparel.SKU;

        }

        /// <summary>
        ///  Consume Product API return a valid Apparel Category. If not valid SKU is found or not API does not return values the methods retun and empty string.
        /// </summary>
        /// <returns></returns>
        public string GetApparelCategoryID(int elementIndex = 0)
        {
            ProductDocument validApparel = GetValidApparel(elementIndex);

            return validApparel == null ? "" : validApparel.Content.Categories[0].Id;
        }
        //**************************************
    }
}
