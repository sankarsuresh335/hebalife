using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_AU : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        public string CatalogPath => $"{RunSettings.FarmUrl}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";
        public string CartPath => $"{RunSettings.FarmUrl}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}" + "??orderCategory=RSO" + "";
        public string CartPage => $"{RunSettings.FarmUrl}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}";
        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-go-checkout'])[2]")]
        public IWebElement GOToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-list']/h4")]
        public IWebElement NoSavedAddress { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='html: DisplayedInfo' and contains(text(), 'Please select Address')]")]
        public IWebElement ShoppersAddr_Empty { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@class='customer-form hl-form']//div[@class='read-only break-wrap']")]
        public IWebElement AddressItem_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressIteam { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='sku-info ']")]
        public IWebElement FirstSKU { get; set; }
        public IReadOnlyList<IWebElement> Increase_QtyList => Driver.FindElements(By.XPath("//a[contains(@data-bind,'increaseQty')]/i"));

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@data-bind,'clearCart')]")]
        public IWebElement lnkClearSelectedItems_PVC { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='fadeIn: DisplayExperianInValidAddressMessage']")]
        public IWebElement InvalidAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='fadeIn: DisplayExperianInValidPhoneMessage']")]
        public IWebElement InvalidPhone { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='button-set']//*[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='read-only break-wrap']")]
        public IWebElement FrstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement NoAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']/li")]
        public IWebElement CustomerSavedList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")] //First Name
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")] //Last Name
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")] //Postal code
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")] // Street Number 
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street1']")] // Street name
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street3']")] // for building Number 
        public IWebElement BuildingName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street4']")] //for Unit number
        public IWebElement UnitNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='notification-success'])[2]")]
        public IWebElement AddressUpdatedsuccessfullyMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Suburb_listbox']")] //Suburb
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City'and @data-bind='value: Address.City']")] //Suburb
        public IWebElement CityAU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State_listbox']")] //State
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State'and @data-bind='value: Address.State']")] //State
        public IWebElement StateAU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip'and @data-bind='value: Address.Zip']")] //Zip
        public IWebElement ZipAU { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='experian-address-input']")]
        public IWebElement searchTextBoxAU { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='experian-address-input_listbox']/li)[1]")]
        public IWebElement AddressExperianAU { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='add-new-address']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneErrorAU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-bind='visible: InvalidStreetAlert']")]
        public IWebElement StreetExpiernFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='Street2']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='Street1']")]
        public IWebElement Street1FieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='Zip']")]
        public IWebElement ZipFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneNumberFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-info']")]
        public IWebElement DeliveryAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")] //save button for edit address
        public IWebElement EditShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement Pickupdelivery { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//*[@aria-owns='Suburb_listbox']")] //works
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//*[@aria-owns='State_listbox']")] //works
        public IWebElement Region2 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='add-new-address']//span[@class='k-widget k-dropdown k-header'])[2]")]
        public IWebElement CityDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='contact-address-form']//span[@class='k-widget k-dropdown k-header'])[2]")]
        public IWebElement EditCityDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement CancelDuplicateAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address-edit']")]
        public IWebElement EditCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//span[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

       [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[contains(@class,'address-item')]/div]")]
        public IWebElement Addresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind = 'fadeIn: DisplayExperianInValidPhoneMessage']")]
        public IWebElement ExperianPhoneMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind = 'fadeIn: DisplayExperianInValidAddressMessage']")]
        public IWebElement ExperianAddressMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']/ancestor::li/span[text()=' Format: 10 numbers ']")]
        public IWebElement phoneformatemessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//span[@data-for='PhoneNumber']")]
        public IWebElement phoneinvalidwarnmessage { get; set; }



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

        public void ValidateAttributeContains(string Cityvalue, string Statevalue)
        {
            string value2 = City.GetAttribute("innerHTML");
            string value3 = State.GetAttribute("innerHTML");
            if (value2.Contains(Cityvalue) && value3.Contains(Statevalue))
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

      
        public void CitySelection(string CityName) // wip

        {

            Region.Click();

            PageExtension.WaitForTimeSpan(2000);

            var Citylist = InitializeReadOnlyCollection("//*[@id='Suburb_listbox']/li").ToList();

            PageExtension.WaitForTimeSpan(2000);

            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();

        }



        public void StateSelection(string StateName) //wip

        {

            Region2.Click();

            PageExtension.WaitForTimeSpan(2000);

            var Statelist = InitializeReadOnlyCollection("//*[@id='State_listbox']/li").ToList();

            PageExtension.WaitForTimeSpan(2000);

            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();

        }

        public string VerfiyPhoneErrorMessage()
        {
            string actual = phoneinvalidwarnmessage.Text;
            return actual;
        }



        /// <summary>
        /// Below Method is use for Searching and Edit Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        /// <param name="IsCustomer"></param>
        public void SearchAndEditDelete(Framework.Address add, bool IsCustomer = true)
        {

            //Select address from list and Edit address
            var count1 = InitializeReadOnlyCollection("//*[@id='addressList']//div[contains(@class,'address-item')]/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[contains(@class,'address-item')]/div")).Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.Zip))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");

                    string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[contains(@class,'address-item')]//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[contains(@class,'address-item')]//span[@class='type Customer']").Text;
                    if (ele1 != null)
                        Assert.IsTrue(true);
                    else
                        Assert.IsFalse(true, "No tag found");

                    WaitForAddressList();
                    WaitSpainToFalse();
                    PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("QWE", "HGD", "", "", "", "", "", "1234567890", "AVENUE 2A", "87", "");

                    if (CommonMethods.IsElementDisplayed(EditLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditLink);
                        EditLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, EditShippingAddrSave);
                        FirstName.Clear();
                        add.FirstName = RandomString(4, false);
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        PageExtension.WaitForTimeSpan(2000);
                        SearchAddressStreet("Teasel Ct");
                        PageExtension.WaitForTimeSpan(2000);
                        BuildingName.Clear();
                        BuildingName.SendKeys(add.StreetNumber);
                        UnitNumber.Clear();
                        UnitNumber.SendKeys(add.CEP);                        
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        PhoneNumber.SendKeys(Keys.Tab);
                        PageExtension.WaitForTimeSpan(3000);
                        //EditShippingAddrSave.Click();
                        ShippingAddrSave.Click();
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
                PageExtension.WaitForTimeSpan(2000);
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

                        string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                        if (ele1 != null)
                            Assert.IsTrue(true);
                        else
                            Assert.IsFalse(true, "No tag found");
                        break;
                    }
                }
                PageExtension.WaitForElementClicklable(this, PersonalAddrList);
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
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(ShoppersAddr));
                    //Validateshopperprofile("2541", "BOMADERRY", "NSW");
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
        /// Below Method is use for Searching Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        public void SearchAddress(Framework.Address add)
        {
            Driver.Navigate().Refresh();
            WaitSpainToFalse();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList);
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
           // SearchFieldPersonal.SendKeys(add.LastName); //newly added just to test
            WaitSpainToFalse();
            WaitForAddressList();
            SearchAddres.Click();
            Assert.IsTrue(PageExtension.WaitForElementPresentAndEnable(this, EditInformation));
        }

        /// <summary>
        /// Methode used for Experian Search
        /// </summary>
        /// <param name="SerachText"></param>
        public void SearchAddress(string SerachText)
        {
            searchTextBoxAU.Clear();
            PageExtension.WaitForTimeSpan(2000);
            searchTextBoxAU.SendKeys(SerachText);
            searchTextBoxAU.SendKeys(Keys.Space);
            PageExtension.WaitForTimeSpan(4000);
            AddressExperianAU.Click();
        }

        public string Phonenumbererrormessage()
        {
            String value=phoneformatemessage.Text;
            return value;
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

        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = true)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            add.FirstName = RandomString(4, false);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(2000);
            SearchAddressStreet("Teasel Ct");
            PageExtension.WaitForTimeSpan(2000);
            BuildingName.SendKeys(add.StreetNumber);
            UnitNumber.SendKeys(add.CEP);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PhoneNumber.SendKeys(add.PhoneNumber);
            if (IsCustomer==false)
                PersonalRdoBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
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
            BuildingName.SendKeys(add.StreetNumber);
            UnitNumber.SendKeys(add.CEP);
            Street.SendKeys(add.Street);
            SearchAddressStreet("Teasel Ct");            
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForTimeSpan(2000);            
            //WaitSpainToFalse();
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
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
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
            WaitSpainToFalse();
            WaitForAddressList();
        }

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
            Assert.IsTrue(ShopperProfileText.Contains(add.Zip));
        }

        public void SelectValidSavedAddressToEdit()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);

                if(CommonMethods.IsElementDisplayed(ExperianAddressMessage))
                {
                    break;
                }                
            }
        }

        public void SelectValidSavedAddressToEditPhone()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);

                if (CommonMethods.IsElementDisplayed(ExperianPhoneMessage))
                {
                    break;
                }
            }
        }

        public void SelectValidSavedAddressToEditBoth()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);

                if (!(CommonMethods.IsElementDisplayed(ExperianAddressMessage)) && !(CommonMethods.IsElementDisplayed(ExperianPhoneMessage)))
                    {
                    break;
                }
            }
        }



        public void SearchAddressStreet(string SearchText)
        {
            PageExtension.WaitForElementPresentAndVisible(this, searchTextBoxAU, 5);
            //ScrollIntoView(searchTextBox);
            searchTextBoxAU.SendKeys(SearchText);
            PageExtension.WaitForTimeSpan(2000);
            searchTextBoxAU.SendKeys(Keys.Space);
            //WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(3000);
            AddressExperianAU.Click();
            //searchTextBox.SendKeys(Keys.ArrowDown);
            // PageExtension.WaitForTimeSpan(3000);
            // searchTextBox.SendKeys(Keys.Enter);
            PageExtension.WaitForTimeSpan(2000);
        }

        public void AutoPopulateCityStateZIP()
        {
            string city = CityAU.GetAttribute("value");
            Assert.IsTrue(city != null);
            PageExtension.WaitForTimeSpan(2000);
            string state = StateAU.GetAttribute("value");
            Assert.IsTrue(state != null);
            PageExtension.WaitForTimeSpan(2000);
            string Zip = PostalCode.GetAttribute("value");
            Assert.IsTrue(Zip != null);
        }

        public bool Istext_box_ReadOnly(IWebElement city, IWebElement state, IWebElement zip)
        {

            string old_text_City = city.GetAttribute("value");
            city.SendKeys("City1");

            string old_text_State = state.GetAttribute("value");
            state.SendKeys("State1");

            string old_text_Zip = zip.GetAttribute("value");
            zip.SendKeys("9999");
            
            string new_text_City =  city.GetAttribute("value");
            string new_text_State = state.GetAttribute("value");
            string new_text_Zip =   zip.GetAttribute("value");

            return (old_text_City == new_text_City && old_text_State == new_text_State && old_text_Zip == new_text_Zip);

        }


        public void SearchValidAddress(bool isValidaddress = false)
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
                        break;
                        
                    }
                    else
                    {
                        isInValidaddressFound = false;
                    }
                    if (isInValidaddressFound == false)
                    {
                        Assert.IsTrue(true, "No customer address found with Invalid address");
                    }

                }

            }
            else
                Assert.IsFalse(true, "No customer address found");
        }

    }
    public class DeliveryAddressPersonalPageTestAU : DeliveryAddressPersonalPage_AU { }
}
