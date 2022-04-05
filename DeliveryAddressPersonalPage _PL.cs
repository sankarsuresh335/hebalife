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
   
    public class DeliveryAddressPersonalPage_PL : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-go-checkout'])[2]")]
        public IWebElement ProccedToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']//*[@class='plus btn-increment']")]
        public IWebElement PlusBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='price-list-section']//*[@class='btn-add-cart'][1]")]
        public IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='locationList']//div[@class='address-info']")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']//div[@class='address-info'])[1]")]
        public IWebElement AddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-open-address-form']")]
        public IWebElement AddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Podaj swoje miasto lub kod pocztowy')]")]
        public IWebElement PUDOSearchboxMsgs { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-address-edit'])[1]")]
        public IWebElement ManageAddressEdit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ship-to-courier']")]
        public IWebElement PudoTabs { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='select-miles-away']/option")]
        public IWebElement PudoMilesDropdownlist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@id='btn-pickup-delivery'][@disabled='disabled']")]
        public IWebElement PudoUsethisSelectedBtnDisabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement PudoUsethisSelectedBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Przepraszamy, nie znaleziono miejsc odbioru')]")]
        public IWebElement PudoErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='pickupSearch']")]
        public IWebElement PudoSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@class='icon-magnifier-fl-1']")]
        public IWebElement PudoSearchMagnifierIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@src='/Shop/Address/images/InPost.png'])[1]")]
        public IWebElement AddressValueInpostIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@id='btn-clean-pickup-search']")]
        public IWebElement PudoSearchCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Pokaż mapę')]")]
        public IWebElement PudoViewMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Pokaż lokalizację')]")]
        public IWebElement PudoShowLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='wrapper']//div[@wire-model='OrderIntention']")]
        public IWebElement PudoShopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//div[@class='address-info']")]
        public IWebElement PudoAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-bind='click: selectPUDelivery, enabled: SelectedPickup']")]
        public IWebElement UseSelectPickupButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Podaj swoje miasto lub kod pocztowy i znajdź najbliższe miejsce odbioru.')]")]
        public IWebElement PudoStaticMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customer-ship']//a[@id='btn-default-address-changed']")]
        public IWebElement Shiptothisbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Zarządzaj adresami')]")]
        public IWebElement ManageAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-add-new-address']")]
        public IWebElement ManageAddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='html: DisplayedInfo']")]
        public IWebElement shopperprof { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchManageAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']/li")]
        public IWebElement AddressListPERManageAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SingleWarehouseActionButtons']/a[2]")]
        public IWebElement AddNewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Znaleziono duplikaty')]")]
        public IWebElement DuplicatePopUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }
       
        [FindsBy(How = How.XPath, Using = "(//div[@class='address-info']//*[@class='type Customer'])[1]")]
        public IWebElement CustomerAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='address-search-value']")]
        public IWebElement PersonalSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Zarządzaj adresami')]")]
        public IWebElement ManageAddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Wybierz adres dostawy')]")]
        public IWebElement ChooseAddressText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerradioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-cancel-new-address']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Przepraszamy, żadne zapisane kontakty nie pasują do twojego wyszukiwania. Proszę spróbuj ponownie.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Przepraszamy, żadne zapisane kontakty')]")]
        public IWebElement SearchWarningMSGCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[1][@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btn-save-new-address-edit']")]
        public IWebElement EditAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='City']")]
        public IWebElement CityTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip']")]
        public IWebElement PostalCodeerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Imię i nazwisko nie mogą przekraczać 40 znaków')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement ErrorMsgFirstName { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip']")]
        public IWebElement ErrorMsgZip { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement ErrorMsgStreet { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='LastName']")]
        public IWebElement ErrorMsgLastName { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement ErrorMsgCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactCustomerList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedCustomerAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Przepraszamy, żadne zapisane kontakty')]")]
        public IWebElement PersonalSearchErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: CustomerContactsFound']/h4")]
        public IWebElement CustomerSearchErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Numer telefonu jest nieprawidłowy')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }
        public object WebDriver { get; private set; }


        public string InValidAddress_Message = "//*[@class='notification-warning' and  @data-bind='invisible: cartSummaryModel.Delivery.Address.IsExperianValidAddress']";

        public string ValidAddress_Message = "//*[@class='notification-warning' and  @data-bind='invisible: cartSummaryModel.Delivery.Address.IsExperianValidAddress' and @style='display: none;']";

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


        public void ValidateAttributeContains(string Zipexpvalue, string FirstNameexpvalue2, string Cityexpvalue3)
        {
            string Postalcodevalue = PostalCode.InputBoxValue();
            string FirstNamevalue2 = FirstName.InputBoxValue();
            string Cityvalue3 = City.InputBoxValue();
            if (Zipexpvalue.Contains(Zipexpvalue) && FirstNamevalue2.Contains(FirstNameexpvalue2) && Cityvalue3.Contains(Cityexpvalue3))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
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
                AddAddressbtn.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(3000);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetTextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            City.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(1000);
            PostalCode.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(1000);
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
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }

        public Framework.Address EditAddressandSave(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            WaitSpinToFalse();
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
            City.Clear();
            City.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(1000);
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
                EditAddrSave.Click();
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

    public class DeliveryAddressPersonalPageTestPL : DeliveryAddressPersonalPage_PL
    {
        public string URL { get; set; }
    }

}
