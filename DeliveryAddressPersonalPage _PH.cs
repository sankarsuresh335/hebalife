using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_PH : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        public string PriceListPagePath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Pricelist/Index/DS";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(@data-bind,'HasAddresses')])[1]")]
        public IWebElement ManageAddressesLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']/option[1]")]
        public IWebElement CityOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']/option[1]")]
        public IWebElement StateOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='AreaCode']")]
        public IWebElement AreaCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[3]")]
        public IWebElement PudoLocationListPickupDelivery { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[2]")]
        public IWebElement AllPickupDeliveryUseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='k-widget k-dropdown k-header']")]
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-info']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickup-search-value']")]
        public IWebElement PickupSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='hl-toggle']")]
        public IWebElement HlSalesCenterQRC { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='accesspoint-toggle']")]
        public IWebElement PartnerPickupPoint { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='fedex-toggle']")]
        public IWebElement PickupAllTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']/ancestor::li/span[contains(.,' Please fill out first name')]")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']/ancestor::li/span[contains(.,' Please fill out the street address field')]")]
        public IWebElement ErrorMsgStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']/ancestor::li/span[contains(.,' Please fill out the street 2 address field')]")]
        public IWebElement ErrorMsgStreet2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']/ancestor::li/span[contains(.,'Please fill out the state')]")]
        public IWebElement ErrorMsgState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']/ancestor::li/span[contains(.,' Please fill out the city')]")]
        public IWebElement ErrorMsgCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/ancestor::li/span[contains(.,' Mobile number Required')]")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/ancestor::li/span/following-sibling::span")]
        public IWebElement WaterMarkPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'First Name:')]/span[contains(text(),'*')]")]
        public IWebElement FirstNameAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Address 1:')]/span[contains(text(),'*')]")]
        public IWebElement StreetAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Address 2:')]/span[contains(text(),'*')]")]
        public IWebElement Street2Asterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Province:')]/span[contains(text(),'*')]")]
        public IWebElement StateAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'City:')]/span[contains(text(),'*')]")]
        public IWebElement CityAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Mobile Phone:')]/span[contains(text(),'*')]")]
        public IWebElement PhoneNumberAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/following-sibling::span[contains(text(),' Mobile number Invalid')]")]
        public IWebElement PhoneFormat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.PhoneNumber']")]
        public IWebElement readOnlyPhoneNumberValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']/a/span")]
        public IWebElement shopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='html: shippingSelectedAddress.FullAddress']")]
        public IWebElement fullAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement MileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement GoogleSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement GoogleSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressIteam { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]

        public IWebElement AddressIteam2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-go-checkout']")]
        public IWebElement GOToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[1]")]
        public IWebElement btbShowMap { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[2]")]
        public IWebElement btbViewLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='viewMap']//img)[2]/parent::div/parent::div/parent::div")]
        public IWebElement MapView { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-view='PickUpLocationList'])[2]")]
        public IWebElement MapViewPickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div[1]")]
        public IWebElement Pickupaddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div[2]")]
        public IWebElement Pickupaddress2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']")]
        public IWebElement ShippingFrm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement CleanSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement AddAddress_Btn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']/following-sibling::span")]
        public IWebElement TextErrorForInvalidZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='AreaCode']")]
        public IWebElement TextErrorForInvalidAreacode { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement TextErrorForInvalidPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'invisible: ShippingAddressesFound')]")]
        public IWebElement TextForNoSavedAddressMatched { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressUpdatedCorrectly')]")]
        public IWebElement AddressUpdatedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='savedAddressesList']/li")]
        public IWebElement PersonalSavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='contactList']/li")]
        public IWebElement CustomerSavedAddressList { get; set; }

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

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

        public void ValidateAttributeContains(string Streetvalue, string Neighbourhoodvalue, string Cityvalue, string Statevalue)
        {
            string value = Street.InputBoxValue();
            string value2 = City.InputBoxValue();
            string value3 = State.InputBoxValue();
            if (value.Contains(Streetvalue) && value2.Contains(Cityvalue) && value3.Contains(Statevalue))
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

        public void StateSelection(string StateName)
        {
            Region.Click();
            var Citylist = InitializeReadOnlyCollection("//ul[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
        }

        public void SelectOption(string option, bool isState = true, bool isEdit = true)
        {
            if (isEdit)
            {
                if (isState)
                {
                    State.SelectDropDownOption(option);
                }
                else
                {
                    City.SelectDropDownOption(option);
                }
            }
        }
        /// <summary>
        /// Below Method is use for Searching and Edit Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        /// <param name="IsCustomer"></param>
        public void SearchAndEditDelete(Framework.Address add, bool IsCustomer = false)
        {

            //Select address from list and Edit address
            var count1 = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.Zip))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");

                    string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                    if (ele1 != null)
                        Assert.IsTrue(true);
                    else
                        Assert.IsFalse(true, "No tag found");

                    WaitForAddressList();
                    PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "Culaba", "Biliran", "", "99849484", "", "", "09", "");
                    PageExtension.WaitForTimeSpan(2000);
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        Street.Clear();
                        Street.SendKeys(add.Street);
                        Street2.Clear();
                        Street2.SendKeys(add.Street2);
                        PageExtension.WaitForTimeSpan(2000);
                        PageExtension.WaitForElementPresentAndVisible(this, StateOption);
                        SelectOption(add.State);
                        PageExtension.WaitForTimeSpan(3000);
                        WaitSpainToFalse();
                        PageExtension.WaitForElementPresentAndVisible(this, CityOption);
                        SelectOption(add.City, false);
                        WaitSpainToFalse(); //added
                        AreaCode.Clear();
                        AreaCode.SendKeys(add.AreaCode);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        WaitSpainToFalse();
                        AreaCode.Click();
                        if (IsCustomer == false)
                        {
                            CustomerRadioBtn.Click();
                            IsCustomer = true;
                        }
                        else
                        {
                            PersonalRdoBtn.Click();
                            IsCustomer = false;
                        }
                        ShippingAddrSave.Click();
                        PageExtension.WaitForTimeSpan(3000);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                        WaitForAddressList();
                        Assert.IsTrue(true, "Address successfully Edited");
                        break;
                    }
                    else
                        Assert.IsFalse(true, "No address found");
                }
                //Edited address validation and Ship to same address
                PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
                SearchFieldPersonal.Clear();
                SearchFieldPersonal.SendKeys(add.FirstName);
                WaitSpainToFalse();
                WaitForAddressList();
                var count = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
                if (count != null && count.Count > 0)
                {
                    foreach (var item in count)
                    {
                        string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;
                        if (ele.Contains(add.FirstName.Remove(add.FirstName.Length - 2)) && ele.Contains(add.Street) && ele.Contains(add.Zip))
                            Assert.IsTrue(true, "The address is successfully Edited");
                        else
                            Assert.IsTrue(false, "Address is not Matching");

                        string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                        if (ele1 != null)
                            Assert.IsTrue(true);
                        else
                            Assert.IsFalse(true, "No tag found");
                        break;
                    }
                }
                PersonalAddrList.Click();
                if (CommonMethods.IsElementDisplayed(ShiptothisBut))
                {
                    PageExtension.WaitForElementPresentAndVisible(this, ShiptothisBut);
                    PageExtension.WaitForTimeSpan(1000);
                    ShiptothisBut.Click();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    Driver.WaitForDocumentReady();
                    PageExtension.WaitForTimeSpan(5000);
                    PageExtension.WaitForElementPresentAndVisible(this, ShoppersAddr);
                    ShopperProfileContains(add);
                    Driver.WaitForDocumentReady();
                }
                else
                    Assert.IsFalse(false, "No address found");
            }
            else
                Assert.IsFalse(false, "No address found");
        }
        /// <summary>
        /// Below Method is use for Searching Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        public void SearchAddress(String FirstName)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }
        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, StateOption);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, CityOption);
            SelectOption(add.City, false);
            AreaCode.SendKeys(add.AreaCode);
            PhoneNumber.SendKeys(add.PhoneNumber);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }
        /// <summary>
        /// Below Method is used for adding Duplicate data to System 
        /// </summary>
        /// <param name="add"></param>
        public void AddedDuplicateAddress(Framework.Address add)
        {
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, StateOption);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, CityOption);
            SelectOption(add.City, false);
            PageExtension.WaitForTimeSpan(3000);
            AreaCode.SendKeys(add.AreaCode);
            PhoneNumber.SendKeys(add.PhoneNumber);
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
        }
        /// <summary>
        /// Below Method is used for validating Duplicate popup 
        /// </summary>
        /// <param name="add"></param>
        public void VerifyDuplicatePopUp(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 20);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Duplicatelist.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled(Overwrite));
            Overwrite.Click();
            PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave, 5);
            //Search Address
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 2));
            WaitSpainToFalse();
            WaitForAddressList();
        }

        public void VerifyFieldsOnAddressPage()
        {
            PageExtension.WaitForTimeSpan(2000);
            AddAddressBtn.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(LastName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Street));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Street2));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(State));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(City));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PhoneNumber));
            //Assert.IsTrue(CommonMethods.IsElementDisplayed(WaterMarkPhoneNumber));
        }
        /// <summary>
        /// 
        /// </summary>
        public void VerifyAsteriskSymbol()
        {
            AddAddressBtn.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(StreetAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Street2Asterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(StateAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(CityAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PhoneNumberAsterisk));

        }

        public void SearchValidAddress(Framework.Address add, bool isValidaddress = false)
        {
            bool isInValidaddressFound = true;
            var cus = MandatryFieldCount("//*[@id='addressList']//div[@role='option']");
            if (cus.Count > 0)
            {
                foreach (var val in cus)
                {
                    if (val != null)
                    {
                        this.ScrollIntoView(val);
                        this.ScrollToTop();
                        PageExtension.WaitForTimeSpan(1000);
                        val.Click();
                    }
                    this.WaitForElementGone(CommonFindBy.LoadIndicator);
                    if (isValidaddress == true && CommonMethods.IsElementDisplayed(ShiptothisBut))
                    {
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditCostomerLink));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        isValidaddress = true;
                        break;
                    }
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(CancelAddAddress))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        if (CommonMethods.IsElementDisplayed(ShippingAddrSave))
                        {
                            PageExtension.WaitForTimeSpan(1000);
                            FirstName.Clear();
                            PageExtension.WaitForTimeSpan(1000);
                            FirstName.SendKeys("FN" + RandomString(4, false));
                            LastName.Clear();
                            PageExtension.WaitForTimeSpan(1000);
                            LastName.SendKeys("LastName");
                            Street.Clear();
                            Street.SendKeys("Address1");
                            Street2.Clear();
                            Street2.SendKeys("Address2");
                            PageExtension.WaitForTimeSpan(2000);
                            PageExtension.WaitForElementPresentAndVisible(this, By.XPath("//*[@id='State']/option[1]"));
                            SelectOption("Bataan");
                            WaitSpainToFalse();
                            PageExtension.WaitForTimeSpan(2000);
                            WaitSpainToFalse();
                            PageExtension.WaitForElementPresentAndVisible(this, By.XPath("//*[@id='City']/option[1]"));
                            SelectOption("Balanga", false);
                            WaitSpainToFalse();
                            PageExtension.WaitForTimeSpan(2000);
                            AreaCode.SendKeys("6100");
                            PhoneNumber.Clear();
                            PhoneNumber.SendKeys("73493671");
                            PageExtension.WaitForTimeSpan(1000);
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpainToFalse();
                            Driver.WaitForDocumentReady();
                            WaitForAddressList();
                        }
                        break;
                    }
                    else
                    {
                        isInValidaddressFound = false;
                    }
                    if (isInValidaddressFound == false)
                    {
                        Assert.IsTrue(true, "No Invalid Customer address found");
                    }

                }

            }
            else
                Assert.IsFalse(true, "No customer address found");
        }

        public void VerifyFieldsErrorMessages()
        {
            //SAVE with all blank fields
            PageExtension.WaitForTimeSpan(2000);
            AddAddressBtn.Click();
            ShippingAddrSave.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgFirstName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgStreet));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgStreet2));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgState));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgCity));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));
            PageExtension.WaitForTimeSpan(2000);
            //Enter first name and last name click on Save button
            AddAddressBtn.Click();
            FirstName.SendKeys("First Name");
            LastName.SendKeys("Last Name");
            AreaCode.SendKeys("09");
            ShippingAddrSave.Click();
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgFirstName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgStreet));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgStreet2));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgState));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgCity));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));
            //Enter all fileds and leave black for first name
            AddAddressBtn.Click();
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "Culaba", "Biliran", "", "99849484", "", "", "09", "");
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, StateOption);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, CityOption);
            SelectOption(add.City, false);
            AreaCode.SendKeys(add.AreaCode);
            PhoneNumber.SendKeys(add.PhoneNumber);
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgFirstName));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgStreet));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgStreet2));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgState));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgCity));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));
        }

        public void VerifyPhoneNumberFieldLength()
        {
            AddAddressBtn.Click();
            PhoneNumber.SendKeys("123");
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PhoneFormat));
            AddAddressBtn.Click();
            PhoneNumber.SendKeys("1234567");
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsFalse(CommonMethods.IsElementDisplayed(PhoneFormat));
            AddAddressBtn.Click();
            PhoneNumber.SendKeys("12345678");
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsFalse(CommonMethods.IsElementDisplayed(PhoneFormat));
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "Culaba", "Biliran", "", "99849484", "", "", "09", "");
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, StateOption);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, CityOption);
            SelectOption(add.City, false);
            AreaCode.SendKeys(add.AreaCode);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsFalse(CommonMethods.IsElementDisplayed(PhoneFormat));
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
        }

        public void VerifyAllowedCharacters()
        {
            String Value = "";
            String AlphNumValue = "!@@%$&%DDDfff123";
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(AlphNumValue);
            Value = FirstName.InputBoxValue();
            Assert.AreEqual(Value, AlphNumValue);
            LastName.SendKeys(AlphNumValue);
            Value = LastName.InputBoxValue();
            Assert.AreEqual(Value, AlphNumValue);
            Street.SendKeys(AlphNumValue);
            Value = Street.InputBoxValue();
            Assert.AreEqual(Value, AlphNumValue);
            Street2.SendKeys(AlphNumValue);
            Value = Street2.InputBoxValue();
            Assert.AreEqual(Value, AlphNumValue);
            PhoneNumber.SendKeys(AlphNumValue);
            Value = PhoneNumber.InputBoxValue();
            Assert.AreNotEqual(Value, AlphNumValue);

        }
        public void VerifyFieldLength()
        {
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            TextFieldCount(FirstName, 20, "weuwqtetqweiywqeyoqw1");
            TextFieldCount(LastName, 20, "weuwqtetqweiywqeyoqw1");
            TextFieldCount(Street, 40, "r7493hfh4392ruowejrooerjewjrlwejrwlr;wle1");
            TextFieldCount(Street2, 40, "r7493hfh4392ruowejrooerjewjrlwejrwlr;wle45435345435435trrtre;wle1");
        }
        public void TextFieldCount(IWebElement webEle, int Count, string Actvalue)
        {
            webEle.SendKeys(Actvalue);
            int ActualCount = webEle.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }
        public void ShopperProfileContains(Framework.Address add)
        {
            string ShopperProfileText = shopperProfile.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " " + add.LastName));
            //Assert.IsTrue(ShopperProfileText.Contains(displayName.Text));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }

        public void VerifyUserAbleModifyPostalcode()
        {
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "Culaba", "Biliran", "", "99849484", "", "", "09", "");
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, StateOption);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, CityOption);
            PostalCode.SendKeys("3435");
            Assert.IsTrue(PostalCode.InputBoxValue().ToString().Equals("3435"));
        }

        public void VerifyFieldAutoPopulatedBasedOnProvince()
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "Culaba", "Biliran", "", "99849484", "", "", "09", "");
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, StateOption);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            State.InputBoxValue().ToString().Equals("Biliran");
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, CityOption);
            SelectOption(add.City, false);
            PageExtension.WaitForTimeSpan(3000);
            State.InputBoxValue().ToString().Equals("Culaba");
            PostalCode.InputBoxValue().ToString().Equals("6547");
            AreaCode.SendKeys(add.AreaCode);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsFalse(CommonMethods.IsElementDisplayed(PhoneFormat));
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            //return add;
        }

        public void VerifyFieldAutoPopulatedBasedOnProvinceWhileEdit()
        {
            VerifyFieldAutoPopulatedBasedOnProvince();
            PageExtension.WaitForTimeSpan(3000);
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, StateOption);
            SelectOption("Agusan del Sur");
            PageExtension.WaitForTimeSpan(3000);
            State.InputBoxValue().ToString().Equals("Agusan del Sur");
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, CityOption);
            SelectOption("La Paz", false);
            PageExtension.WaitForTimeSpan(3000);
            State.InputBoxValue().ToString().Equals("La Paz");
            PostalCode.InputBoxValue().ToString().Equals("8508");
        }

        public IList<IWebElement> verifyMileDropDown()
        {
            SelectElement oSelect = new SelectElement(MileDropdown);
            IList<IWebElement> elementCount = oSelect.Options;
            return elementCount;
        }

        public List<string> GetListOfShippingAddressDetails()
        {
            var ShippingAddressList = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
            List<string> ListOfContactDetails = new List<string>(ShippingAddressList.Count);
            for (int i = 0; i < ShippingAddressList.Count; i++)
            {
                string ContactDetails = ShippingAddressList[i].Text;
                ListOfContactDetails.Add(ContactDetails);
                if (i == ShippingAddressList.Count - 1)
                    break;
            }
            return ListOfContactDetails;
        }

        public string SelectValidPersonalSavedAddressToEdit()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            string FullNameSelectedSavedPersonalAddress = string.Empty;
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);
                if (!CommonMethods.IsElementDisplayed(ShippingAddrSave) && !CommonMethods.IsElementDisplayed(ShippingAddrCancelBtn))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalTag));
                    FullNameSelectedSavedPersonalAddress = displayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedPersonalAddress;
        }

        public string SelectValidCustomerSavedAddressToEdit()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> customerContactList = Driver.FindElements(By.XPath("//*[@class='type Customer']"));
            string FullNameSelectedSavedCustomerAddress = string.Empty;
            new Actions(Driver).MoveToElement(CustomerTag).Perform();
            for (int i = 0; i <= customerContactList.Count; i++)
            {
                customerContactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 60);
                PageExtension.WaitForTimeSpan(1000);
                if (!CommonMethods.IsElementDisplayed(ShippingAddrSave) && !CommonMethods.IsElementDisplayed(ShippingAddrCancelBtn))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(CustomerTag));
                    FullNameSelectedSavedCustomerAddress = displayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedCustomerAddress;
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
    }
    public class DeliveryAddressPersonalPageTestPH : DeliveryAddressPersonalPage_PH { }
}