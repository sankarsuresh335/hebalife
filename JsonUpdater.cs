using Newtonsoft.Json;
using NUnit.Framework;
using Shop.Automation.Framework.Adapters;
using Shop.Catalog.Service.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Automation.Framework.Helpers
{
    public class JsonUpdater
    {
        private readonly string _targetEnvironment;
        private readonly string _targetLocale;

        private string settingsFileFullPath;

        /// <param name="targetEnvironment">The environment name, such as "Local", "QA", "Staging" etc.</param>
        /// <param name="targetLocale"></param>
        public JsonUpdater(string targetEnvironment, string targetLocale)
        {
            if (string.IsNullOrEmpty(targetEnvironment) || string.IsNullOrEmpty(targetLocale))
            {
                throw new ArgumentNullException(nameof(targetEnvironment));

            }
            _targetEnvironment = targetEnvironment;
            _targetLocale = targetLocale;

            
        }

        public string SettingsFilePath => $"./TestRunSettings/{_targetEnvironment}/TestRunSettings.{_targetLocale}.json";

        public TestRunSettings GetCurrentTestRunSettings()
        {
            settingsFileFullPath = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory)) + SettingsFilePath;
            if (!File.Exists(settingsFileFullPath))
            {
                throw new FileNotFoundException("Test Run Settins file not found", settingsFileFullPath);
            }
            var result = JsonConvert.DeserializeObject<TestRunSettings>(File.ReadAllText(settingsFileFullPath));
            return result;
        }

        public async Task OverwriteETOSKUsAsync()
        {
            var testRunSettings = GetCurrentTestRunSettings();
            bool isETOAvailable = false;

            ProductAPIAdapter productApi = new ProductAPIAdapter(_targetLocale, _targetEnvironment);
            productApi.AddParameter("DetailLevel", "ListingContent");
            productApi.AddParameter("ShopperType", "Distributor");
            productApi.AddParameter("productType", "EventTicket");

            string[] exceptionList =
            {
                "9909",
                "0909",
                "N990",
                "391H",
                "269H",
                "267H"
            };
            try
            {
                await productApi.CallService();

                if(productApi.instance != null)
                foreach (ProductDocument pd in productApi.instance)
                {
                    //if (DateTime.Now >= pd.Content.DisplayStartDate && DateTime.Now <= pd.Content.DisplayEndDate && !exceptionList.Contains(pd.SKU))
                    if (!exceptionList.Contains(pd.SKU))
                    {
                        testRunSettings.ETOBasicSKUList[0].Sku = pd.SKU;
                        testRunSettings.CartSettings.ETO_SKU = pd.SKU;
                        isETOAvailable = true;
                        break;
                    }

                }
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            

            testRunSettings.CartSettings.IsETOAvailable = isETOAvailable;

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@settingsFileFullPath))
            {
                JsonSerializer serializer = new JsonSerializer{NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore, Formatting =Formatting.Indented };
                serializer.Serialize(file, testRunSettings);
            }

        }

    }
}
