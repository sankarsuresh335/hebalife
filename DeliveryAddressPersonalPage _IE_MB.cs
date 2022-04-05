using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_IE_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}/RSO";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Zip']")]
        public IWebElement ZIpTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']//*[@class='plus btn-increment']")]
        public IWebElement PlusBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement PersonalList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-toggle']")]
        public IWebElement PersonalTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout-form']//*[@data-bind='click: SingleWarehouseAddAddress']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pricing-info']/following-sibling::a[@class='btn-add-cart']")]
        public IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='right-content']//*[@id='btn-go-checkout']")]
        public IWebElement ProccedToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='html: DisplayName']")]
        public IWebElement SendtoAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='html: FullAddress']")]
        public IWebElement SendtoAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='address - PhoneNumber']")]
        public IWebElement SendtoAddress2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout-form']//*[@data-bind='click: SingleWarehouseChangeAddress']")]
        public IWebElement ChangeAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout-form']//*[@data-bind='click: SingleWarehouseEditAddress']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel']")]
        public IWebElement PersonalAddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(), 'Versenden an:')]")]
        public IWebElement SendtoLabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='new-customer customer-list-singlewh']")]
        public IWebElement CustomerTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='invisible: DisplayMicroServiceContainer']//div[@class='shipping-options']")]
        public IWebElement ShipTo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'No Contacts Found')]")]
        public IWebElement Searchwarningmsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-address-delete']")]
        public IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-options']//*[@class='btn-address']")]
        public IWebElement Editoption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Country']")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PersonalradioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-contact-search']")]
        public IWebElement Searchfield { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchClose { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='note error']")]
        public IWebElement FnameLnameCombinationError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='Zip']")]
        public IWebElement ZipFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='State']")]
        public IWebElement CountyFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-pcx-bom-promotion']//*[@data-bind='click: AddRemoveBomItemToCart']")]
        public IWebElement FreeItem { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='notification-info-pc']/a)[1]")]
        public IWebElement Addgift { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='unselectedItem'])[1]")]
        public IWebElement SelectItem { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-cancel-new-address'])[2]")]
        public IWebElement EditCancelBtn{ get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='btn-continue'])[4]")]
        public IWebElement AddgiftContinueBtn { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='modal-pcx-bom-promotion']//*[@class='btn-continue']")]
        public IWebElement FreeItemContinue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//*[@data-bind='click: cancelAddContact, invisible:IsEditMode']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-customer-list']//*[@data-bind='events:{click:addNewContact}']")]
        public IWebElement AddnewAddressbtninmicroservice { get; set; }


        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
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


        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(5000);
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            //Shop.Automation.Framework.Address add = CreateObject();
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            Street2.SendKeys(add.Street2);
            City.SendKeys(add.City);
            County.SendKeys(add.State);
            WaitSpainToFalse();
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            return add;
        }


        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        public void NavigateToCheckoutpage()
        {
            Driver.Navigate().GoToUrl(AddressPath);
            if (CommonMethods.IsElementDisplayed(AcceptCookies))
            {
                AcceptCookies.Click();
            }
            PageExtension.WaitForTimeSpan(2000);
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            this.WaitForElementPresentAndVisible(ClearCart);
            PageExtension.WaitForTimeSpan(2000);
            if (CommonMethods.IsElementEnabled(ClearCart))
            {
                PageExtension.ScrollElementIntoMiddle(this, ClearCart, 2);
                ClearCart.Click();
            }
            PageExtension.WaitForTimeSpan(2000);
            Driver.Navigate().GoToUrl($"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}");
            this.WaitForElementPresentAndVisible(PlusBtn);
            PageExtension.WaitForTimeSpan(1000);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PlusBtn));
            PageExtension.WaitForTimeSpan(2000);
            PlusBtn.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddtoCartBtn));
            AddtoCartBtn.Click();
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(2000);
            this.WaitForElementClicklable(ProccedToCheckout, 40);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ProccedToCheckout));
            PageExtension.ScrollElementIntoMiddle(this, ProccedToCheckout, 5);
            PageExtension.WaitForTimeSpan(3000);
            ProccedToCheckout.Click();
            PageExtension.WaitForTimeSpan(2000);
            if (CommonMethods.IsElementDisplayed(Addgift))
            {
                Addgift.Click();
                PageExtension.WaitForTimeSpan(4000);
                this.WaitForElementGone(CommonFindBy.LoadIndicator);
                SelectItem.Click();
                PageExtension.WaitForTimeSpan(2000);
                AddgiftContinueBtn.Click();
            }
            WaitSpainToFalse();
            PageExtension.WaitForTimeSpan(5000);
            ProccedToCheckout.Click();
            Driver.WaitForDocumentReady();
            this.WaitForElementPresentAndVisible(AddressList);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddressList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(UseselectedAddressBtn));
            UseselectedAddressBtn.Click();
        }

    }

    public class DeliveryAddressPersonalPageTestIEMB : DeliveryAddressPersonalPage_IE_MB { }

}
