using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_MT : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}/RSO";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@class='floating-checkout']//*[@id='btn-go-checkout']")]
        public IWebElement ProccedToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal']//*[@id='btn-clean-pickup-search']")]
        public IWebElement CloseIocn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']//*[@class='plus btn-increment']")]
        public IWebElement PlusBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='price-list-section']//*[@class='btn-add-cart'][1]")]
        public IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div[1]//a[@class='btn-close btn-change']")]
        public IWebElement UseThisButtonPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactCustomerList']/div[1]//a[@class='btn-close btn-change']")]
        public IWebElement UseThisButtonCust { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal']//div[@class='button-set']/a[text()='Add New Address']")]
        public IWebElement AddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchManageAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']/li")]
        public IWebElement AddressListPERManageAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SingleWarehouseActionButtons']/a[1]")]
        public IWebElement ChangeButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SingleWarehouseActionButtons']/a[2]")]
        public IWebElement AddNewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Find duplicate items')]")]
        public IWebElement DuplicatePopUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//*[@id='Personal']")]
        public IWebElement PersonalAddressType { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//*[@id='Customer']")]
        public IWebElement CustomerAddressType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='click: SingleWarehouseEditAddress']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-toggle']")]
        public IWebElement PersonalTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-contact-search']")]
        public IWebElement PersonalSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal']//*[@data-bind='visible: DisplayContactList']")]
        public IWebElement ManageAddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-customer-list']/h4")]
        public IWebElement ChooseAddressText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='City_listbox']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//*[@class='note']")]
        public IWebElement PostalcodeFormat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//*[@class='note error']")]
        public IWebElement PostalcodeLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-PhoneNumber']")]
        public IWebElement AddressPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerradioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-contact-search']")]
        public IWebElement SearchfieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer-toggle']")]
        public IWebElement CustomerTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ContactsFound']/h4")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[1][@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip']")]
        public IWebElement PostalCodeerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Combination of First Name and Last Name cannot exceed 35 characters')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement ErrorMsgStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='LastName']")]
        public IWebElement ErrorMsgLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),'Phone number is not valid')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='contactCustomerList']/div)[1]/descendant::span[@class='customer-details']")]
        public IWebElement FullNameFirstCustomerContact { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='contactCustomerList']/div)[1]/descendant::span[contains(@class,'Customer')]")]
        public IWebElement CustomerTagFirstContactList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='full-address']")]
        public IWebElement FullAddressAddressCheckoutPage { get; set; }

        public object WebDriver { get; private set; }

        public string InValidAddress_Message = "//*[@class='notification-warning' and  @data-bind='invisible: cartSummaryModel.Delivery.Address.IsExperianValidAddress']";

        public string ValidAddress_Message = "//*[@class='notification-warning' and  @data-bind='invisible: cartSummaryModel.Delivery.Address.IsExperianValidAddress' and @style='display: none;']";


        public void CitySelection(string CityName)
        {
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void NavigateToCheckoutpage()
        {
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            this.WaitForElementPresentAndVisible(ClearCart);
            PageExtension.WaitForTimeSpan(5000);
            if (CommonMethods.IsElementEnabled(ClearCart))
            {
                PageExtension.ScrollElementIntoMiddle(this, ClearCart, 2);
                ClearCart.Click();
            }
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(10000);
            Driver.Navigate().GoToUrl($"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}");
            PageExtension.WaitForTimeSpan(10000);
            this.WaitForElementPresentAndVisible(PlusBtn);
            PageExtension.WaitForTimeSpan(15000);

            //Assert.IsTrue(CommonMethods.IsElementDisplayed(PlusBtn));
            PlusBtn.Click();
            PageExtension.WaitForTimeSpan(5000);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddtoCartBtn));
            this.WaitForElementPresentAndVisible(AddtoCartBtn, 40);
            PageExtension.WaitForTimeSpan(6000);
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.ScrollIntoView(this, AddtoCartBtn, 3);
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(5000);
            AddtoCartBtn.Click();
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(5000);
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", ProccedToCheckout);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            Driver.WaitForDocumentReady();
        }

        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            if (CommonMethods.IsElementDisplayed(UseselectedAddressBtn))
            {
                WaitSpinToFalse();
                Driver.WaitForDocumentReady();
                this.WaitForElementPresentAndVisible(AddressList);
                Assert.IsTrue(CommonMethods.IsElementDisplayed(AddressList));
                Assert.IsTrue(CommonMethods.IsElementDisplayed(UseselectedAddressBtn));
                Driver.WaitForDocumentReady();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            }
            //Add address
            PageExtension.WaitForTimeSpan(5000);
            if (CommonMethods.IsElementDisplayed(AddAddressbtn))
                AddAddressbtn.Click();
            else
                AddNewButton.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(3000);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetTextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            Street2TextBox.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(1000);
            PostalCode.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(2000);
            CitySelection(add.City);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            if (IsCustomer)
                CustomerradioButton.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            if (iscancelled)
                Cancel.Click();
            else
                SaveButton.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 60);
            return add;
        }

        public Framework.Address EditAddressandSave(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            WaitSpinToFalse();
            Shop.Automation.Framework.Address add1 = new Shop.Automation.Framework.Address();
            add.FillAddressForEMEA("DJ", "Akash", "Street", "", "ATTARD", "CCC 6562", "9848992277");
            PageExtension.WaitForTimeSpan(2000);
            EditAddress.Click();
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator, 40);
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            //edit address
            WaitSpinToFalse();
            FirstName.Clear();
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.Clear();
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetTextBox.Clear();
            StreetTextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            PostalCode.Clear();
            PostalCode.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(1000);
            CitySelection(add.City);
            PhoneNumber.Clear();
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            if (IsCustomer)
                CustomerradioButton.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            PageExtension.ScrollElementIntoMiddle(this, SaveButton, 30);
            if (iscancelled)
                Cancel.Click();
            else
                SaveButton.Click();
            PageExtension.WaitForTimeSpan(3000);
            return add;
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

    public class DeliveryAddressPersonalPageTestMT : DeliveryAddressPersonalPage_MT
    {
        public string URL { get; set; }
    }
}