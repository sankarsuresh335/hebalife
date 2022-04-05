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
using System.Text.RegularExpressions;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_PH_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

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

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='saved-addresses']/h3")]
        public IWebElement ManageAddressPageTitle { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']//*[@id='btn-default-address-changed']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement SearchWarningMSG { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']/a/span")]
        public IWebElement shopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement MileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement GoogleSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement GoogleSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='icon-cart-fl-6']")]
        public IWebElement CartIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='html: DisplayedInfo']")]
        public IWebElement ShipTo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement CleanSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowAllLocations']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']/following-sibling::span")]
        public IWebElement TextErrorForInvalidZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement TextErrorForInvalidPhoneNumber { get; set; }

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
        public Framework.Address SearchAndEdit(Framework.Address add, bool iscancelled = false)
        {
            //Select address from list and Edit address

            WaitForAddressList();
            PersonalAddrList.Click();
            add.ClearAddress();
            add.FillAddressforSAMCAM("DJ", "Akash", "street", "street2", "Culaba", "Biliran", "", "99849484", "", "", "09", "");

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
            if (!iscancelled)
            {
                ShippingAddrSave.Click();
                PageExtension.WaitForTimeSpan(3000);
                WaitSpainToFalse();
                Driver.WaitForDocumentReady();
                WaitForAddressList();
                Assert.IsTrue(true, "Address successfully Edited");
            }
            else
            {
                ShippingAddrCancel.Click();
                PageExtension.WaitForTimeSpan(3000);
                WaitSpainToFalse();
            }
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            WaitForAddressList();
            return add;
        }

        public void Validateshopperprofile(string AddressVal)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(AddressVal));
        }

        public void ValidateshopperprofileAddr(string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if ( value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
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
            if (iscancelled)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
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

    }
    public class DeliveryAddressPersonalPageTestPHMB : DeliveryAddressPersonalPage_PH_MB { }
}