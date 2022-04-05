using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPageTests_esCR : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        public string AddressPathHome => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/Home/Login/DS/{RunSettings.ValidUser.DSID}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Nombre y apellido no deben exceder los 40 caracteres')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']/section/h3")]
        public IWebElement Choosepersonaladdress { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']/section/p")]
        public IWebElement ChoosepersonaladdressText { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-shipping-address']//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='address-section']//*[@class='saved-addresses']")]
        public IWebElement SavedAddressText { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']//*[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@id='Neighborhood']")]
        public IWebElement Neighborhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement CancelDuplicateAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement PickupAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement ShippingAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']/div)[1]//div[@class='last']")]
        public IWebElement PickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Neighborhood']")]
        public IWebElement NeighborhoodFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='City_listbox']")]
        public IWebElement CityDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Zip']")]
        public IWebElement PostalCodeFieldError { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='State_listbox']")]
        public IWebElement StateDropDown { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']/Span[@data-bind='invisible: showMap']")]
        public IWebElement viewMap { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//img[contains(@src,'https://maps.gstatic.com//mapfiles//transparent.png')])[4]")]
        public IWebElement viewMapFirstLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-select from-map']")]
        public IWebElement SelectviewMapFirstLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Personal']")]
        public IWebElement PersonalRadio { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadio { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Elige una direccion')]")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Elija o agregue una dirección para este pedido.')]")]
        public IWebElement HeaderText { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(), 'Confirmar dirección de envío')]")]
        public IWebElement confrimHeaderText { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']//*[@id='btn-default-address-changed']")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }
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

        public void ValidateAttributeContains(string statevalue, string cityvalue, string neighborhoodvale = null)
        {
            string value = State.InputBoxValue();
            string value1 = City.InputBoxValue();
            string value2 = Neighborhood.InputBoxValue();
            if (neighborhoodvale == null)
            {
                if (value.Contains(statevalue) && value1.Contains(cityvalue))
                    Assert.IsTrue(true, "The Value displayed Correctly");
                else
                    Assert.IsTrue(false, "The Value not set Correctly");
            }
            else
            {
                if (value.Contains(statevalue) && value1.Contains(cityvalue) && value2.Contains(neighborhoodvale))
                    Assert.IsTrue(true, "The Value displayed Correctly");
                else
                    Assert.IsTrue(false, "The Value not set Correctly");
            }

        }

        public void SelectStateOption(string option)
        {
            State.SelectDropDownOption(option);
        }

        public void SelectCityOption(string option)
        {
            City.SelectDropDownOption(option);
        }

        public void SelectNeighborhoodOption(string option)
        {
            Neighborhood.SelectDropDownOption(option);
        }

        public void SelectMilesOption(string option)
        {
            PickUPDdnSearch.SelectDropDownOption(option);
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
        public void SelectAreaOption(string StateName)
        {
            PageExtension.WaitForTimeSpan(3000);
            StateDropDown.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
        }

        public void SelectRegionOption(string CityName)
        {
            PageExtension.WaitForTimeSpan(3000);
            CityDropDown.Click();
            PageExtension.WaitForTimeSpan(3000);
            var Ctylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(3000);
            Ctylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();


        }
        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }
    }
    public class DeliveryAddressPersonalPage_CR : DeliveryAddressPersonalPageTests_esCR { }
}

