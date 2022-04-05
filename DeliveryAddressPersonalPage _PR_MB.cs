using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_PR_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public string AddressPathCart => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}?OrderCategory=RSO&runRules=true";
        
        public string AddressPathCatalog => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Home/Index/{RunSettings.ValidUser.Schema}";

        public string AddressPathPricelist => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement AddAddressBtnManageaddrPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@name='generic-error']")]
        public IWebElement InvalidAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickupDistanceDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewonMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-clean-pickup-search' and @class='icon-delete-ln-3 clear-search'])[2]")]
        public IWebElement SearchIconClose { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPudoLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldPersonalClose { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighbourhood']")]
        public IWebElement Neighbourhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Province']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='btn-select btn-ship'])[2]")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneType']")]
        public IWebElement PhoneType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditShippingAddresLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement SaveEditedShippingAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-item']")]
        public IWebElement AddressItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='fedex-toggle']")]
        public IWebElement FedexToggleButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='address-search-value']")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']")]
        public IWebElement Productlines { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[2]")]
        public IWebElement FedexSelectAddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PickupSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible: IsBoxAddressForSaveUpdate']//div[@class='notification-error']")]
        public IWebElement BZNError { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible: IsPOAddressForSaveUpdate']//div[@class='notification-error']")]
        public IWebElement POBoxError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: PickupLocationsFoundFunc']")]
        public IWebElement NoPickUpFoundWarningMsg { get; set; }

        public ReadOnlyCollection<IWebElement> webelementsColl;
        
        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
        }

        public void WaitForAddressList()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']");
            while (Iweb.Count < 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']");
            }
        }

        public void AddressList(bool isPersonal)
        {
            if (isPersonal)
            {
                var count = InitializeReadOnlyCollection("//*[@id='savedAddressesList']");
                while (count.Count > 0)
                {
                    count = InitializeReadOnlyCollection("//*[@id='savedAddressesList']");
                    break;
                }
            }
            else
            {
                var count = InitializeReadOnlyCollection("//*[@id='saved-information']//*[@id='contactList']");
                while (count.Count > 0)
                {
                    count = InitializeReadOnlyCollection("//*[@id='saved-information']//*[@id='contactList']");
                    break;
                }
            }

        }

        public void SelectAddress()
        {
            var val = MandatryFieldCount("//*[@id='locationList']/div");
            if (val.Count > 0)
            {
                foreach (var v in val)
                {
                    v.Click();
                    break;
                }
            }
            else
                Assert.IsTrue(false, "No address found");

        }

        public void ValidateAttributeContains(string Streetvalue, string Neighbourhoodvalue, string Cityvalue, string Statevalue)
        {
            string value = Street.InputBoxValue();
            string value1 = Neighbourhood.InputBoxValue();
            string value2 = City.InputBoxValue();
            string value3 = State.InputBoxValue();
            if (value.Contains(Streetvalue) && value1.Contains(Neighbourhoodvalue) && value2.Contains(Cityvalue) && value3.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        public ReadOnlyCollection<IWebElement> MandatryFieldCount(string xPath)
        {
            try
            {
                webelementsColl = Driver.FindElements(By.XPath(xPath));
                while (webelementsColl.Count > 0)
                {
                    return webelementsColl;
                }
                return webelementsColl;
            }
            catch
            {
                return null;
            }
        }

        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }

        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }
        public void SelectMilesOption(string option)
        {
            PickUPDdnSearch.SelectDropDownOption(option);
        }

        public void CitySelection(string CityName)
        {
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }

        public void SelectPhoneOption(string option)
        {
            PhoneType.SelectDropDownOption(option);
        }
    }
    public class DeliveryAddressPersonalPageTestPRMB : DeliveryAddressPersonalPage_PR_MB { }
}
