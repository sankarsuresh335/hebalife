using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_ES : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='events:{click:AddNewAddress}']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement ManageAddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement SearchWarningMSG { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        [FindsBy(How = How.XPath, Using = "//*[@id='personal-contact-search']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='notification-success'])[2]")]
        public IWebElement AddressaddedsuccessfullyMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Administrar Direcciones')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighbourhood']")]
        public IWebElement Neighbourhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='add-new-address']//*[@aria-owns='City_listbox']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Province']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressIteam { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-go-checkout']")]
        public IWebElement GOToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='experian-address-input']")]
        public IWebElement searchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//ul[@id='experian-address-input_listbox']/li)[1]")]
        public IWebElement searchList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement GetAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Calle:')]/span")]
        public IWebElement AddressInputAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nombre:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ciudad:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ingresa tu Código Postal:')]/span")]
        public IWebElement ZIPAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Provincia:')]/span")]
        public IWebElement Provinceasterick { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Número telefónico:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        public IWebElement LastTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='City']")]
        public IWebElement CityTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Zip']")]
        public IWebElement ZIpTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Province']")]
        public IWebElement ProvinceTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//small[contains(text(),'Por favor agrega la dirección en el espacio.')]")]
        public IWebElement AddressInputerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip']")]
        public IWebElement ZIPerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement CityerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Province']")]
        public IWebElement ProvinceerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement PhoneNumbererrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' El Código Postal no es Inválido.')]")]
        public IWebElement ZIPInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Número telefónico no válido.')]")]
        public IWebElement PhoneNumInvalidErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Lo sentimos, ninguna de las direcciones guardadas coincide con tu búsqueda. Por favor, inténtalo más tarde.')]")]
        public IWebElement Noaddressdisplayed { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='experian-address-input']")]
        public IWebElement AddressInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind = 'fadeIn: DisplayExperianInValidPhoneMessage']")]
        public IWebElement ExperianPhoneMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind = 'fadeIn: DisplayExperianInValidAddressMessage']")]
        public IWebElement ExperianAddressMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-info']")]
        public IWebElement ManageAddress_AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement ManageAddress_SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement CleanSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-role='autocomplete']")]
        public IWebElement AddStreet { get; set; }

        public string InValidAddress_Message = "//*[@class='notification-warning' and  @data-bind='fadeIn: DisplayExperianInValidAddressMessage' and @style='display: block;']";

        public ReadOnlyCollection<IWebElement> webelementsColl;
        
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
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        if (CommonMethods.IsElementDisplayed(ShippingAddrSave))
                        {
                            PageExtension.WaitForTimeSpan(1000);
                            SearchAddress("Rest");
                            FirstName.Clear();
                            FirstName.SendKeys(add.FirstName);
                            LastName.Clear();
                            LastName.SendKeys(add.LastName);
                            PhoneNumber.Clear();
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            WaitSpainToFalse();
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpainToFalse();
                            Driver.WaitForDocumentReady();
                            WaitForAddressList();
                            UseselectedAddress.Click();
                            WaitSpainToFalse();
                            PageExtension.WaitForTimeSpan(2000);
                            PageExtension.WaitForElementPresentAndVisible(this, ShoppersAddr);
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

        public void SelectAddress()
        {
            var val = MandatryFieldCount("//*[@id='MyHerbalifelocationList']/div[@class='address-item']");
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

        public void ValidateshopperprofilePickUP(string Streetvalue, string CityValue, string StateValue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(CityValue) && value.Contains(StateValue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }


        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
            //Assert.IsTrue(ShopperProfileText.Contains(displayName.Text));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Zip));
        }

        //Shopper Profile Validation for Pickup
        public void ValidateshopperprofilePickUp(string expected)
        {
            PageExtension.WaitForTimeSpan(2000);
            Assert.IsTrue(ShoppersAddr.Text.Contains(expected));
        }

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }
        
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
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            AddressInput.SendKeys("Avenida Adolfo Suárez");
            PageExtension.WaitForTimeSpan(2000);
            AddressInput.SendKeys(Keys.ArrowDown);
            AddressInput.SendKeys(Keys.Enter);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
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

        /// <summary>
        /// Methode used for Experian Search
        /// </summary>
        /// <param name="SerachText"></param>
        public void SearchAddress(string SerachText) {
            searchTextBox.Clear();
            searchTextBox.SendKeys(SerachText);
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementPresentAndVisible(this, searchList);
            searchList.Click();
        }
    }
    public class DeliveryAddressPersonalPageTestES : DeliveryAddressPersonalPage_ES { }
}
