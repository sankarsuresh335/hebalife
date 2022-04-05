using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_ZM : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        public string CatalogPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";
        public string CartPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}" + "??orderCategory=RSO" + "";
        public string AddressPathPricelist => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='html: DisplayedInfo' and contains(text(), 'Please select Address')]")]
        public IWebElement ShoppersAddr_Empty { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//a[contains(@data-bind,'clearCart')]")]
        public IWebElement lnkClearSelectedItems_PVC { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressIteam { get; set; }
        
        public IReadOnlyList<IWebElement> Increase_QtyList => Driver.FindElements(By.XPath("//a[contains(@data-bind,'increaseQty')]/i"));

        [FindsBy(How = How.XPath, Using = "//form[@class='customer-form hl-form']//div[@class='read-only break-wrap']")]
        public IWebElement AddressItem_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-go-checkout'])[2]")]
        public IWebElement GOToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='button-set']/a[@class='close-reveal-modal btn-delete']")]
        public IWebElement DeleteConfirmCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-select btn-ship']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement GetAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Addresses')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Sorry, no saved addresses matched your search. Please try again.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Saved Addresses')]")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']")]
        public IWebElement GetAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CitySK { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        public IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CityTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Area']")]
        public IWebElement AreaTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement ProvinceTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='State_listbox']")]
        public IWebElement StateDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']/option[@value='BOQUERON']")]
        public IWebElement StateDropDownoption1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']/option[@value='CAAZAPA']")]
        public IWebElement StateDropDownoption2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']/option[@value='ITAPE']")]
        public IWebElement CityDropDownoption1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']/option[@value='ITURBE']")]
        public IWebElement CityDropDownoption2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='http://kirgiz-index.5balov.net/']")]
        public IWebElement PostalCodeLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street']")]
        public IWebElement Street1TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street2']")]
        public IWebElement Street2TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Please fill out First Name')]")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName' and contains(text(),' Please fill out Last Name')]")]
        public IWebElement LastnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='State' and contains(text(),' Please fill out the Province')]")]
        public IWebElement ProvinceErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City' and contains(text(),' Please fill out the City')]")]
        public IWebElement CityerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),' Please fill out the Street address field')]")]
        public IWebElement Street1errorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' Please fill out the zip code')]")]
        public IWebElement PostalCodeerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' Zip is not valid')]")]
        public IWebElement PostalCodeInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Please fill out the Phone number')]")]
        public IWebElement PhoneNumbererrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Combination of First Name and Last Name cannot exceed 40 characters')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Phone number Invalid')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

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
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, FirstNameTextBox);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameTextBox));
            FirstNameTextBox.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastNameTextBox.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            Street1TextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            Street2TextBox.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(1000);
            CityTextBox.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(1000);
            ProvinceTextBox.SendKeys(add.State);
            PageExtension.WaitForTimeSpan(1000);
            PostalCode.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(1000);
            WaitSpainToFalse();
            PhoneTextBox.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            if (IsCustomer)
                CustomerRdoBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            if (iscancelled)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }

        public void RefreshAndSearchAddress(Framework.Address add)
        {
            Driver.Navigate().Refresh();
            WaitSpinToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
            SearchAddres.Click();
            Assert.IsTrue(PageExtension.WaitForElementPresentAndEnable(this, EditInformation));
        }

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
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            ManageAddressBtn.Click();
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();
            PageExtension.WaitForTimeSpan(2000);
            var count = InitializeReadOnlyCollection("//*[@id='savedAddressesList']/li");
            if (count.Count > 0)
            {

                foreach (var item in count)
                {

                    if (CommonMethods.IsElementDisplayed(Delete))
                    {
                        PageExtension.WaitForElementPresentAndVisible(this, Delete);
                        Delete.Click();
                        PageExtension.WaitForTimeSpan(3000);
                        PageExtension.WaitForElementPresentAndVisible(this, DeleteConfirmCustomer);
                        DeleteConfirmCustomer.Click();
                        PageExtension.WaitForTimeSpan(2000);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        Driver.WaitForDocumentReady();
                        PageExtension.WaitForElementPresentAndVisible(this, SavedAddressList);
                        PageExtension.WaitForElementPresentAndVisible(this, SavedAddressList);
                        Assert.IsTrue(true);
                        break;
                    }
                    Assert.IsFalse(false, "No address found");
                }
            }
            else
                Assert.IsFalse(true, "No Customer address found");
        }

        public void SearchAndEdit(Framework.Address add, bool IsCustomer = false, bool IsAlreadyCustomer = false)
        {

            //Select address from list and Edit address
            var count1 = InitializeReadOnlyCollection("//*[@id='addressList']/div/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.Text;
                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.Zip))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");
                    WaitForAddressList();
                    PersonalAddrList.Click();

                    add.ClearAddress();
                    add.FillAddressForEMEA("DJ", "AkashEdit", "Street1", "Street2", "ZMCityEdit", "34328", "3454652332", "", "StateEdit");
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstNameTextBox.Clear();
                        FirstNameTextBox.SendKeys(add.FirstName);
                        PageExtension.WaitForTimeSpan(1000);
                        LastNameTextBox.Clear();
                        LastNameTextBox.SendKeys(add.LastName);
                        PageExtension.WaitForTimeSpan(1000);
                        Street1TextBox.Clear();
                        Street1TextBox.SendKeys(add.Street);
                        PageExtension.WaitForTimeSpan(1000);
                        Street2TextBox.Clear();
                        Street2TextBox.SendKeys(add.Street2);
                        PageExtension.WaitForTimeSpan(1000);
                        CityTextBox.Clear();
                        CityTextBox.SendKeys(add.City);
                        PageExtension.WaitForTimeSpan(1000);
                        ProvinceTextBox.Clear();
                        ProvinceTextBox.SendKeys(add.State);
                        PageExtension.WaitForTimeSpan(1000);
                        PostalCode.Clear();
                        PostalCode.SendKeys(add.Zip);
                        PageExtension.WaitForTimeSpan(1000);
                        PhoneTextBox.Clear();
                        PhoneTextBox.SendKeys(add.PhoneNumber);
                        PageExtension.WaitForTimeSpan(1000);
                        if (IsCustomer)
                            CustomerRdoBtn.Click();
                        PageExtension.WaitForTimeSpan(2000);
                        WaitSpainToFalse();
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
                WaitSpainToFalse();
                WaitForAddressList();
                var count = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
                if (count != null && count.Count > 0)
                {
                    foreach (var item in count)
                    {
                        string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;
                        if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.Zip))
                            Assert.IsTrue(true, "The address is successfully Edited");
                        else
                            Assert.IsTrue(false, "Address is not Matching");

                        string ele1 = IsCustomer == true ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal'] ").Text;
                        if (ele1 != null)
                            Assert.IsTrue(true);
                        else
                            Assert.IsFalse(true, "No tag found");
                        break;
                    }
                }

            }
        }

        public void StateSelection(string StateName)
        {
            StateDropDown.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
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
                            FirstNameTextBox.Clear();
                            FirstNameTextBox.SendKeys(add.FirstName);
                            PageExtension.WaitForTimeSpan(1000);
                            LastNameTextBox.Clear();
                            LastNameTextBox.SendKeys(add.LastName);
                            PageExtension.WaitForTimeSpan(1000);
                            Street1TextBox.Clear();
                            Street1TextBox.SendKeys(add.Street);
                            PageExtension.WaitForTimeSpan(1000);
                            Street2TextBox.Clear();
                            Street2TextBox.SendKeys(add.Street2);
                            PageExtension.WaitForTimeSpan(1000);
                            CityTextBox.Clear();
                            CityTextBox.SendKeys(add.City);
                            PageExtension.WaitForTimeSpan(1000);
                            ProvinceTextBox.Clear();
                            ProvinceTextBox.SendKeys(add.State);
                            PageExtension.WaitForTimeSpan(1000);
                            PostalCode.Clear();
                            PostalCode.SendKeys(add.Zip);
                            PageExtension.WaitForTimeSpan(1000);
                            PhoneTextBox.Clear();
                            PhoneTextBox.SendKeys(add.PhoneNumber);
                            PageExtension.WaitForTimeSpan(1000);
                            WaitSpainToFalse();
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            Driver.WaitForDocumentReady();
                            WaitForAddressList();
                            UseselectedAddress.Click();
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
            WaitSpainToFalse();
            WaitForAddressList();
            ValidateAttributeContains(add);
        }

        public void ValidateAttributeContains(Framework.Address add)
        {
            GetAddressList.Click();
            WaitSpainToFalse();
            string value = GetAddAddress.Text;
            if (value.Contains(add.FirstName) && value.Contains(add.LastName) && value.Contains(add.Street) && value.Contains(add.City) && value.Contains(add.PhoneNumber) && value.Contains(add.Zip))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void ValidateshopperprofilePickUP(string Streetvalue, string CityValue, string StateValue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(CityValue) && value.Contains(StateValue))
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


        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
        }

        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
        }
        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
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
            string value3 = PostalCode.InputBoxValue();
            if (value.Contains(State) && value1.Contains(City) && value3.Contains(postcode))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        public void EnterPostalcode(string postalcode)
        {
            char[] array = postalcode.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];
                PostalCode.SendKeys(letter.ToString());
            }
        }

    }
    public class DeliveryAddressPersonalPageTestZM : DeliveryAddressPersonalPage_ZM { }
}
