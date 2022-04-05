using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_CL : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickupDistanceDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewonMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='address-pickup-filter']//i[@class='icon-magnifier-fl-1']")]
        public IWebElement PickupSearchMagnifier { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='total-locations']")]
        public IWebElement Total_Locations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-addresses']//*[@data-bind='fadeIn: AddressSavedCorrectly']")]
        public IWebElement AddressSavedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-addresses']//*[@data-bind='fadeIn: AddressUpdatedCorrectly']")]
        public IWebElement AddressUpdatedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='fadeIn: DisplayExperianInValidPhoneMessage']")]
        public IWebElement ExperionInvalidPhoneNumberWarning { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='fadeIn: DisplayExperianInValidEmailMessage']")]
        public IWebElement ExperionInvalidEmailWarning { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'State_listbox')])[1]")]
        public IWebElement State { get; set; } 

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'City_listbox')])[1]")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'County_listbox')])[1]")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'Zip_listbox')])[1]")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and @class='k-widget k-tooltip k-tooltip-validation k-invalid-msg']")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Correo electrónico:')]//*[@class='color-red']")]
        public IWebElement EmailAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-select use-this']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer-direct-customer-address']//*[@class='btn-select use-this']")]
        public IWebElement CustomerShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='click: EditShippingAddress, visible:IsValidContact']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-edit opp-side']")]
        public IWebElement EditCustomerAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[2]")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-item']")]
        public IWebElement AddressSelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-info']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickup-search-value']")]
        public IWebElement PickupSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='County']")]
        public IWebElement NeighborhoodFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ContactNameMaxLengthAlert']")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='EmailAddress']")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='EmailAddress']")]
        public IWebElement EmailErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-item']")]
        public IWebElement DeliveryoptionSelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Zip']")]
        public IWebElement PostalCodeFieldError { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.PhoneNumber']")]
        public IWebElement readOnlyPhoneNumberValue { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement MileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement GoogleSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement GoogleSearchButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[1]")]
        public IWebElement btbShowMap { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[2]")]
        public IWebElement btbViewLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement PickupAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']/div)[1]//div[@class='last']")]
        public IWebElement PickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-clean-pickup-search'])[2]")]
        public IWebElement CleanSearchPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement CleanSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']/h4")]
        public IWebElement AddressInvalidMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='note error']")]
        public IWebElement NameCombinationMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement AddAddressManageAddressPage { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind= 'invisible: firstPULoad']")]
        public IWebElement PickUpErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class= 'address-content']/p/font")]
        public IWebElement AddressMsg { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-delete-contact']//*[@class='close-reveal-modal btn-delete']")]
        public IWebElement DeleteConfirmCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-info']")]
        public IWebElement DeliveryAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='fadeIn: IsPhoneMatchedWithBlackListForSaveUpdate']")]
        public IWebElement BlockedPhone { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='fadeIn: IsEmailMatchedWithBlackListForSaveUpdate']")]
        public IWebElement BlockedEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='html: shippingSelectedAddress.DisplayName']")]
        public IWebElement DisplayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='notification-error' and @data-bind='fadeIn: IsAddressMatchedWithHrblLocationForSaveUpdate']")]
        public IWebElement HBLBlockMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='notification-error' and @data-bind='fadeIn: IsCustomerNameMatchedWithComplianceForSaveUpdate']")]
        public IWebElement BlockedCustAddFnameMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='notification-error' and @data-bind='fadeIn: IsCustomerNameMatchedWithComplianceForSaveUpdate']")]
        public IWebElement BlockedCustEditFnameMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: IsValidContact']//*[@data-bind='fadeIn: IsDisplayCsAsDSMessage']")]
        public IWebElement CSasDSMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']")]
        public IWebElement CustomerList { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'No se encontró ningún contacto')]")]
        public IWebElement CustomerSearchWrngMsg { get; set; }

        public string DeliveryPage => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/Ds";

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
        public void ValidateshopperprofilePickUP(string Streetvalue, string Street2value)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(Street2value))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void SelectAddress()
        {
            var val = MandatryFieldCount("//*[@id='locationList']");
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
        public void WaitSpinToFalse()
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

        /// <summary>
        /// Below Method is use for Searching and Edit Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        /// <param name="IsCustomer"></param>
        public void SearchAndEdit(Framework.Address add, bool IsCustomer = false)
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

                    if (IsCustomer)
                    {
                        string ele1 = Driver.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']")).Text;
                        if (ele1 != null)
                            Assert.IsTrue(true);
                        else
                            Assert.IsFalse(true, "No tag found");
                    }
                    else
                    {
                        string ele1 = Driver.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']")).Text;
                        if (ele1 != null)
                            Assert.IsTrue(true);
                        else
                            Assert.IsFalse(true, "No tag found");
                    }
                    //string ele2 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                    
                    WaitForAddressList(); 
                    PageExtension.WaitForTimeSpan(2000);
                    PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("Fname_New", "Lname_New", "street_New", "street2_New", "CAUTIN", "ARAUCANIA", "4890000", "998494849", "CUNCO");
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        Street.Clear();
                        Street.SendKeys(add.Street);
                        Street2.Clear();
                        Street2.SendKeys(add.Street2);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        SelectStateOption(add.State);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        SelectCityOption(add.City);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        SelectColonyOption(add.StreetNumber);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        WaitSpinToFalse();
                        if (IsCustomer == false)
                        {
                            CustomerRadioBtn.Click();
                            IsCustomer = true;
                        }
                        else
                        {
                            PersonalRdoBtn.Click();
                            IsCustomer = false;
                        }
                        ShippingAddrSave.Click();
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        //WaitForAddressList();
                        Assert.IsTrue(true, "Address successfully Edited");
                        break;
                    }
                    else
                        Assert.IsFalse(true, "No address found");
                }
                //Edited address validation and Ship to same address
                //PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
                Driver.Navigate().Refresh();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
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

                        //string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                        if (IsCustomer)
                        {
                            string ele1 = Driver.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']")).Text;
                            if (ele1 != null)
                                Assert.IsTrue(true);
                            else
                                Assert.IsFalse(true, "No tag found");
                        }
                        else
                        {
                            string ele1 = Driver.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']")).Text;
                            if (ele1 != null)
                                Assert.IsTrue(true);
                            else
                                Assert.IsFalse(true, "No tag found");
                        }
                        break;
                    }
                }
                PersonalAddrList.Click();
                PageExtension.WaitForTimeSpan(2000);
                DeliveryoptionSelectAddress.Click();
                PageExtension.WaitForTimeSpan(2000);
                if (CommonMethods.IsElementDisplayed(ShiptothisBut))
                {
                    PageExtension.WaitForElementPresentAndVisible(this, ShiptothisBut);
                    PageExtension.WaitForTimeSpan(1000);
                    ShiptothisBut.Click();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    Driver.WaitForDocumentReady();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    PageExtension.WaitForElementPresentAndVisible(this, ShoppersAddr);
                    Validateshopperprofile(add.Zip, add.City, add.State);
                    Driver.WaitForDocumentReady();
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
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
        }

        public int GetRandomNumber()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }

        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectStateOption(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectCityOption(add.City);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectColonyOption(add.StreetNumber);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PersonalRdoBtn.Click();
            if (IsCustomer)
                CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            return add;
        }


        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddressManage(Shop.Automation.Framework.Address add, bool IsCustomer = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectStateOption(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectCityOption(add.City);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectColonyOption(add.StreetNumber);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PhoneNumber.SendKeys(add.PhoneNumber);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
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
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectStateOption(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectCityOption(add.City);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectColonyOption(add.StreetNumber);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PhoneNumber.SendKeys(add.PhoneNumber);
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
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
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 20);
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
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
        }                      
       
        public IList<IWebElement> verifyMileDropDown()
        {
            SelectElement oSelect = new SelectElement(MileDropdown);
            IList<IWebElement> elementCount = oSelect.Options;
            return elementCount;
        }

        public void SelectStateOption(string option)
        {
            State.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Statelist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            //PageExtension.WaitForTimeSpan(1000);
            Statelist.FirstOrDefault(i => i.Text.Contains(option)).Click();
        }
        
        public void SelectCityOption(string option)
        {
            City.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Citylist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            //PageExtension.WaitForTimeSpan(3000);
            Citylist.FirstOrDefault(i => i.Text.Contains(option)).Click();
        }

        public void SelectColonyOption(string option)
        {
            County.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Countylist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            //PageExtension.WaitForTimeSpan(3000);
            Countylist.FirstOrDefault(i => i.Text.Contains(option)).Click();
        }

        public void SelectZipOption(string option)
        {
            PostalCode.Click();
            var Ziplist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            //PageExtension.WaitForTimeSpan(3000);
            Ziplist.FirstOrDefault(i => i.Text.Contains(option)).Click();
        }

      
        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void SearchAddressDeliveryAddress(Framework.Address add)
        {
            Driver.Navigate().Refresh();
            WaitSpinToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            // SearchFieldPersonal.SendKeys(add.LastName); //newly added just to test
            WaitSpinToFalse();
            WaitForAddressList();
            DeliveryAddressList.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(EditAddress));

        }

        private static Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string RandomEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            return "username" + randomInt + "@gmail.com";
        }
        /// Below Method is used for adding CSasDS Customer/Personal data(Pass True if its Customer data)
        public Framework.Address AddCSasDSAddress(Framework.Address add, bool IsPersonal = false, bool IsCustomer = false, bool IsCancel = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            add.FirstName = RunSettings.DSFname;
            add.LastName = RunSettings.DSLname;
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectStateOption(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectCityOption(add.City);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectColonyOption(add.StreetNumber);
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(3000);
            PhoneNumber.SendKeys(RunSettings.DSPhone);
            PageExtension.WaitForTimeSpan(2000);
            Email.SendKeys(RunSettings.DSEmail);
            PersonalRdoBtn.Click();
            if (IsCustomer)
                CustomerRadioBtn.Click();
            else if (IsPersonal)
                PersonalRdoBtn.Click();
            if (IsCancel)
                ShippingAddrCancelBtn.Click();
            else
                ShippingAddrSave.Click();
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            Driver.WaitForDocumentReady();
            WaitForAddressList();
            return add;
        }

        public string SelectAnyExistingCustomerAddressToEdit()
        {
            // Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> customerContactList = Driver.FindElements(By.XPath("//*[@class='type Customer']"));
            string FullNameSelectedSavedCustomerAddress = string.Empty;
            new Actions(Driver).MoveToElement(CustomerTag).Perform();
            for (int i = 0; i <= customerContactList.Count; i++)
            {
                customerContactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 60);
                PageExtension.WaitForTimeSpan(1000);
                if (!CommonMethods.IsElementDisplayed(ShippingAddrSave) && !CommonMethods.IsElementDisplayed(CancelAddAddress))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(CustomerTag));
                    FullNameSelectedSavedCustomerAddress = DisplayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedCustomerAddress;
        }
    }
    public class DeliveryAddressPersonalPageTestCL : DeliveryAddressPersonalPage_CL { }
}
