using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_HK_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-select btn-ship']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Addresses')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'HKDC Pickup Locations')]")]
        public IWebElement PickupTab1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'Smart Locker Locations')]")]
        public IWebElement PickupTab2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Saved Addresses')]")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement GetAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@class='address-info']")]
        public IWebElement AddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Personal')]")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),'Customer')])[2]")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']")]
        public IWebElement GetAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CitySK { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement ShippingAddrSaveEdit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='notification-success'])[2]")]
        public IWebElement AddressaddedsuccessfullyMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'First Name:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'City:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'State:')]/span")]
        public IWebElement StateAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Street 1:')]/span")]
        public IWebElement Street1Asterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),' Phone Number:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Sorry, no saved addresses matched your search. Please try again.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        public IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='City_listbox']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='State_listbox']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='button-set']/a[@class='close-reveal-modal btn-delete'])[4]")]
        public IWebElement DeleteConfirmCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State_listbox']/li[contains(text(),'HK-Hong Kong')]")]
        public IWebElement StateDropDownoption1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State_listbox']/li[contains(text(),'KLN-Hong Kong')]")]
        public IWebElement StateDropDownoption2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City_listbox']/li[contains(text(),'Central and Western')]")]
        public IWebElement CityDropDownoption1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City_listbox']/li[contains(text(),'Eastern')]")]
        public IWebElement CityDropDownoption2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street']")]
        public IWebElement Street1TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street2']")]
        public IWebElement Street2TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Zip']")]
        public IWebElement ZIPTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@wire-model='OrderIntention']//a[@class='edit-address']")]
        public IWebElement ShopperProf { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Sorry, no saved addresses matched your')]")]
        public IWebElement SearchWrng { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Duplicates Found')]")]
        public IWebElement DuplicatePopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(), '')]")]
        public IWebElement AddressSelection { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName']")]
        public IWebElement FirstNameErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName']")]
        public IWebElement LastNameErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street']")]
        public IWebElement StreetErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='State']")]
        public IWebElement StateErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City']")]
        public IWebElement CityErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneNumberErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Herbalife International of Hong Kong Ltd')]")]
        public IWebElement HerbalifepickupAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//A[@class='btn-continue']")]
        public IWebElement DuplicateConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Combination of First Name and Last Name cannot exceed 40 characters')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='pickupSearch']")]
        public IWebElement PickupSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'View Map')]")]
        public IWebElement PickupViewMap { get; set; }


        [FindsBy(How = How.XPath, Using = "//Select[@id='select-miles-away']")]
        public IWebElement PickupKMTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//*[@class='icon-magnifier-fl-1']")]
        public IWebElement Magnifiericon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']//*[@class='address-info'])[1]")]
        public IWebElement PickupTab2Address1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='/Shop/Address/images/HK_Pickup_logo.png']")]
        public IWebElement HerbalifePickupLogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='html: additional']")]
        public IWebElement HerbalifeNote { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Phone number is not valid')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='address-search-value']")]
        public IWebElement searchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//ul[@id='experian-address-input_listbox']/li)[1]")]
        public IWebElement searchList { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            PageExtension.ScrollIntoView(this, AddAddressBtn);
            PageExtension.WaitForTimeSpan(1000);
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, FirstNameTextBox);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameTextBox));
            //Shop.Automation.Framework.Address add = CreateObject();
            FirstNameTextBox.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastNameTextBox.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            Street1TextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            Street2TextBox.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            StateSelection(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
            CitySelection(add.City);
            PageExtension.WaitForTimeSpan(2000);
            PhoneTextBox.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            if (IsCustomer)
                CustomerRdoBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            if (iscancelled)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }

        public void SearchAddress(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
            ValidateAttributeContains(add);
        }

        public void SearchAndEdit(Framework.Address add)
        {

            //Select address from list and Edit address
            var count1 = InitializeReadOnlyCollection("//*[@id='addressList']/div/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");


                    WaitForAddressList();
                    PersonalAddrList.Click();

                    add.ClearAddress();
                    add.FillAddressForEMEA("DJ", "AkashEdit", "Street1Edit", "Street2Edit", "Southern", "", "876543265432", "", "HK-Hong Kong");
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstNameTextBox.Clear();
                        FirstNameTextBox.SendKeys(add.FirstName);
                        LastNameTextBox.Clear();
                        PageExtension.WaitForTimeSpan(2000);
                        LastNameTextBox.SendKeys(add.LastName);
                        Street1TextBox.Clear();
                        PageExtension.WaitForTimeSpan(1000);
                        Street1TextBox.SendKeys(add.Street);
                        PageExtension.WaitForTimeSpan(1000);
                        Street2TextBox.Clear();
                        Street2TextBox.SendKeys(add.Street2);
                        PageExtension.WaitForTimeSpan(2000);
                        StateSelection(add.State);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
                        CitySelection(add.City);
                        PageExtension.WaitForTimeSpan(2000);
                        PhoneTextBox.Clear();
                        PhoneTextBox.SendKeys(add.PhoneNumber);
                        PageExtension.WaitForTimeSpan(1000);
                        CustomerRdoBtn.Click();
                        PageExtension.WaitForTimeSpan(2000);
                        WaitSpinToFalse();
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
                        if (ele.Contains(add.FirstName) && ele.Contains(add.Street))
                            Assert.IsTrue(true, "The address is successfully Edited");
                        else
                            Assert.IsTrue(false, "Address is not Matching");
                        break;
                    }
                }
                PersonalAddrList.Click();
                if (CommonMethods.IsElementDisplayed(ShiptothisBut))
                {
                    PageExtension.WaitForElementPresentAndVisible(this, ShiptothisBut);
                    PageExtension.WaitForTimeSpan(1000);
                    ShiptothisBut.Click();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    Driver.WaitForDocumentReady();
                    PageExtension.WaitForTimeSpan(5000);
                    PageExtension.WaitForElementPresentAndVisible(this, ShoppersAddr);
                    Driver.WaitForDocumentReady();
                }
                else
                    Assert.IsFalse(false, "No address found");
            }
        }

        public void ValidateAttributeContains(Framework.Address add)
        {
            GetAddressList.Click();
            WaitSpinToFalse();
            string value = GetAddAddress.Text;
            if (value.Contains(add.FirstName) && value.Contains(add.LastName) && value.Contains(add.Street) && value.Contains(add.City) && value.Contains(add.PhoneNumber))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }


        public void ValidateshopperprofilePickUP(string Streetvalue, string CityValue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(CityValue))
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

        public void StateSelection(string StateName)
        {
            State.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
        }
        public void CitySelection(string CityName)
        {
            City.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }
        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
        }

        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
        }

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        public void WaitForAddressList()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']");
            while (Iweb.Count < 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']");
            }
        }

        public void ValidateAttributeContains(string State, string City, string postcode)
        {
            string value = Address1.InputBoxValue();
            string value1 = CitySK.InputBoxValue();
            if (value.Contains(State) && value1.Contains(City))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }


    }
    public class DeliveryAddressPersonalPageTestHKMB : DeliveryAddressPersonalPage_HK_MB { }
}
