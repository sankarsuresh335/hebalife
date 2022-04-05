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
    public class DeliveryAddressPersonalPage_BE : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}/RSO";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@class='order-content checkout']//*[@id='btn-go-checkout']")]
        public IWebElement ProccedToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-continue-checkout']")]
        public IWebElement ProccedToCheckoutFinal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']//*[@class='plus btn-increment']")]
        public IWebElement PlusBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='notification-warning' and @data-bind='invisible: cartSummaryModel.Delivery.Address.IsExperianValidAddress']")]
        public IWebElement InvalidAddressErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='notification-warning' and @data-bind='invisible: cartSummaryModel.Delivery.Address.IsExperianValidPhone']")]
        public IWebElement InvalidPhoneErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='notification-warning' and @data-bind='fadeIn: DisplayExperianInValidPhoneMessageForSaveUpdate']")]
        public IWebElement EditInvalidPhoneErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='notification-warning' and @data-bind='fadeIn: DisplayExperianInValidAddressMessageForSaveUpdate']")]
        public IWebElement EditInvalidAddrErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='price-list-section']//*[@class='btn-add-cart'][1]")]
        public IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactCustomerList']")]
        public IWebElement AddressListCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactCustomerList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtnCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal']//div[@class='button-set']/a[text()='Ajouter une nouvelle adresse']")]
        public IWebElement AddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement ManageAddAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Gestion des adresses')]")]
        public IWebElement ManageAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Adresses sauvegardées')]")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='SingleWarehouseActionButtons']//*[@data-bind='click: SingleWarehouseChangeAddress']")]
        public IWebElement ModifyAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='checkout-form']//a[text()='Modifier']")]
        public IWebElement ChangeAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SingleWarehouseActionButtons']/a[text()='Ajouter une nouvelle adresse']")]
        public IWebElement Add_Addressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-options']//*[@class='address-info']")]
        public IWebElement AddressInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-address']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//small[contains(text(),' Le nombre maximum de caractères pour le prénom et nom est 30 ensemble ')]")]
        public IWebElement FNandLNcombErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='HouseNumber']")]
        public IWebElement HouseNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='singlewh-contact-form']//*[@class='k-widget k-dropdown k-header']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PesonalradioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerradioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='personal-contact-search']")]
        public IWebElement Searchfield { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer-contact-search']")]
        public IWebElement SearchfieldCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer-contact-search']")]
        public IWebElement CustomerSearchfield { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer-toggle']")]
        public IWebElement CustomerTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactCustomerList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedCustomerAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Aucun contact enregistré ne correspond à votre recherche. Veuillez essayer à nouveau.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "(//h4[contains(text(),'Aucun contact enregistré ne correspond à votre recherche. Veuillez essayer à nouveau.')])[2]")]
        public IWebElement SearchWarningMSGCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='btn-address btn-cancel-addnew close-all-forms opp-side'])[2]")]
        public IWebElement EditCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "(//ul[@id='experian-address-input_listbox']/li)[1]")]
        public IWebElement searchList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='experian-address-input']")]
        public IWebElement AddressInputTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Adresse 1:')]/span")]
        public IWebElement AddressInputAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Numéro de la rue:')]/span")]
        public IWebElement HouseNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Indiquer le code postal:')]/span")]
        public IWebElement PostalCodeAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ville:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Prénom:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Numéro de téléphone:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='City']")]
        public IWebElement CityTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Country']")]
        public IWebElement CountryTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: InvalidStreetAlert']")]
        public IWebElement AddressInputerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: showInvalidStreetLength']")]
        public IWebElement AddressAndHouseNumberErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='HouseNumber']")]
        public IWebElement HouseNumbererrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip']")]
        public IWebElement PostalCodeerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City']")]
        public IWebElement CityerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName']")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='shipping-options'])[1]")]
        public IWebElement Shipto { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneNumbererrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='HouseNumber']")]
        public IWebElement HouseNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip']")]
        public IWebElement PostalCodeInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
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

        public void CitySelection(string CityName)
        {
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }

        public void SearchValidAddress(Framework.Address add, bool isValidaddress = false)
        {
            bool isInValidaddressFound = true;
            var cus = MandatryFieldCount("//*[@id='contactList']//div[@class='address-info']");
            if (cus.Count > 0)
            {
                foreach (var val in cus)
                {
                    if (val != null)
                    {
                        this.ScrollIntoView(val);
                        this.ScrollToTop();
                        //val.Click();
                        UseselectedAddressBtn.Click();
                    }
                    this.WaitForElementGone(CommonFindBy.LoadIndicator);
                    if (isValidaddress == true && CommonMethods.IsElementDisplayed(ModifyAddress))
                    {
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(ModifyAddress));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        isValidaddress = true;
                        break;
                    }
                    else if (CommonMethods.IsElementDisplayed(SaveButton) && CommonMethods.IsElementDisplayed(Cancel))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        if (CommonMethods.IsElementDisplayed(ShippingAddrSave))
                        {

                            Shop.Automation.Framework.Address add1 = new Shop.Automation.Framework.Address();
                            add1.FillAddressForEMEA("DJ", "AkashEdit", "SCHERPENHEUVEL-ZICHEM", "Street1", "EDEGEM", "3271", "4545464574");
                            PageExtension.WaitForTimeSpan(1000);
                            PageExtension.WaitForElementPresentAndVisible(this, SaveButton);
                            FirstName.SendKeys(add1.FirstName);
                            LastName.SendKeys(add1.LastName);
                            SearchAddress(add1.Zip);
                            WaitSpinToFalse();
                            PageExtension.WaitForTimeSpan(2000);
                            HouseNumber.SendKeys(add1.Street2);
                            PhoneNumber.SendKeys(add1.PhoneNumber);
                            PageExtension.WaitForTimeSpan(1000);
                            WaitSpinToFalse();
                            SaveButton.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            Driver.WaitForDocumentReady();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            PageExtension.WaitForTimeSpan(2000);
                            PageExtension.WaitForElementPresentAndVisible(this, AddressList);
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
            PageExtension.WaitForTimeSpan(3000);
            if (CommonMethods.IsElementEnabled(ClearCart))
            {
                PageExtension.ScrollElementIntoMiddle(this, ClearCart, 2);
                ClearCart.Click();
            }
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(5000);
            Driver.Navigate().GoToUrl($"{RunSettings.FarmUrl}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}");
            this.WaitForElementPresentAndVisible(PlusBtn);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PlusBtn));
            PlusBtn.Click();
            PageExtension.WaitForTimeSpan(1000);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddtoCartBtn));
            this.WaitForElementPresentAndVisible(AddtoCartBtn, 40);
            PageExtension.WaitForTimeSpan(1000);
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.ScrollElementIntoMiddle(this, AddtoCartBtn, 3);
            this.WaitForElementGone(CommonFindBy.LoadIndicator); 
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", AddtoCartBtn);
            Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(5000);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ProccedToCheckout));
            PageExtension.ScrollIntoView(this, ProccedToCheckout, 5);
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForTimeSpan(5000);
            this.WaitForElementClicklable(ProccedToCheckout, 40);
            ProccedToCheckout.Click();
            WaitSpinToFalse();
            Driver.WaitForDocumentReady();
            PageExtension.WaitForTimeSpan(2000);
            this.WaitForElementPresentAndVisible(AddressList);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddressList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(UseselectedAddressBtn));
        }
        /// <summary>
        /// Methode used for Experian Search
        /// </summary>
        /// <param name="SerachText"></param>
        public void SearchAddress(string SerachText)
        {
            AddressInputTextBox.Clear();
            AddressInputTextBox.SendKeys(SerachText);
            PageExtension.WaitForElementPresentAndVisible(this, searchList);
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(3000);
            searchList.Click();

        }

        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            //Add address
            this.ScrollToTop();
            PageExtension.WaitForTimeSpan(1000);
            AddAddressbtn.Click();
            WaitSpinToFalse();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(3000);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            SearchAddress("Stree");
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            HouseNumber.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PhoneNumber.SendKeys(Keys.Tab);
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
            PageExtension.WaitForTimeSpan(3000);
            EditAddress.Click();
            this.WaitForElementGone(CommonFindBy.LoadIndicator, 40);
            Shop.Automation.Framework.Address add1 = new Shop.Automation.Framework.Address();
            add1.FillAddressForEMEA("DJ", "Akash", "ANTWERPEN", "Street1", "EDEGEM", "5340", "9848002241");
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            //edit address
            WaitSpinToFalse();
            FirstName.Clear();
            FirstName.SendKeys(add1.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.Clear();
            LastName.SendKeys(add1.LastName);
            PageExtension.WaitForTimeSpan(1000);
            AddressInputTextBox.Clear();
            PageExtension.WaitForTimeSpan(1000);
            SearchAddress("Stree");
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(1000);
            HouseNumber.Clear();
            HouseNumber.SendKeys(add1.Street);
            PageExtension.WaitForTimeSpan(1000);
            PhoneNumber.Clear();
            PhoneNumber.SendKeys(add1.PhoneNumber);
            PhoneNumber.SendKeys(Keys.Tab);
            PageExtension.WaitForTimeSpan(1000);
            if (IsCustomer)
                CustomerradioButton.Click();
            PageExtension.WaitForTimeSpan(2000);
            if (iscancelled)
                Cancel.Click();
            else
                SaveButton.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add1;
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

    public class DeliveryAddressPersonalPageTestBE : DeliveryAddressPersonalPage_BE { }

}
