using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_KZ_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-clean-pickup-search']")]
        public IWebElement SearchCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-address-delete']")]
        public IWebElement DeleteBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-duplicated-contact']")]
        public IWebElement Duplicatepopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Выбрать адрес доставки')]")]
        public IWebElement AddAddrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Выберите или введите адрес')]")]
        public IWebElement AddAddrMsg1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ship-to-courier']")]
        public IWebElement CourierTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-role='yandexmapsearchercommon']")]
        public IWebElement StreetSearchAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@id='addressList']//div[@class='address-info']/strong)[1]")]
        public IWebElement AddressSelection { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.Street,disabled:DoAddressFieldsDisabled']")]
        public IWebElement Street_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.City,disabled:DoAddressFieldsDisabled']")]
        public IWebElement City_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.State,disabled:DoAddressFieldsDisabled']")]
        public IWebElement State_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.Street2,disabled:DoAddressFieldsDisabled']")]
        public IWebElement HouseNumber_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.County,disabled:DoAddressFieldsDisabled']")]
        public IWebElement County_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-new-address']//*[@class='notification-warning']")]
        public IWebElement InvalidAddressErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement HouseNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street3']")]
        public IWebElement Apartment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='County']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City-Yandex']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State-Yandex']")]
        public IWebElement ExperianState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Province']")]
        public IWebElement State { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side long-edit-btn']")]
        public IWebElement EditCustomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-role='yandexmapsearchercommon']")]
        public IWebElement YandexSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='shopping -as personal']")]
        public IWebElement NavTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PudoLocationList']//*[@id='btn-pickup-delivery']")]
        public IWebElement PudoLocationListPickupDelivery { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='choose-pudo-location']")]
        public IWebElement PudoLocationpopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//div//a[@id='address-pickup-showmap']")]
        public IWebElement PudoViewMap { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'State_listbox')])[1]")]
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement CancelDuplicate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PickupSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement PickupSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "((//div[@class='yandex-search-input-container'])[1]/descendant::ymaps[contains(@class,'search__suggest')])[1]")]
        public IWebElement SearchAddressIntuitiveFirstOption { get; set; }

        [FindsBy(How = How.XPath, Using = "((//div[@class='yandex-search-input-container'])[1]/descendant::ymaps[contains(@class,'search__suggest')])[4]")]
        public IWebElement SearchAddressIntuitiveFourthOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-bind='click: filterPU']//i[@class='icon-magnifier-fl-1']")]
        public IWebElement MagnifierIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'State_listbox')])[1]")]
        public IWebElement StateDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'City_listbox')])[1]")]
        public IWebElement CityDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street3']")]
        public IWebElement Street3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Пожалуйста, найдите адрес.')]")]
        public IWebElement SearchAddressFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street2']")]
        public IWebElement HouseNumberFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='County']")]
        public IWebElement CountyFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']/div)[1]//div[@class='last']")]
        public IWebElement PickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']/div)[1]//div[@class='last']")]
        public IWebElement PUDOLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='ship-to-courier']")]
        public IWebElement PUDOLocationTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']//strong[contains(text(),'yegaa')]")]
        public IWebElement SearchandSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Алматы')]")]
        public IWebElement PickupAddr { get; set; }

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

        public void ValidateAttributeContains(string Streetvalue, string Housenumber, string Cityvalue, string Regionvalue)
        {
            string value = Street.InputBoxValue();
            string value1 = County.InputBoxValue();
            string value2 = City.InputBoxValue();
            string value3 = Region.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value1.Contains(Housenumber) && value2.Contains(Cityvalue) && value3.Contains(Regionvalue))
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

        /// <summary>
        /// Below Method is used for selecting State
        /// </summary>
        /// <param name="StateName"></param>
        public void StateSelection(string StateName)
        {
            Region.Click();
            var Citylist = InitializeReadOnlyCollection("//ul[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
        }


        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        /// <summary>
        /// Below Method is used for Searching and Edit Customer/Personal data
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

                    string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                    if (ele1 != null)
                        Assert.IsTrue(true);
                    else
                        Assert.IsFalse(true, "No tag found");

                    WaitForAddressList();
                    PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("FN", "Tst1", "street", "1234", "АЛМАТЫ", "АЛМАТЫ", "", "123456789876543", "АЛМАТЫ");

                    if (CommonMethods.IsElementDisplayed(EditCustomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCustomerLink);
                        EditCustomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        PageExtension.WaitForTimeSpan(3000);
                        Street.Clear();
                        Street.SendKeys(add.Street);
                        HouseNumber.Clear();
                        HouseNumber.SendKeys(add.Street2);
                        PageExtension.WaitForTimeSpan(2000);
                        WaitSpainToFalse();
                        StateSelection(add.State, false);
                        PageExtension.WaitForTimeSpan(2000);
                        CitySelection(add.City);
                        PageExtension.WaitForTimeSpan(2000);
                        County.Clear();
                        County.SendKeys(add.City);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        if (IsCustomer)
                            CustomerRadioBtn.Click();
                        PageExtension.WaitForTimeSpan(3000);
                        ValidateAttributeContains("street", "АЛМАТЫ", "АЛМАТЫ", "АЛМАТЫ");
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
                Driver.Navigate().Refresh();
                Driver.WaitForDocumentReady();
                PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
                PageExtension.WaitForElementPresentAndVisible(this, AddrList);
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

                        string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                        if (ele1 != null)
                            Assert.IsTrue(true);
                        else
                            Assert.IsFalse(true, "No tag found");
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
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(ShoppersAddr));
                    Validateshopperprofile("", "АЛМАТЫ", "АЛМАТЫ");
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                }
                else
                    Assert.IsFalse(false, "No address found");
            }
            else
                Assert.IsFalse(false, "No address found");
        }


        public Framework.Address ServiceDownAddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));

            // Add address
            this.WaitForElementClicklable(AddAddressBtn, 40);
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForTimeSpan(2000);
            //AddAddressBtn.Click();
            Street.SendKeys(add.Street);
            HouseNumber.SendKeys(add.Street2);
            Apartment.SendKeys(add.StreetNumber);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            StateDropdown.SendKeys("НУР-СУЛТАН");
            PageExtension.WaitForTimeSpan(2000);
            CityDropdown.SendKeys("НУР-СУЛТАН");
            WaitSpainToFalse();
            if (IsCustomer)
                CustomerRadioBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
            ShippingAddrSave.Click();
            WaitSpainToFalse();
            Driver.WaitForDocumentReady();
            return add;
        }



        public ReadOnlyCollection<IWebElement> StreetSearchAddrCount(string xPath)
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



        /// <summary>
        /// Below Method is used for Searching Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        public void SearchAddress(Framework.Address add)
        {
            Driver.Navigate().Refresh();
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            PageExtension.WaitForElementPresentAndVisible(this, AddrList);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();

        }
        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <param name="add"></param>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(3000);
            StreetSearchAddress.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddress.SendKeys(Keys.ArrowDown);
            StreetSearchAddress.SendKeys(Keys.Enter);
            WaitSpainToFalse();
            Street.SendKeys(add.Street);
            HouseNumber.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            //StateSelection(add.State);
           // PageExtension.WaitForTimeSpan(2000);
            //CitySelection(add.City);
           // PageExtension.WaitForTimeSpan(2000);
            //County.SendKeys(add.StreetNumber);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }
        /// <summary>
        /// Below Method is used for selecting State
        /// </summary>
        /// <param name="StateName"></param>
        /// <param name="IsEdit"></param>
        public void StateSelection(string StateName, bool IsEdit)
        {
            StateDropdown.Click();
            var Statelist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();

        }
        /// <summary>
        /// Below Method is used for selecting City
        /// </summary>
        /// <param name="CityName"></param>
        /// <param name="IsEdit"></param>
        public void CitySelection(string CityName)
        {

            CityDropdown.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            PageExtension.WaitForTimeSpan(3000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();

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
            PageExtension.WaitForTimeSpan(1000);
            StreetSearchAddress.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddress.SendKeys(Keys.ArrowDown);
            StreetSearchAddress.SendKeys(Keys.Enter);
            WaitSpainToFalse();
            Street.SendKeys(add.Street);
            HouseNumber.SendKeys(add.Street2);
            County.SendKeys(add.City);
            PhoneNumber.SendKeys(add.PhoneNumber);           
           // StateSelection(add.State, false);
           //PageExtension.WaitForTimeSpan(3000);
           // CitySelection(add.City);
           //PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(2000);
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
            CancelDuplicate.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
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
            SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 1));
            WaitSpainToFalse();
            WaitForAddressList();
        }
        /// <summary>
        /// Below Method is used for validating Shopper profile 
        /// </summary>
        /// <param name="Postalcodevalue"></param>
        /// <param name="Cityvalue"></param>
        /// <param name="Statevalue"></param>
        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

    }
    public class DeliveryAddressPersonalPageTestKZMB : DeliveryAddressPersonalPage_KZ_MB { }
}
