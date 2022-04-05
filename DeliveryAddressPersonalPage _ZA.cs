using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_ZA : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'PUDO Location')]")]
        public IWebElement PudoLocationTabs { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Enter your City or ZIP code to find a pickup location near you.')]")]
        public IWebElement PudoStaticMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='select-miles-away']")]
        public IWebElement PickupKMDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='pu-list']//div[@class='address-info']")]
        public IWebElement PickupAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='invisible: showMap']")]
        public IWebElement PickupViewMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='visible: showMap']")]
        public IWebElement PickupShowlocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='select-miles-away']//option")]
        public IWebElement PickupMilesdropdownlist { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='pickupSearch']")]
        public IWebElement PickupSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//a[@id='btn-pickup-delivery']")]
        public IWebElement UseSelectPickupButton { get; set; }


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

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-go-checkout']")]
        public IWebElement GOToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='saved-addresses']/h3")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and @role='alert']")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']/h4")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressIteam2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div")]
        public IWebElement PickUpLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement StreetAddress { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressIteam { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'State_listbox')])[1]")]
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='new-address-form']//select[@id='State']")]
        public IWebElement StateDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='new-address-form']//select[@id='City']")]
        public IWebElement CityDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@id='new-address-form']//select[@id='Zip']")]
        public IWebElement PostalcodeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Zip']")]
        public IWebElement ZipFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']/div)[1]//div[@class='last']")]
        public IWebElement PickUpLocation { get; set; }    
        
        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement Edit_Information { get; set; }

        public ReadOnlyCollection<IWebElement> webelementsColl;
        public void RefreshAndSearchAddress(Framework.Address add)
        {
            Driver.Navigate().Refresh();
            WaitSpinToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
            SearchAddres.Click();
            Assert.IsTrue(PageExtension.WaitForElementPresentAndEnable(this, Edit_Information));

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

        public void ValidateAttributeContains(bool isPersonal, string Streetvalue, string Street2Value, string Cityvalue, string StateValue, string PostalCodeValue)
        {
            if (isPersonal)
            {
                string value = Street.InputBoxValue();
                string value1 = Street2.InputBoxValue();
                string value2 = State.GetAttribute("innerHTML");
                string value3 = City.GetAttribute("innerHTML");
                string value4 = PostalCode.GetAttribute("innerHTML");
                if (value.Contains(Streetvalue) && value1.Contains(Street2Value) && value2.Contains(Cityvalue) && value3.Contains(StateValue) && value4.Contains(PostalCodeValue))
                    Assert.IsTrue(true, "The Value displayed Correctly");
                else
                    Assert.IsTrue(false, "The Value not set Correctly");
            }
            else
            {
                string value = Street.InputBoxValue();
                string value1 = Street2.InputBoxValue();
                string value2 = State.GetAttribute("innerHTML");
                string value3 = City.GetAttribute("innerHTML");
                string value4 = PostalCode.GetAttribute("innerHTML");
                if (value.Contains(Streetvalue) && value1.Contains(Street2Value) && value2.Contains(Cityvalue) && value3.Contains(StateValue) && value4.Contains(PostalCodeValue))
                    Assert.IsTrue(true, "The Value displayed Correctly");
                else
                    Assert.IsTrue(false, "The Value not set Correctly");
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

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));

        }

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void StateSelection(string StateName)
        {
            Region.Click();
            var Citylist = InitializeReadOnlyCollection("//ul[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
        }
        /// <summary>
        /// Below Method is use for Searching and Edit Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        /// <param name="IsCustomer"></param>
        public void SearchAndEdit(Framework.Address add, bool IsCustomer = false)
        {
            WaitForAddressList();
            PersonalAddrList.Click();
            add.ClearAddress();
            add.FillAddressforSAMCAM("DJ", "Akash", "streetEdit", "54321", "AIRDLIN", "Gauteng", "2157", "2343242344");

            if (CommonMethods.IsElementDisplayed(EditCostomerLink))
            {
                PageExtension.WaitForTimeSpan(1000);
                PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                EditCostomerLink.Click();
                PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                FirstName.Clear();
                FirstName.SendKeys(add.FirstName);
                LastName.Clear();
                LastName.SendKeys(add.LastName);
                PageExtension.WaitForTimeSpan(3000);
                Street.Clear();
                Street.SendKeys(add.Street);
                Street2.Clear();
                Street2.SendKeys(add.Street2);
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
                StateSelection(add.State, false);
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
                CitySelection(add.City, false);
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
                PostalCodeSelection(add.Zip, false);
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
                PhoneNumber.Clear();
                PhoneNumber.SendKeys(add.PhoneNumber);
                if (IsCustomer)
                    CustomerRadioBtn.Click();
                PageExtension.WaitForTimeSpan(3000);
                ValidateAttributeContains(false, "streetEdit", "54321", "Gauteng", "AIRDLIN", "2157");
                WaitSpinToFalse();
                ShippingAddrSave.Click();
                PageExtension.WaitForTimeSpan(3000);
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                WaitForAddressList();
                Assert.IsTrue(true, "Address successfully Edited");
            }
            else
                Assert.IsFalse(true, "No address found");

        }
        /// <summary>
        /// Below Method is use for Searching Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        public void SearchAddress(Framework.Address add)
        {
            Driver.Navigate().Refresh();
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            PageExtension.WaitForElementPresentAndVisible(this, AddrList);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
        }
        /// <summary>
        /// Below Method is used to validate shopper profile Data
        /// </summary>
        /// <param name="add"></param>
        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false, bool IsCancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            //Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            StateSelection(add.State, false);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            CitySelection(add.City, false);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            PostalCodeSelection(add.Zip, false);
            PhoneNumber.SendKeys(add.PhoneNumber);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            WaitSpinToFalse();
            ValidateAttributeContains(false, "street", "1234", "Limpopo", "ALMA", "0512");
            if (IsCancelled)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
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
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditInformation));
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
                            LastName.Clear();
                            LastName.SendKeys(add.LastName);
                            PageExtension.WaitForTimeSpan(3000);
                            Street.Clear();
                            Street.SendKeys(add.Street);
                            Street2.Clear();
                            Street2.SendKeys(add.Street2);
                            PageExtension.WaitForTimeSpan(2000);
                            WaitSpinToFalse();
                            StateSelection(add.State, false);
                            PageExtension.WaitForTimeSpan(2000);
                            WaitSpinToFalse();
                            CitySelection(add.City, false);
                            PageExtension.WaitForTimeSpan(2000);
                            WaitSpinToFalse();
                            PostalCodeSelection(add.Zip, false);
                            PageExtension.WaitForTimeSpan(2000);
                            WaitSpinToFalse();
                            PhoneNumber.Clear();
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            PageExtension.WaitForTimeSpan(1000);
                            WaitSpinToFalse();
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

        public void StateSelection(string StateName, bool IsEdit)
        {
            StateDropdown.Click();
            var Statelist = InitializeReadOnlyCollection("//form[@id='new-address-form']//select[@id='State']/option").ToList();
            PageExtension.WaitForTimeSpan(1000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();

        }

        public void CitySelection(string CityName, bool IsEdit)
        {

            CityDropdown.Click();
            var Citylist = InitializeReadOnlyCollection("//form[@id='new-address-form']//select[@id='City']/option").ToList();
            PageExtension.WaitForTimeSpan(1000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();

        }

        public void PostalCodeSelection(string Postalcode, bool IsEdit)
        {

            PostalcodeDropdown.Click();
            var PostalCodelist = InitializeReadOnlyCollection("//form[@id='new-address-form']//select[@id='Zip']/option").ToList();
            PageExtension.WaitForTimeSpan(1000);
            PostalCodelist.FirstOrDefault(i => i.Text.Contains(Postalcode)).Click();

        }
        /// <summary>
        /// Below Method is used for adding Duplicate data to System 
        /// </summary>
        /// <param name="add"></param>
        public void AddedDuplicateAddress(Framework.Address add)
        {
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            StateSelection(add.State, false);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            CitySelection(add.City, false);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            PostalCodeSelection(add.Zip, false);
            PhoneNumber.SendKeys(add.PhoneNumber);
            WaitSpinToFalse();
            ValidateAttributeContains(true, "street", "1234", "Limpopo", "ALMA", "0512");
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
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            PageExtension.WaitForTimeSpan(3000);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Duplicatelist.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled(Overwrite));
            Overwrite.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave, 5);
            //Search Address
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 2));
            WaitSpinToFalse();
            WaitForAddressList();
        }

        

    }
    public class DeliveryAddressPersonalPageTestZA : DeliveryAddressPersonalPage_ZA { }
}
