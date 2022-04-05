using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_PA : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public string AddressPathPricelist => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement AddAddress_ManageAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement CleanSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: HasAddresses' and @href='/es-PA/Shop/Address/SavedAddresses/Index/DS']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']/h4")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement SelectAddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber' and @class='k-widget k-tooltip k-tooltip-validation k-invalid-msg']")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighborhood']")]
        public IWebElement Neighborhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div")]
        public IWebElement PickupLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='k-widget k-dropdown k-header']")]
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']/ancestor::li/span[contains(.,'Primer nombre es obligatorio')]")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']/ancestor::li/span[contains(.,'Por favor, ingresa la calle')]")]
        public IWebElement ErrorMsgStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']/ancestor::li/span[contains(.,'Por favor, ingresa la calle')]")]
        public IWebElement ErrorMsgStreet2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']/ancestor::li/span[contains(.,'Por favor, ingresa el nombre del estado')]")]
        public IWebElement ErrorMsgState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']/ancestor::li/span[contains(.,'Por favor, ingresa la Ciudad.')]")]
        public IWebElement ErrorMsgCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighborhood']/ancestor::li/span[contains(.,'Por favor, ingresa la Ubicación.')]")]
        public IWebElement ErrorMsgNeighborhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/ancestor::li/span[contains(.,'Por favor, ingresa el número de Teléfono')]")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/ancestor::li/span/following-sibling::span")]
        public IWebElement WaterMarkPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nombre:')]/span[contains(text(),'*')]")]
        public IWebElement FirstNameAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Dirección 1:')]/span[contains(text(),'*')]")]
        public IWebElement StreetAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Dirección 2:')]/span[contains(text(),'*')]")]
        public IWebElement Street2Asterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Provincia:')]/span[contains(text(),'*')]")]
        public IWebElement StateAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Distrito :')]/span[contains(text(),'*')]")]
        public IWebElement CityAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Corregimiento :')]/span[contains(text(),'*')]")]
        public IWebElement NeighborhoodAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Número de Teléfono:')]/span[contains(text(),'*')]")]
        public IWebElement PhoneNumberAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/following-sibling::span[contains(text(),' Número de teléfono inválido')]")]
        public IWebElement PhoneFormat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.PhoneNumber']")]
        public IWebElement readOnlyPhoneNumberValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']/a/span")]
        public IWebElement shopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='html: shippingSelectedAddress.FullAddress']")]
        public IWebElement fullAddress { get; set; }

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

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void ValidateshopperprofilePickUP(string Streetvalue, string CityValue, string StateValue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(CityValue) && value.Contains(StateValue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
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

        public void SelectOption(string option, bool isState = true, bool isCity = true, bool isEdit = true)
        {
            if (isEdit)
            {
                if (isState)
                {
                    State.SelectDropDownOption(option);
                }
                else if (isCity)
                {
                    City.SelectDropDownOption(option);
                }
                else
                {
                    Neighborhood.SelectDropDownOption(option);
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
                    WaitForAddressList();
                    PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "PANAMA", "PANAMA", "", "99849345", "", "24 DE DICIEMBRE", "08", "");
                    PageExtension.WaitForTimeSpan(2000);
                    if (CommonMethods.IsElementDisplayed(EditLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditLink);
                        EditLink.Click();
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
                        SelectOption(add.State);
                        PageExtension.WaitForTimeSpan(3000);
                        WaitSpinToFalse();
                        SelectOption(add.City, false);
                        PageExtension.WaitForTimeSpan(3000);
                        WaitSpinToFalse();
                        PageExtension.WaitForTimeSpan(2000);
                        SelectOption(add.CEP, false, false);
                        PageExtension.WaitForTimeSpan(3000);
                        WaitSpinToFalse();
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        PhoneNumber.SendKeys(Keys.Tab);
                        if (IsCustomer)
                            CustomerRadioBtn.Click();
                        ShippingAddrSave.Click();
                        PageExtension.WaitForTimeSpan(5000);
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
                WaitSpinToFalse();
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
                        break;
                    }
                }
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
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
        }

        public void ValidateshopperprofilePickUP(string Streetvalue, string CityValue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(CityValue))
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
            //Assert.IsTrue(CommonMethods.IsElementDisplayed( PickUpTab));
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
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectOption(add.City, false);
            WaitSpinToFalse();
            SelectOption(add.CEP, false, false);
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
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectOption(add.City, false);
            PageExtension.WaitForTimeSpan(3000);
            SelectOption(add.CEP, false, false);
            PhoneNumber.SendKeys(add.PhoneNumber);
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
        }

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
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
            WaitSpinToFalse();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
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
            WaitSpinToFalse();
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
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Neighborhood));
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
            Assert.IsTrue(CommonMethods.IsElementDisplayed(NeighborhoodAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PhoneNumberAsterisk));

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
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgNeighborhood));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));
            PageExtension.WaitForTimeSpan(2000);
            //Enter first name and last name click on Save button
            AddAddressBtn.Click();
            FirstName.SendKeys("First Name");
            LastName.SendKeys("Last Name");
            ShippingAddrSave.Click();
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgFirstName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgStreet));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgStreet2));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgState));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgCity));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgNeighborhood));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));
            //Enter all fileds and leave black for first name
            AddAddressBtn.Click();
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "KANKINTU", "NGABE-BUGLE", "", "99849484", "", "GUARIVIARA", "09", "");
            LastName.SendKeys("LastName");
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectOption(add.City, false);
            PageExtension.WaitForTimeSpan(3000);
            SelectOption(add.CEP, false, false);
            PhoneNumber.SendKeys(add.PhoneNumber);
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgFirstName));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgStreet));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgStreet2));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgState));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgCity));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgNeighborhood));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));


        }


        public void SearchStateAuruba()
        {
            var cus = MandatryFieldCount("//*[@id='addressList']//div[@role='option']");
            if (cus.Count > 0)
            {
                foreach (var val in cus)
                {
                    string Stateinfo = string.Empty;
                    if (val != null)
                    {
                        this.ScrollIntoView(val);
                        this.ScrollToTop();
                        PageExtension.WaitForTimeSpan(1000);
                        val.Click();
                        string ele = val.FindElement(By.XPath("//*[@class='address-info']")).Text.ToString().Trim();
                        string[] Statename = Regex.Split(ele, "\r\n");
                        Stateinfo = Statename[2];
                    }
                    this.WaitForElementGone(CommonFindBy.LoadIndicator);
                    if (Stateinfo.Contains("Auruba") && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                    {
                        Assert.IsTrue(true, "Auruba State is Displayed in the Address list");
                        break;
                    }
                    else
                        Assert.IsFalse(false, "Auruba State is Displayed but not opening in Edit Mode");
                }

            }
            else
                Assert.IsFalse(true, "No customer address found");
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
            add.FillAddressforSAMCAM("Tes", "DEEP", "street", "street2", "KANKINTU", "NGABE-BUGLE", "", "99849484111", "", "GUARIVIARA", "09", "");
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectOption(add.City, false);
            PageExtension.WaitForTimeSpan(3000);
            SelectOption(add.CEP, false, false);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsFalse(CommonMethods.IsElementDisplayed(PhoneFormat));
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            String phNumber = readOnlyPhoneNumberValue.Text;
            Assert.AreEqual(phNumber, "99849484");
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
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
            TextFieldCount(Street2, 60, "r7493hfh4392ruowejrooerjewjrlwejrwlr;wle45435345435435trrtre;wle1");
        }
        public void TextFieldCount(IWebElement webEle, int Count, string Actvalue)
        {
            webEle.SendKeys(Actvalue);
            int ActualCount = webEle.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }
        public void ShopperProfileContains(string display_Name, Framework.Address add)
        {
            string ShopperProfileText = shopperProfile.Text;
            Assert.IsTrue(ShopperProfileText.Contains(display_Name));
            //Assert.IsTrue(ShopperProfileText.Contains(displayName.Text));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }

    }
    public class DeliveryAddressPersonalPageTestPA : DeliveryAddressPersonalPage_PA { }
}
