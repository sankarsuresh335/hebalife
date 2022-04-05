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
    public class DeliveryAddressPersonalPageTest_TW_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Cart/Checkout/Index/{RunSettings.ValidUser.Schema}/RSO";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-address-delete']")]
        public IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-contact-search']")]
        public IWebElement SearchContactTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div[1]//a[@class='btn-close btn-change']")]
        public IWebElement UseThisButtonPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-customer-list']//*[@data-bind='events:{click:addNewContact}']")]
        public IWebElement AddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'名字:')]/span")]
        public IWebElement FirstNameAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'街道:')]/span")]
        public IWebElement StreetAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'縣市:')]/span")]
        public IWebElement StateAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'地區:')]/span")]
        public IWebElement CityAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'輸入你的郵遞區號:')]/span")]
        public IWebElement ZipCodeAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'電話號碼:')]/span")]
        public IWebElement PhoneNumberAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal']//*[@data-bind='visible: DisplayContactList']")]
        public IWebElement ManageAddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SingleWarehouseActionButtons']/a[1]")]
        public IWebElement ChangeButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@data-bind,'SingleWarehouseAddAddress')]")]
        public IWebElement AddNewAddressButtonCheckoutPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchfieldClose { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-address']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//*[@aria-owns='State_listbox']")]
        public IWebElement StateDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//*[@aria-owns='City_listbox']")]
        public IWebElement CityDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']/descendant::a[@id='btn-cancel-new-address' and contains(@data-bind,'cancelAddContact')]")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']/descendant::a[@id='btn-cancel-new-address' and contains(@data-bind,'cancelEditContact')]")]
        public IWebElement CancelButtonEditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='address-info']/span)[1]")]
        public IWebElement FullAddressInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='contactList']/descendant::div[@class='address-info'])[1]/descendant::span[@class='customer-details']")]
        public IWebElement FirstAddressFullName { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='contactList']/descendant::div[@class='address-info'])[1]/descendant::div")]
        public IWebElement FirstAddressPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='address-recipient']")]
        public IWebElement FullNameSelectedAddressCheckoutPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='full-address']")]
        public IWebElement FullSelectedAddressCheckoutPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='address-PhoneNumber']")]
        public IWebElement PhoneNumberSelectedAddressCheckoutPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='invisible: ContactsFound']/h4")]
        public IWebElement EmptyContactList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement ErrorMsgStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='State']")]
        public IWebElement ErrorMsgState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement ErrorMsgCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip']")]
        public IWebElement ErrorMsgPostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PesonalRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type customer']")]
        public IWebElement CustomerTag { get; set; }

        public object WebDriver { get; private set; }

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void StateSelection(string Statename)
        {
            PageExtension.WaitForTimeSpan(2000);
            StateDropdown.Click();
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(Statename)).Click();
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
        }

        public void CitySelection(string CityName)
        {
            PageExtension.WaitForTimeSpan(2000);
            CityDropdown.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(3000);
        }

        public Framework.Address AddAddress(Framework.Address add, bool iscancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForTimeSpan(3000);
            if (CommonMethods.IsElementDisplayed(AddAddressbtn))
                AddAddressbtn.Click();
            else
                AddNewAddressButtonCheckoutPage.Click();
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            PageExtension.WaitForTimeSpan(2000);

            // Enter First Name
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);

            // Enter Last Name
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);

            // Enter Street address
            StreetTextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);

            // Select State
            StateSelection(add.State);

            // Select City
            CitySelection(add.City);

            // Enter Phone Number
            PhoneNumber.SendKeys(add.PhoneNumber);
            WaitSpinToFalse();
            if (iscancelled)
                CancelButton.Click();
            else
                SaveButton.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            return add;
        }

        public Framework.Address EditAddressSaveCancel(Framework.Address add, bool iscancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForTimeSpan(3000);
            EditAddress.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            WaitSpinToFalse();

            // Clear and enter First Name
            FirstName.Clear();
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);

            // Clear and enter Last Name
            LastName.Clear();
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);

            // Clear and enter Street address
            StreetTextBox.Clear();
            StreetTextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);

            // Select State
            StateSelection(add.State);

            // Select City
            CitySelection(add.City);

            // Enter Phone Number
            PhoneNumber.Clear();
            PageExtension.WaitForTimeSpan(1000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            WaitSpinToFalse();
            if (iscancelled)
                CancelButtonEditAddress.Click();
            else
                SaveButton.Click();
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            return add;
        }

        public string GetFirstNameFromFirstSavedAddress()
        {
            if (! CommonMethods.IsElementDisplayed(UseselectedAddressBtn))
            {
                WaitSpinToFalse();
                Driver.WaitForDocumentReady();
                PageExtension.WaitForElementPresentAndVisible(this, AddressList);
                Assert.IsTrue(CommonMethods.IsElementDisplayed(AddressList));
                Assert.IsTrue(CommonMethods.IsElementDisplayed(UseselectedAddressBtn));
            }

            string FirstName = FirstAddressFullName.Text.Trim().Split(' ').FirstOrDefault();
            return FirstName;
        }

        public void SearchNewlyAddedAddress(string searchText)
        {
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForElementPresentAndVisible(this, SearchContactTextBox);
            SearchContactTextBox.Clear();
            SearchContactTextBox.SendKeys(searchText);
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
        }

        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            ReadOnlyCollection<IWebElement> webelements_Coll = new List<IWebElement>().AsReadOnly();
            try
            {
                webelements_Coll = Driver.FindElements(By.XPath(xPath));
            }
            catch (NoSuchElementException ex)
            {

            }
            return webelements_Coll;
        }
    }

    public class DeliveryAddressPersonalPage_TW_MB : DeliveryAddressPersonalPageTest_TW_MB { }
}