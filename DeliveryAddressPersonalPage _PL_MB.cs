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
   
    public class DeliveryAddressPersonalPage_PL_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//div[@id='locationList']//div[@class='address-info']")]
        public IWebElement AddressList1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='choose-pudo-location']//a[@id='btn-pickup-delivery']")]
        public IWebElement PudoUseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-open-address-form']")]
        public IWebElement AddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Imię jest wymagane')]")]
        public IWebElement FirstNameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName' and contains(text(),'Nazwisko jest wymagane')]")]
        public IWebElement LastNameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),'Ulica, numer domu i mieszkania są wymagane')]")]
        public IWebElement Street1ErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),'Kod pocztowy jest wymagany')]")]
        public IWebElement ZipErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City' and contains(text(),'Miasto jest wymagane')]")]
        public IWebElement CityErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),'Numer telefonu jest wymagany')]")]
        public IWebElement PhoneNumberErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Imię i nazwisko nie mogą przekraczać 40 znaków')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Imię:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Podaj swoje miasto lub kod pocztowy')]")]
        public IWebElement PudoTabTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@placeholder='Wpisz miasto lub kod pocztowy']")]
        public IWebElement PudoSearchWaterMark { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nazwisko:')]/span")]
        public IWebElement LastnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']/option")]
        public IWebElement MilesDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ulica (numer domu i mieszkania):')]/span")]
        public IWebElement Street1Asterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Miasto:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Kod pocztowy:')]/span")]
        public IWebElement ZipAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Numer telefonu:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ship-to-courier']")]
        public IWebElement PudoTabs { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement SelectAddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']//*[@class='address-info'])[1]")]
        public IWebElement PudoAddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Pokaż mapę')]")]
        public IWebElement ShowMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible: Distance']")]
        public IWebElement DistanceinKM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Pokaż lokalizację')]")]
        public IWebElement ShowLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Dostawa na adres')]")]
        public IWebElement ShippingTabs { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customer-ship']//a[@id='btn-default-address-changed']")]
        public IWebElement Shiptothisbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='html: DisplayedInfo']")]
        public IWebElement shopperprof { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='totals']//*[@class='address-info']")]
        public IWebElement ShipToInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement AddSku { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']")]
        public IWebElement PersonalList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='totals']//a[contains(text(),'Zmień')]")]
        public IWebElement ChangeAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Przepraszamy, żadne zapisane kontakty')]")]
        public IWebElement SearchFieldInvalidErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-search-form hl-form']//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PudoSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='last'])[1]")]
        public IWebElement AddressValue { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@src='/Shop/Address/images/InPost.png'])[1]")]
        public IWebElement AddressValueInpostIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//em[@class='icon-magnifier-fl-1']")]
        public IWebElement MagnifierIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']/li")]
        public IWebElement CustomerList { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='address-search-value']")]
        public IWebElement PersonalSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement EditLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Country']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerradioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-info']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-cancel-new-address']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address-edit']")]
        public IWebElement EditCancelAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement DuplicatepopupCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement EditSaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[1][@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btn-save-new-address-edit']")]
        public IWebElement EditAddrSave { get; set; }

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
                    if (isValidaddress == true && CommonMethods.IsElementDisplayed(Shiptothisbtn))
                    {
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditAddress));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        isValidaddress = true;
                        break;
                    }
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        if (CommonMethods.IsElementDisplayed(ShippingAddrSave))
                        {
                            PageExtension.WaitForTimeSpan(1000);
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
                            PostalCode.Clear();
                            PostalCode.SendKeys(add.Zip);
                            PageExtension.WaitForTimeSpan(1000);
                            PhoneNumber.Click();
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            PageExtension.WaitForTimeSpan(1000);
                            WaitSpinToFalse();
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            Driver.WaitForDocumentReady();
                            Shiptothisbtn.Click();
                            WaitSpinToFalse();
                            PageExtension.WaitForTimeSpan(2000);
                            PageExtension.WaitForElementPresentAndVisible(this, shopperprof);
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



        public void AddressList()
        {
            var count = InitializeReadOnlyCollection("//*[@id='savedAddressesList']");
            while (count.Count > 0)
            {
                count = InitializeReadOnlyCollection("//*[@id='savedAddressesList']");
                break;
            }
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

        /// Below Method is used for validating Duplicate popup 
        /// </summary>
        /// <param name="add"></param>
        public void VerifyDuplicatePopUP(Shop.Automation.Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(DuplicatepopupCancel));
            PageExtension.WaitForTimeSpan(2000);
            DuplicatepopupCancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            SaveButton.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Duplicatelist.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled(Overwrite));
            Overwrite.Click();
            PageExtension.WaitForElementPresentAndVisible(this, SaveButton, 5);
            //Search address
            PageExtension.WaitForElementPresentAndVisible(this, SearchField);
            SearchField.Clear();
            SearchField.SendKeys(add.FirstName);
            WaitSpinToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, CustomerList);
        }

        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            PageExtension.WaitForTimeSpan(2000);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }


        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            if (CommonMethods.IsElementDisplayed(UseselectedAddressBtn))
            {
                WaitSpinToFalse();
                Driver.WaitForDocumentReady();
                this.WaitForElementPresentAndVisible(AddressList1);
                Assert.IsTrue(CommonMethods.IsElementDisplayed(AddressList1));
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

    public class DeliveryAddressPersonalPageTestPLMB : DeliveryAddressPersonalPage_PL_MB
    {
        public string URL { get; set; }
    }

}
