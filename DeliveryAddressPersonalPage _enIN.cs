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
    public class DeliveryAddressPersonalPage_enIN : Page
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement SelectAddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-item' and @class='address-info']")]
        public IWebElement SelectAddressValueIN { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-list']//h4")]
        public IWebElement NoAddrWarningMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement ManageAddressAddBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: HasAddresses' and contains(@href,'/en-IN/Shop')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//[@id='btn-address-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

       
        [FindsBy(How = How.XPath, Using = "//span[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Nutrition Club']")]
        public IWebElement NutritionTag { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-default-address-changed']")]
        public IWebElement UsethisAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'For faster checkout, use your address book to securely store shipping addresses.')]")]
        public IWebElement ManageAddressPageMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text() ,'Sorry, no saved addresses matched your search. Please try again')]")]
        public IWebElement SearchFieldWrngMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: PickupLocationsFoundFunc']")]
        public IWebElement PickupSearchFieldWrngMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'Choose or add an address for this personal')]")]
        public IWebElement PersonalCnmtnAddressMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Club' and @value='14']")]
        public IWebElement ClubRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Address2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='StateIsEdit'][@readonly]")]
        public IWebElement StateReadOnly { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='CityIsEdit'][@readonly]")]
        public IWebElement CityReadOnly { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='City_listbox']//*[@class='k-input']")]
        public IWebElement CityIN { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='State_listbox']//*[@class='k-input']")]
        public IWebElement StateIN { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement Address1FieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Zip']")]
        public IWebElement PostalCodeFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-bind='visible: InvalidZipAlert']")]
        public IWebElement PostalCodeErrorMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']/p")]
        public IWebElement MessageOnAddressPopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//label[contains(@style,'font-size')]")]
        public IWebElement ImportantMessageOnAddressPopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='address-pickup-primary']")]
        public IWebElement PrimaryCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='primary-location pickup-checkbox']//*[@data-bind='checked: makePickupPrimary, enabled: SelectedPickup'])[2]")]
        public IWebElement PrimaryCheckboxPickUp { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//select[@id='select-miles-away']")]
        public IWebElement MilesSelectionDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'Herbalife(Sales Centre/QRC)')]")]
        public IWebElement PickupTab2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'Access Points')]")]
        public IWebElement PickupTab3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'Drop Ship')]")]
        public IWebElement PickupTab4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='addressList']//div[@class='address-info']")]
        public IWebElement SelectShippingAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']//*[@data-bind='text: WarehouseName, visible: WarehouseName']")]
        public IWebElement AddressSelection { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowAllLocations']//*[@id='btn-pickup-delivery']")]
        public IWebElement AllPickupUseSelectedBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='hl-toggle' and @data-bind='events: {click:showHerbalLocation}']")]
        public IWebElement HerbalifePickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='accesspoint-toggle' and @data-bind='events: {click:showAccessLocation}']")]
        public IWebElement AccessPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='dropship-toggle' and @data-bind='events: {click:showDropShipLocation}']")]
        public IWebElement DropShipPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickup-search-value']")]
        public IWebElement SearchPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchPickupField_AllTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='address-pickup-filter']//i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon_AllTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowAllLocations']//*[@id='btn-pickup-delivery']")]
        public IWebElement AllUseSelectedAddrBtn { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowOnlyAccesspoint']//*[@id='btn-pickup-delivery']")]
        public IWebElement AccessUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowOnlyDropship']//*[@id='btn-pickup-delivery']")]
        public IWebElement DropUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement FNameLname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@id='fedex-toggle']")]
        public IWebElement Pickup_AllTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='new-address-form-sav']//em")]
        public IWebElement PrintedMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'FullAddress')]")]
        public IWebElement ReadOnlyAddress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]

        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Club']")]

        public IWebElement NuitritionRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyDropshipmentlocationList']/div")]
        public IWebElement Dropshipmentlist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='address-info'])[1]/parent::div")]
        public IWebElement FirstShippingSavedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-cancel-new-address-edit']")]
        public IWebElement CancelButtonEditAddressForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btn-save-new-address-edit']")]
        public IWebElement SaveButtonEditAddressForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressSavedCorrectly')]")]
        public IWebElement AddressSavedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressUpdatedCorrectly')]")]
        public IWebElement AddressUpdatedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.PhoneNumber']")]
        public IWebElement PhoneNumberSelectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='html: shippingSelectedAddress.FullAddress']")]
        public IWebElement FullSelectedAddress { get; set; }

        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible: IsAddressMatchedWithPickupINForSaveUpdate']/div[@class='notification-error']")]
        public IWebElement AddressMatchError { get; set; }



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

        public void ValidateAttributeContains(string Cityexpectedvalue,string Stateexpectedvalue1)
        {    
            string value = CityIN.GetAttribute("innerHTML");
            string value1 = StateIN.GetAttribute("innerHTML");

            if (value.Contains(Cityexpectedvalue) && value1.Contains(Stateexpectedvalue1))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
               Assert.IsTrue(false, "The Value not set Correctly");
         }
        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        public void Validatedistancedropdown(string expected)
        {
            string value = PickUPDdnSearch.Text;
            if (value.Contains(expected))
            {
                Assert.IsTrue(true, "The Value displayed Correctly");
            }
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        public void ValidateMultiCitiesforZip(int index = 0)
        {
            CityIN.Click();
            PageExtension.WaitForTimeSpan(2000);
            ReadOnlyCollection<IWebElement> prodList1 = InitializeReadOnlyCollection("//*[@id='City_listbox']/li");
            if (prodList1.Count > 0)
                prodList1[index].Click();
        }
        public void AddnewAddress()
        {
            bool isPresent = false;
            this.Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            this.WaitForElementPresentAndVisible(PersonalAddrList);
            AddAddressBtn.Click();
            this.WaitForElementPresentAndVisible(ShippingAddrSave);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddress("test", "test", "Commissariat Road", "BANGALORE", "KARNATAKA", "560025", "9999955555");
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Address1.SendKeys(add.Street);
            PostalCode.SendKeys(add.Zip);
            WaitSpainToFalse();
            ValidateAttributeContains("BANGALORE", "KARNATAKA");
            PhoneNumber.SendKeys(add.PhoneNumber);
            ShippingAddrSave.Click();
            this.WaitForElementGone(CommonFindBy.BusyIndicator);
            var count = InitializeReadOnlyCollection("//*[@id='addressList']//div[@role='option']");
            foreach (var v in count)
            {
                if (v.Text.ToLower().Contains(add.FirstName))
                {
                    Assert.IsTrue(true);
                    isPresent = true;
                    break;
                }
            }
            if (isPresent)
                Assert.IsTrue(true, "Address found in the list");
            else
                Assert.IsTrue(false, "Address not found");
        }

        public void AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false, bool IsNutrition=false)
        {
            bool isPresent = false;
            this.Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            this.WaitForElementPresentAndVisible(PersonalAddrList);
            AddAddressBtn.Click();
            this.WaitForElementPresentAndVisible(ShippingAddrSave);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Address1.SendKeys(add.Street);
            PostalCode.SendKeys(add.Zip);
            WaitSpainToFalse();
           
            PhoneNumber.SendKeys(add.PhoneNumber);
            PhoneNumber.SendKeys(Keys.Tab);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            if (IsNutrition)
                NuitritionRadioBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            ShippingAddrSave.Click();
            this.WaitForElementGone(CommonFindBy.BusyIndicator);
            PageExtension.WaitForTimeSpan(5000);
            var count = InitializeReadOnlyCollection("//*[@id='addressList']//div[@role='option']");
            foreach (var v in count)
            {
                if (v.Text.Trim().Contains(add.FirstName))
                {
                    Assert.IsTrue(true);
                    isPresent = true;
                    break;
                }
            }
            if (isPresent)
                Assert.IsTrue(true, "Address found in the list");
            else
                Assert.IsTrue(false, "Address not found");
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
        public void SearchValidAddress(bool isValidaddress = false)
        {
            var cus = MandatryFieldCount("//*[@id='addressList']//div[@role='option']");
            if (cus.Count>0)
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
                    if(isValidaddress == true && CommonMethods.IsElementDisplayed(ShiptothisBut))
                    {
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditCostomerLink));
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(FNameLname));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        isValidaddress = true;
                        break;
                    }
                    else if(CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        break;
                    }
                }
            }
            else
                Assert.IsFalse(true, "No customer address found");
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
        /// Below Method is use for Searching Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        public void SearchAddress(String FirstName)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
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
                if (!CommonMethods.IsElementDisplayed(ShippingAddrSave) && !CommonMethods.IsElementDisplayed(CancelAddAddress))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(CustomerTag));
                    FullNameSelectedSavedCustomerAddress = displayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedCustomerAddress;
        }

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
    }

    public class DeliveryAddressPersonalPageTestsenIN : DeliveryAddressPersonalPage_enIN { }
}