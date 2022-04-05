using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.ObjectModel;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_IN_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-list']//h4")]
        public IWebElement NoAddrWarningMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement AddAddressBtn_ManageAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: HasAddresses' and contains(@href,'/en-IN/Shop')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Nutrition Club']")]
        public IWebElement NutritionTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement CheckoutAddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Address2 { get; set; }

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

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement AddSku { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='btn-add-cart'])[1]")]
        public IWebElement BuyNow { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement FNameLname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]

        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Club']")]

        public IWebElement NuitritionRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-info']")]
        public IWebElement DeliveryAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//form//*[@id='btn-default-address-changed']")]
        public IWebElement ShipToThisAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='totals']//*[contains(text(),'Change')]")]
        public IWebElement ChangeAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Herbalife(Sales Centre/QRC)')]")]
        public IWebElement Pickup2ndTab { get; set; }


        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']//*[@class='address-info'])[1]")]
        public IWebElement PickupAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement ManageAddress_AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@data-bind='visible: ShippingAddressesFound']//*[@class='address-info']//span)[1]")]
        public IWebElement ManageAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='choose-pickup-location']//li[@id='fedex-toggle']")]
        public IWebElement PickupTab1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='choose-pickup-location']//li[@id='hl-toggle']")]
        public IWebElement PickupTabQRC { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='choose-pickup-location']//li[@id='accesspoint-toggle']")]
        public IWebElement PickupTabAccessPoint { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='choose-pickup-location']//li[@id='dropship-toggle']")]
        public IWebElement PickupTabDropShip { get; set; }                    

        [FindsBy(How = How.XPath, Using = "//div[@id='locationList']//div[@class='address-info']")]
        public IWebElement PickUpAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='MyHerbalifelocationList']//div[@class='address-info']")]
        public IWebElement PickUpAddrListQRC { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='MyAccesspointlocationList']//div[@class='address-info']")]
        public IWebElement PickUpAddrListAccessPoint { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='MyDropshipmentlocationList']//div[@class='address-info']")]
        public IWebElement PickUpAddrListDropship { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible:ShowAllLocations']//a[@id='btn-pickup-delivery']")]
        public IWebElement PickupUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible:ShowOnlyDropship']//a[@id='btn-pickup-delivery']")]
        public IWebElement PickupUseSelectedAddrBtnDropship { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible:ShowOnlyAccesspoint']//a[@id='btn-pickup-delivery']")]
        public IWebElement PickupUseSelectedAddrBtnAccessPoint { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible:ShowOnlyHerbalife']//a[@id='btn-pickup-delivery']")]
        public IWebElement PickupUseSelectedAddrBtnQRC { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@id='locationList']//div[@class='address-info']//div[@class='last']//strong")]
        public IWebElement PickupAddrText { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='MyHerbalifelocationList']//div[@class='address-info']//div[@class='last']//strong")]
        public IWebElement PickupAddrTextQRC { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='MyAccesspointlocationList']//div[@class='address-info']//div[@class='last']//strong")]
        public IWebElement PickupAddrTextAccessPoint { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='MyDropshipmentlocationList']//div[@class='address-info']//div[@class='last']//strong")]
        public IWebElement PickupAddrTextDropship { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible:ShowAllLocations']//input[@id='address-pickup-primary']")]
        public IWebElement MakeThisPrimaryChckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='tag primary']")]
        public IWebElement PrimaryTag { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='address-item k-state-selected selected']//div[@class='tag primary']")]
        public IWebElement PrimaryAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'View Map')]")]
        public IWebElement ShowMapButton { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'View Locations')]")]
        public IWebElement ShowLocationsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='https://maps.gstatic.com/mapfiles/transparent.png']")]
        public IWebElement PickUpMapIcons { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible: IsAddressMatchedWithPickupINForSaveUpdate']/div[@class='notification-error']")]
        public IWebElement AddressMatchError { get; set; }

        public void AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false, bool IsNutrition = false)
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
            //ValidateAttributeContains(add.City, add.State);
            PhoneNumber.SendKeys(add.PhoneNumber);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            if (IsNutrition)
                NuitritionRadioBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
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
        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
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
                            FirstName.Clear();
                            FirstName.SendKeys(add.FirstName);
                            PageExtension.WaitForTimeSpan(1000);
                            LastName.Clear();
                            LastName.SendKeys(add.LastName);
                            PageExtension.WaitForTimeSpan(1000);
                            PageExtension.WaitForTimeSpan(1000);
                            Address1.Clear();
                            Address1.SendKeys(add.Street);
                            PageExtension.WaitForTimeSpan(1000);
                            PostalCode.Clear();
                            PostalCode.SendKeys(add.Zip);
                            PageExtension.WaitForTimeSpan(1000);
                            PhoneNumber.Clear();
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            PageExtension.WaitForTimeSpan(1000);
                            WaitSpainToFalse();
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            Driver.WaitForDocumentReady();
                            WaitForAddressList();
                            ShiptothisBut.Click();
                            WaitSpinToFalse();
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

        public void SearchAddress(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
            ValidateAttributeContains(add.City,add.State);
        }
        public void SearchAddress(String FirstName)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }

        public void SearchValidAddress(bool isValidaddress = false)
        {
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
                        break;
                    }
                    this.WaitForElementGone(CommonFindBy.LoadIndicator);
                    if (isValidaddress == true && CommonMethods.IsElementDisplayed(ShiptothisBut))
                    {
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditCostomerLink));
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(FNameLname));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        isValidaddress = true;
                        break;
                    }
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
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

        public void ValidateAttributeContains(string expectedvalue, string expectedvalue1)
        {
            string value = CityIN.GetAttribute("innerHTML");
            string value1 = StateIN.GetAttribute("innerHTML");

            if (value.Contains(expectedvalue) && value1.Contains(expectedvalue1))
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

        public void ValidateshopperprofilePickUP(string Addrvalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Addrvalue) )
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
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

       


    }
    public class DeliveryAddressPersonalPageTestINMB : DeliveryAddressPersonalPage_IN_MB { }
}
