using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_GH : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        
        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Sorry, no saved addresses matched your search. Please try again.')]")]
        public IWebElement Noaddressdisplayed { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Addresses')]")]
        public IWebElement ManageAddressBtn { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//*[@aria-owns='State_listbox']")]
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='invisible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement PickupUseSelectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'First Name:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Region:')]/span")]
        public IWebElement RegionAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='shipping-list']//div[@class='address-item'])[1]")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'City:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Street :')]/span")]
        public IWebElement StreetAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'House number:')]/span")]
        public IWebElement HouseNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Phone Number:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Phone number is not valid')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Combination of First Name and Last Name cannot exceed 30 characters')]")]
        public IWebElement FirstnameCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        public IWebElement LastTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='City']")]
        public IWebElement CityTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns='State_listbox']//span[contains(text(),'Select')]")]
        public IWebElement RegionDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street2']")]
        public IWebElement HouseNumberTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName']")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City']")]
        public IWebElement CityerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='State']")]
        public IWebElement RegionerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street2']")]
        public IWebElement StreeterrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street']")]
        public IWebElement HouseNumbererrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneNumbererrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Accra WH')]")]
        public IWebElement PickupLocation1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Kumasi WH')]")]
        public IWebElement PickupLocation2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Tamale WH')]")]
        public IWebElement PickupLocation3 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']/div)[1]//div[@class='last']")]
        public IWebElement PickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']/li")]
        public IWebElement CustomerSavedList { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-item']//*[@class='address-info']//*[@class='type Customer'])[1]")]
        public IWebElement CustomerFirstAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement NoAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']/p")]
        public IWebElement ConfirmAddressMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']")]
        public IWebElement CustomerList_ManageAddr { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchField_ManageAddr { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement CancelDuplicateAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-clean-pickup-search'])[1]")]
        public IWebElement DeliverySearchFieldCloseBtn { get; set; }


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

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
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

        //Shopper Profile Validation for Pickup
        public void ValidateshopperprofilePickUp(string expected)
        {
            Assert.IsTrue(ShoppersAddr.Text.Contains(expected));
        }

        public void ValidateAttributeContains(string Streetvalue, string Street2value, string Cityvalue, string Statevalue)
        {
            string value = Street.InputBoxValue();
            string value2 = Street2.InputBoxValue();
            string value3 = City.InputBoxValue();
            string value4 = Region.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) &&  value2.Contains(Street2value) && value3.Contains(Cityvalue) && value4.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void RegionSelection(string Regionname)
        {
            Region.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Regionlist = InitializeReadOnlyCollection("//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Regionlist.FirstOrDefault(i => i.Text.Contains(Regionname)).Click();
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
        private static Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public void SearchAndEdit(Framework.Address add, bool IsCustomer = false)
        {
            //Select address from list and Edit address

            WaitForAddressList();
            PersonalAddrList.Click();
            add.ClearAddress();
            add.FillAddressForEMEA("Test", "Daks", "Street", "", "OMOA", "", "1234577678", "", "CORTES");
            if (CommonMethods.IsElementDisplayed(EditInformation))
            {
                PageExtension.WaitForTimeSpan(1000);
                PageExtension.WaitForElementPresentAndVisible(this, EditInformation);
                EditInformation.Click();
                PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                FirstNameTextBox.Clear();
                string firsrtname = "DJ";
                add.FirstName = firsrtname + RandomString(6);
                FirstNameTextBox.SendKeys(add.FirstName);
                PageExtension.WaitForTimeSpan(1000);
                LastTextBox.Clear();
                LastTextBox.SendKeys(add.LastName);
                PageExtension.WaitForTimeSpan(1000);
                StreetTextBox.Clear();
                StreetTextBox.SendKeys(add.Street);
                PageExtension.WaitForTimeSpan(1000);
                WaitSpainToFalse();
                City.SendKeys(add.City);
                PageExtension.WaitForTimeSpan(2000);
                PhoneTextBox.Clear();
                PhoneTextBox.SendKeys(add.PhoneNumber);
                PageExtension.WaitForTimeSpan(1000);
                if (IsCustomer)
                    CustomerRadioBtn.Click();
                PageExtension.WaitForTimeSpan(2000);
                WaitSpainToFalse();
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
        /// Below Method is use for Searching and Edit Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        /// <param name="IsCustomer"></param>
        public void SearchAndEditDelete(Framework.Address add, bool IsCustomer = false)
        {

            //Select address from list and Edit address
            var count1 =  InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.Zip))
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
                    add.FillAddressForEMEA("US", "DEEP", "Spintex Road", "H/No. CH 96", "Accra", "", "33432423423", "", "Northern");
                    PageExtension.WaitForTimeSpan(2000);
                    if (CommonMethods.IsElementDisplayed( EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                         PageExtension.WaitForElementPresentAndVisible(this,EditCostomerLink);
                         EditCostomerLink.Click();
                         PageExtension.WaitForElementPresentAndVisible(this,ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        Street.Clear();
                        Street.SendKeys(add.Street);
                        Street2.Clear();
                        Street2.SendKeys(add.Street2);
                        City.Clear();
                        City.SendKeys(add.City);
                        PageExtension.WaitForTimeSpan(2000);
                        RegionSelection(add.State);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
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
                ValidateAttributeContains(add.Street, add.Street2, add.City, add.State);
                var count =  InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
                if (count != null && count.Count > 0)
                {
                    foreach (var item in count)
                    {
                        string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;
                        if (ele.Contains(add.FirstName.Remove(add.FirstName.Length - 2)) && ele.Contains(add.Street) && ele.Contains(add.Zip))
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
                     PageExtension.WaitForElementPresentAndVisible(this,ShiptothisBut);
                    PageExtension.WaitForTimeSpan(1000);
                     ShiptothisBut.Click();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                     Driver.WaitForDocumentReady();
                    PageExtension.WaitForTimeSpan(5000);
                     PageExtension.WaitForElementPresentAndVisible(this,ShoppersAddr);
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
        public void SearchAddress(Shop.Automation.Framework.Address add)
        {
            Driver.Navigate().Refresh();
            WaitSpainToFalse();
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
            SearchAddres.Click();
            Assert.IsTrue(PageExtension.WaitForElementPresentAndEnable(this, EditInformation));
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
             WaitForAddressList();
            EditInformation.Click();
             ValidateAttributeContains(add.Street, add.Street2, add.City, add.State);
        }
        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
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
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this,PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            City.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(1000);
            RegionSelection(add.State);
            PageExtension.WaitForTimeSpan(2000);
            Street.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(1000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            if (iscancelled)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(2000);
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
                            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
                            FirstName.Clear();
                            FirstName.SendKeys(add.FirstName);
                            LastName.Clear();
                            LastName.SendKeys(add.LastName);
                            City.SendKeys(add.City);
                            PageExtension.WaitForTimeSpan(1000);
                            RegionSelection(add.State);
                            PageExtension.WaitForTimeSpan(2000);
                            Street.SendKeys(add.Street);
                            PageExtension.WaitForTimeSpan(1000);
                            Street2.SendKeys(add.Street2);
                            PageExtension.WaitForTimeSpan(1000);
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            WaitForAddressList();
                            ShippingAddrSave.Click();
                            WaitSpainToFalse();
                            ShiptothisBut.Click();
                            WaitSpainToFalse();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpainToFalse();
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
            City.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(2000);
            RegionSelection(add.State);
            PageExtension.WaitForTimeSpan(2000);
            Street.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(1000);
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
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementPresentAndVisible(this,Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Cancel));
             Duplicatelist.Click();
             PageExtension.WaitForElementPresentAndVisible(this,Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled( Overwrite));
             Overwrite.Click();
             PageExtension.WaitForElementPresentAndVisible(this,ShippingAddrSave, 5);
            //Search Address
             PageExtension.WaitForElementPresentAndVisible(this,SearchFieldPersonal);
             SearchFieldPersonal.Clear();
             SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 2));
             WaitSpainToFalse();
             WaitForAddressList();
        }
        /// <summary>
        /// Below Method is used for validating Shopper Profile
        /// </summary>
        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

    }
    public class DeliveryAddressPersonalPageTestGH : DeliveryAddressPersonalPage_GH
    {
       
    }
}
