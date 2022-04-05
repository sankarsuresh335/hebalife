using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_AT : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}/RSO";

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

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']")]
        public IWebElement CustomerList { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),'Postleitzahl')]")]
        public IWebElement ZIPerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pricing-info']/following-sibling::a[@class='btn-add-cart']")]
        public IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-go-checkout'])[2]")]
        public IWebElement ProccedToCheckout { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='City']")]
        public IWebElement CityTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),' Füllen Sie bitte das Adressfeld aus.')]")]
        public IWebElement StreetformaterrorMsg { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout-form']//*[@data-bind='click: SingleWarehouseAddAddress']")]
        public IWebElement AddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='choose-personal']//a[contains(text(), 'Neue Anschrift hinzufügen')]")]
        public IWebElement PersonalAddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: CustomerContactsFound']/h4")]
        public IWebElement CustomerSearchErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Vor- und Nachname dürfen insgesamt nicht mehr als 30 Zeichen beinhalten')]")]
        public IWebElement FirstnameCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout-form']//*[@data-bind='click: SingleWarehouseChangeAddress']")]
        public IWebElement ChangeAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-options']//*[@class='address-info']")]
        public IWebElement AddressInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout-form']//*[@data-bind='click: SingleWarehouseEditAddress']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel']")]
        public IWebElement AddAddressChkoutBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='HouseNumber']")]
        public IWebElement HouseNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Country']")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PersonalradioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerradioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-contact-search']")]
        public IWebElement Searchfield { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer-contact-search']")]
        public IWebElement CustomerSearchfield { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer-toggle']")]
        public IWebElement CustomerTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-toggle']")]
        public IWebElement PersonalTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactCustomerList']")]
        public IWebElement AddressListCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='cancel-change']")]
        public IWebElement BackToShippingInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='invisible: DisplayMicroServiceContainer']//div[@class='shipping-options']")]
        public IWebElement ShipTo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']/li/div[@class='saved-container']")]
        public IWebElement PersonalListManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/li/div[@class='saved-container']")]
        public IWebElement CustomerListManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactCustomerList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedCustomerAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ContactsFound']/h4")]
        public IWebElement PersonalSearchErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: DisplayContactList']")]
        public IWebElement ManageAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='HouseNumber']")]
        public IWebElement HouseNoFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='Zip']")]
        public IWebElement ZipFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

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

        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void ValidateAttributeContains(string Zip, string Streetvalue, string Cityvalue)
        {
            string value = PostalCode.InputBoxValue();
            string value2 = Street.InputBoxValue();
            string value3 = City.InputBoxValue();
            if (value.Contains(Zip) && value2.Contains(Streetvalue) && value3.Contains(Cityvalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void NavigateToCheckoutpage()
        {
            Driver.Navigate().GoToUrl(AddressPath);
            if (CommonMethods.IsElementDisplayed(AcceptCookies))
            {
                AcceptCookies.Click();
            }
            PageExtension.WaitForTimeSpan(3000);
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            this.WaitForElementPresentAndVisible(ClearCart);
            PageExtension.WaitForTimeSpan(3000);
            if (CommonMethods.IsElementEnabled(ClearCart))
            {
                PageExtension.ScrollElementIntoMiddle(this, ClearCart, 2);
                ClearCart.Click();
            }
            PageExtension.WaitForTimeSpan(3000);
            Driver.Navigate().GoToUrl($"{RunSettings.FarmUrl}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}");
            PageExtension.ScrollIntoView(this, PlusBtn, 5);
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForTimeSpan(3000);
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementClicklable(this, PlusBtn, 30);
            PlusBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddtoCartBtn));
            AddtoCartBtn.Click();
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(3000);
            this.WaitForElementClicklable(ProccedToCheckout, 40);
            this.WaitForElementClicklable(ProccedToCheckout, 40);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ProccedToCheckout));
            PageExtension.ScrollElementIntoMiddle(this, ProccedToCheckout, 5);
            PageExtension.WaitForTimeSpan(3000);
            ProccedToCheckout.Click();
            WaitSpainToFalse();
            Driver.WaitForDocumentReady();
            PageExtension.WaitForTimeSpan(5000);
            this.WaitForElementPresentAndVisible(AddressList);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddressList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(UseselectedAddressBtn));
            UseselectedAddressBtn.Click();
            Driver.WaitForDocumentReady();
            PageExtension.WaitForTimeSpan(5000);
        }

    }

    public class DeliveryAddressPersonalPageTestAT : DeliveryAddressPersonalPage_AT { }

}
