using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_GT : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@id='addressList']//div[@class='address-info'])[1]")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']//div[@class='address-info'])[1]")]
        public IWebElement PickupSelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']//div[@class='address-info'])[2]")]
        public IWebElement PickupSelectAddress2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-pickup-delivery'])[1]")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }   

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighborhood']")]
        public IWebElement Neighborhood { get; set; }

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

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='State']/ancestor::li/span[contains(.,'Por favor, proporcione el Departamento.')]")]
        public IWebElement ErrorMsgState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']/ancestor::li/span[contains(.,'Por favor, proporcione el Municipio.')]")]
        public IWebElement ErrorMsgCity { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/ancestor::li/span[contains(.,'Por favor, propocione el Número Telefónico.')]")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/ancestor::li/span/following-sibling::span")]
        public IWebElement WaterMarkPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nombre:')]/span[contains(text(),'*')]")]
        public IWebElement FirstNameAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Dirección 1:')]/span[contains(text(),'*')]")]
        public IWebElement StreetAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Departamento:')]/span[contains(text(),'*')]")]
        public IWebElement StateAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Municipio:')]/span[contains(text(),'*')]")]
        public IWebElement CityAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Número de teléfono:')]/span[contains(text(),'*')]")]
        public IWebElement PhoneNumberAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/following-sibling::span[contains(text(),'Por favor, ingrese el número de teléfono en el formato correcto.')]")]
        public IWebElement PhoneFormat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.PhoneNumber']")]
        public IWebElement readOnlyPhoneNumberValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']/a/span")]
        public IWebElement shopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='html: shippingSelectedAddress.FullAddress']")]
        public IWebElement fullAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']/ancestor::li/span[contains(.,'El Nombre solo permite alfabetos.')]")]
        public IWebElement invalidUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']/ancestor::li/span[contains(.,'El Apellido solo permite alfabetos.')]")]
        public IWebElement invalidLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement AddAddress_ManageAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement NoAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement PersonalList_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']")]
        public IWebElement CustomerList_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchField_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-clean-pickup-search'])[1]")]
        public IWebElement DeliverySearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement Addresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='address-info'])[2]")]
        public IWebElement Address2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='button-set']/a[@class='close-reveal-modal btn-delete'])[4]")]
        public IWebElement DeleteConfirm{ get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressSavedCorrectly')]")]
        public IWebElement AddressSavedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressUpdatedCorrectly')]")]
        public IWebElement AddressUpdatedSuccessfullyNotification { get; set; }

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

        public void ValidateAttributeContains(string Neighbourhoodvalue, string Cityvalue, string Statevalue)
        {
            
            string value = City.InputBoxValue();
            string value2 = State.InputBoxValue();
            string value3 = Neighborhood.InputBoxValue();
            if (value.Contains(Cityvalue) &&  value2.Contains(Statevalue) && value3.Contains(Neighbourhoodvalue))
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

        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void SelectMilesOption(string option)
        {
            PickUPDdnSearch.SelectDropDownOption(option);
        }

        public void StateSelection(string StateName)
        {
            Region.Click();
            var Citylist = InitializeReadOnlyCollection("//ul[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
        }

        public void SelectOption(string option, bool isState = true, bool isCity=true, bool isEdit = true)
        {
            if (isEdit)
            {
                if (isState)
                {
                    State.SelectDropDownOption(option);
                }
                else if(isCity)
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
        public void SearchAndEdit(Framework.Address add, bool IsCustomer = false)
        {

            //Select address from list and Edit address
            var count1 =  InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.State) && ele.Contains(add.City))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");

                    string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                    if (ele1 != null)
                        Assert.IsTrue(true);
                    else
                        Assert.IsFalse(true, "No tag found");

                     WaitForAddressList();
                     PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("Fname", "Lname", "street", "street2", "MONJAS", "JALAPA", "", "99849345");
                    PageExtension.WaitForTimeSpan(2000);
                    if (CommonMethods.IsElementDisplayed( EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this,EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this,ShippingAddrSave);
                        FirstName.Clear();
                        add.FirstName = RandomString(4, false);
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
                        WaitSpainToFalse();
                        SelectOption(add.City, false);
                        PageExtension.WaitForTimeSpan(3000);
                        WaitSpainToFalse();
                        PageExtension.WaitForTimeSpan(2000);
                        //SelectOption(add.CEP, false, false);
                        //PageExtension.WaitForTimeSpan(3000);
                        //WaitSpainToFalse();
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        PhoneNumber.SendKeys(Keys.Tab);
                        ShippingAddrSave.Click();
                        PageExtension.WaitForTimeSpan(3000);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                        WaitForAddressList();
                        Assert.IsTrue(true, "Address successfully Edited");
                        break;
                    }
                    else
                        Assert.IsFalse(true, "No address found");
                }
                //Edited address validation and Ship to same address
                 PageExtension.WaitForElementPresentAndVisible(this,SearchFieldPersonal);
                 SearchFieldPersonal.Clear();
                 SearchFieldPersonal.SendKeys(add.FirstName);
                 WaitSpainToFalse();
                 WaitForAddressList();
                var count =  InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
                if (count != null && count.Count > 0)
                {
                    foreach (var item in count)
                    {
                        string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;
                        if (ele.Contains(add.FirstName) && ele.Contains(add.State) && ele.Contains(add.City))
                            Assert.IsTrue(true, "The address is successfully Edited");
                        else
                            Assert.IsTrue(false, "Address is not Matching");

                        string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                        if (ele1 != null)
                            Assert.IsTrue(true);
                        else
                            Assert.IsFalse(true, "No tag found");
                        break;
                    }
                }
                 PersonalAddrList.Click();
                if (CommonMethods.IsElementDisplayed( ShiptothisBut))
                {
                    string fullName = displayName.Text;
                    PageExtension.WaitForElementPresentAndVisible(this,ShiptothisBut);
                    PageExtension.WaitForTimeSpan(2000);
                     ShiptothisBut.Click();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                     Driver.WaitForDocumentReady();
                    PageExtension.WaitForTimeSpan(5000);
                     PageExtension.WaitForElementPresentAndVisible(this,ShoppersAddr);
                     Driver.WaitForDocumentReady();
                    ShopperProfileContains(fullName, add);
                }
                else
                    Assert.IsFalse(false, "No address found");
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
            PageExtension.WaitForElementPresentAndVisible(this,SearchFieldPersonal);
             SearchFieldPersonal.SendKeys(FirstName);
             WaitSpainToFalse();
             WaitForAddressList();

        }
        

        public void RefreshAndSearchAddress(Framework.Address add)
        {
            Driver.Navigate().Refresh();
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
            SearchAddres.Click();
            Assert.IsTrue(PageExtension.WaitForElementPresentAndEnable(this, EditInformation));

        }

        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this,CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this,PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed( ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( AddAddressBtn));
            //Add address
             AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this,PersonalRdoBtn);
            add.FirstName = RandomString(4, false);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            SelectOption(add.City, false);
            WaitSpainToFalse();
            SelectOption(add.CEP, false,false);
            PhoneNumber.SendKeys(add.PhoneNumber);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }

        public void ValidateshopperprofilePickUP(string Streetvalue, string CityValue, string StateValue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(CityValue) && value.Contains(StateValue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
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
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(CancelAddAddress))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        if (CommonMethods.IsElementDisplayed(ShippingAddrSave))
                        {
                            PageExtension.WaitForTimeSpan(1000);
                            add.FirstName = RandomString(4, false);
                            FirstName.SendKeys(add.FirstName);
                            LastName.SendKeys(add.LastName);
                            Street.SendKeys(add.Street);
                            Street2.SendKeys(add.Street2);
                            PageExtension.WaitForTimeSpan(2000);
                            SelectOption(add.State);
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpainToFalse();
                            SelectOption(add.City, false);
                            WaitSpainToFalse();
                            SelectOption(add.CEP, false, false);
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            PageExtension.WaitForTimeSpan(3000);
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpainToFalse();
                            Driver.WaitForDocumentReady();
                            WaitForAddressList();
                            ShiptothisBut.Click();
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

        /// <summary>
        /// Below Method is used for adding Duplicate data to System 
        /// </summary>
        /// <param name="add"></param>
        public void AddedDuplicateAddress(Framework.Address add)
        {
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this,PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            SelectOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            SelectOption(add.City, false);
            PageExtension.WaitForTimeSpan(3000);
            SelectOption(add.CEP, false, false);
            PhoneNumber.SendKeys(add.PhoneNumber);
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
        }
        
        /// <summary>
        /// Below Method is used for validating Duplicate popup 
        /// </summary>
        /// <param name="add"></param>
        public void VerifyDuplicatePopUp(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this,Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementPresentAndVisible(this,Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Duplicatelist.Click();
            PageExtension.WaitForElementPresentAndVisible(this,Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled(Overwrite));
            Overwrite.Click();
            PageExtension.WaitForElementPresentAndVisible(this,ShippingAddrSave, 5);
            //Search Address
            PageExtension.WaitForElementPresentAndVisible(this,SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }
        
        /// <summary>
        ///  Generate a random string with a given size
        /// </summary>
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
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

        public void ShopperProfileContainsforPickUP(string addressValue)
        {
            string ShopperProfileText = shopperProfile.Text;
            Assert.IsTrue(ShopperProfileText.Contains(addressValue));           
        }

        public string SelectValidPersonalSavedAddressToEdit()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            string FullNameSelectedSavedPersonalAddress = string.Empty;
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);
                if (! CommonMethods.IsElementDisplayed(ShippingAddrSave) && ! CommonMethods.IsElementDisplayed(CancelAddAddress))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalTag));
                    FullNameSelectedSavedPersonalAddress = displayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedPersonalAddress;
        }

        public string SelectValidCustomerSavedAddressToEdit()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> customerContactList = Driver.FindElements(By.XPath("//*[@class='type Customer']"));
            string FullNameSelectedSavedCustomerAddress = string.Empty;
            new Actions(Driver).MoveToElement(CustomerTag).Perform();
            for (int i = 0; i <= customerContactList.Count; i++)
            {
                customerContactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 60);
                PageExtension.WaitForTimeSpan(1000);
                if (! CommonMethods.IsElementDisplayed(ShippingAddrSave) && ! CommonMethods.IsElementDisplayed(CancelAddAddress))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(CustomerTag));
                    FullNameSelectedSavedCustomerAddress = displayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedCustomerAddress;
        }

    }
    public class DeliveryAddressPersonalPageTestGT : DeliveryAddressPersonalPage_GT { }
}