using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_EC_MB : Page
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-list']//h4")]
        public IWebElement NoAddrWarningMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: HasAddresses' and contains(@href,'/es-EC/Shop')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[2]")]
        public IWebElement UseselectedAddressBtnPUDO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Address2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='City_listbox']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='State_listbox']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='County_listbox']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='Zip_listbox']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement PickupAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='LastName']")]
        public IWebElement LastnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement CityerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement StreeterrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='County']")]
        public IWebElement CountyerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='State']")]
        public IWebElement StateerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip']")]
        public IWebElement ZIPerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement PhoneNumbererrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-section']")]
        public IWebElement ManageSavedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement PersonalList_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']")]
        public IWebElement CustomerList_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchField_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-content']/p")]
        public IWebElement AddressHeadingMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-info']")]
        public IWebElement ManageAddress_AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewonMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='icon-cart-fl-6']")]
        public IWebElement CartIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement DisplayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressSavedCorrectly')]")]
        public IWebElement AddressSavedSuccessfullyNotification { get; set; }

        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

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

        public void StateSelection(string Statename)
        {
            PageExtension.WaitForTimeSpan(2000);
            State.Click();
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(Statename)).Click();
        }

        public void CitySelection(string CityName)
        {
            PageExtension.WaitForTimeSpan(2000);
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }

        public void CountySelection(string CountyName)
        {
            County.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Countylist = InitializeReadOnlyCollection("//*[@id='County-list']//*[@id='County_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Countylist.FirstOrDefault(i => i.Text.Contains(CountyName)).Click();
        }

        public void PostalCodeSelection(string postalcode)
        {
            PostalCode.Click();
            PageExtension.WaitForTimeSpan(2000);
            var postallist = InitializeReadOnlyCollection("//*[@id='Zip-list']//*[@id='Zip_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            postallist.FirstOrDefault(i => i.Text.Contains(postalcode)).Click();
        }

        public void SelectMilesOption(string option)
        {
            PickUPDdnSearch.SelectDropDownOption(option);
        }

        public void ValidateAttributeContains(string Statevalue, string Cityvalue, string Countyvalue, string Zipvalue)
        {
            string value = State.GetAttribute("innerHTML");
            string value1 = City.GetAttribute("innerHTML");
            string value2 = County.GetAttribute("innerHTML");
            string value3 = PostalCode.GetAttribute("innerHTML");

            if (value.Contains(Statevalue) && value1.Contains(Cityvalue) && value2.Contains(Countyvalue) && value3.Contains(Zipvalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void RefreshAndSearchAddress(Framework.Address add)
        {
            Driver.Navigate().Refresh();
            WaitSpinToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
            SearchAddres.Click();
            Assert.IsTrue(PageExtension.WaitForElementPresentAndEnable(this, EditInformation));
        }

        public void Validatedistancedropdown(string expected)
        {
            string value = PickUPDdnSearch.Text;
            if (value.Contains(expected))
            {
                Assert.IsTrue(true, "The Value displayed Correctly");
            }
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

        public void ValidateshopperprofilePickUP(string Streetvalue, string CityValue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(CityValue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void SelectAddressPickUp()
        {
            var val = MandatryFieldCount("//*[@id='locationList']/div[@class='address-item']");
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

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Address1.SendKeys(add.Street);
            Address2.SendKeys(add.Street2);
            StateSelection(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            CitySelection(add.City);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            CountySelection(add.StreetNumber);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PostalCodeSelection(add.Zip);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            ValidateAttributeContains(add.State, add.City, add.StreetNumber, add.Zip);
            PhoneNumber.SendKeys(add.PhoneNumber);
            if (IsCustomer)
                CustomerRdoBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            if (iscancelled)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
        }

        public void ValidateAddressDisplayedByAlphabeticalOrder()
        {
            List<String> originalList = new List<String>();
            List<String> SortedList = new List<String>();
            var count = InitializeReadOnlyCollection("//*[@class='address-item']/div/strong");
            if (count != null && count.Count > 0)
            {
                foreach (var item in count)
                {
                    string ele = item.Text.ToString().Trim();
                    string[] FullName = Regex.Split(ele, " ");
                    originalList.Add(FullName[0]);
                    SortedList.Add(FullName[0]);
                }
            }
            SortedList.Sort();
            Assert.AreEqual(SortedList, originalList);
        }

        public string SelectValidPersonalSavedAddress()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            string FullNameSelectedSavedPersonalAddress = string.Empty;
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);
                if (! CommonMethods.IsElementDisplayed(ShippingAddrSave) && ! CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                {
                    FullNameSelectedSavedPersonalAddress = DisplayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedPersonalAddress;
        }
    }
    public class DeliveryAddressPersonalPageTestECMB : DeliveryAddressPersonalPage_EC_MB { }
}