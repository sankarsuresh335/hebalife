using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_enMY : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement Zip { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//*[@aria-owns='State_listbox']")]
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='error invalid-search']")]
        public IWebElement PickupInvalidAddressMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-delete-contact']//a[@class='close-reveal-modal btn-delete']")]
        public IWebElement CustomerDeleteConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "(//ul[@id='contactList']//*[@id='btn-address-delete' and @class='btn-cc-delete'])[1]")]
        public IWebElement CustomerDelete { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement MileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='error invalid-search']")]
        public IWebElement PickUpErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-autosearch']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[2]")]
        public IWebElement AllUseselectedAddress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement NoAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='button-set']//*[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-add-new-address']")]
        public IWebElement ManageAddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='invisible:DeletedAddress.IsLoyaltyCustomer']//a[@class='close - reveal - modal btn - delete']")]
        public IWebElement DeleteConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PickupSearchTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']/div)[1]//div[@class='last']")]
        public IWebElement AllLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement CustomSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='Zip']")]
        public IWebElement ZipFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']/parent::li/span[@class='note']")]
        public IWebElement PostalCodeFormat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/parent::li/span[@class='note']")]
        public IWebElement PhoneNumberFormat { get; set; }


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

        public void ValidateAttributeContains(string Streetvalue, string Cityvalue, string Statevalue)
        {
            string value = Street.InputBoxValue();
            string value2 = Region.GetAttribute("innerHTML");
            string value3 = City.InputBoxValue();
            if (value.Contains(Streetvalue) &&  value2.Contains(Statevalue) && value3.Contains(Cityvalue))
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
                    PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
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
                    add.FillAddressForEMEA("US", "DEEP", "Spintex Road", "H/No. CH 96", "Accra", "23456", "33432423423", "", "Langkawi");
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
                        Zip.Clear();
                        Zip.SendKeys(add.Zip);
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
                ValidateAttributeContains(add.Street, add.City, add.State);
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
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(ShoppersAddr));
                    Validateshopperprofile("23456", "Accra", "Langkawi");
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    Driver.WaitForDocumentReady();
                }
                else
                    Assert.IsFalse(false, "No address found");
            }
            else
                Assert.IsFalse(false, "No address found");
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
        /// Below Method is use for Searching Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        public void SearchAddress(Shop.Automation.Framework.Address add)
        {
             Driver.Navigate().Refresh();
             Driver.WaitForDocumentReady();
             PageExtension.WaitForElementPresentAndVisible(this,SearchFieldPersonal);
             PageExtension.WaitForElementPresentAndVisible(this, AddrList);
             SearchFieldPersonal.SendKeys(add.FirstName);
             WaitSpainToFalse();
             WaitForAddressList();             
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
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            City.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(2000);
            Zip.SendKeys(add.Zip);
            RegionSelection(add.State);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(2000);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(2000);
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
            PageExtension.WaitForElementPresentAndVisible(this,PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            City.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(2000);
            Zip.SendKeys(add.Zip);
            RegionSelection(add.State);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForElementPresentAndVisible(this, CustomerRadioBtn);
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

    }
    public class DeliveryAddressPersonalPageTestenMY : DeliveryAddressPersonalPage_enMY { }
}
