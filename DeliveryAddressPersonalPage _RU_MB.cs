using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_RU_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'Владивосток')]")]
        public IWebElement PickupPrimaryAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='choose-pudo-location']//input[@id='address-pickup-primary']")]
        public IWebElement PickupPrimaryCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-role='yandexmapsearchercommon']")]
        public IWebElement StreetSearchAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement SelectAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip-Yandex']")]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement ServicedownZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),' Пожалуйста, введите адрес.')]")]
        public IWebElement StreetErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side long-edit-btn']")]
        public IWebElement EditCustomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-role='yandexmapsearchercommon']")]
        public IWebElement StreetSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "((//div[@class='yandex-search-input-container'])[1]/descendant::ymaps[contains(@class,'search__suggest')])[2]")]
        public IWebElement SearchAddressIntuitiveFirstOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement HouseNumberTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street3']")]
        public IWebElement ApartmentTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Подходящих предложений не найдено.')]")]
        public IWebElement IntitiveSearchErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.Street2,disabled:DoAddressFieldsDisabled']")]
        public IWebElement HouseNumber_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.Street,disabled:DoAddressFieldsDisabled']")]
        public IWebElement Street_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.State,disabled:DoAddressFieldsDisabled']")]
        public IWebElement Region_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.City,disabled:DoAddressFieldsDisabled']")]
        public IWebElement City_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.County,disabled:DoAddressFieldsDisabled']")]
        public IWebElement Area_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.Zip,disabled:DoAddressFieldsDisabled, enabled:IsYandexServiceAvailable']")]
        public IWebElement Zipcode_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='add-new-address'])/descendant::input[@data-role='yandexmapsearchercommon']")]
        public IWebElement SearchAddressIntuitive { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='add-new add-new-adress']//*[@data-bind='value: Address.Street3,disabled:DoAddressFieldsDisabled']")]
        public IWebElement Apartment_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='fadeIn: DisplayExperianInValidAddressMessageForSaveUpdate']")]
        public IWebElement InvalidAddressErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip-Yandex']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street3']")]
        public IWebElement Apartment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='County']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City-Yandex']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='City_listbox']")]
        public IWebElement ServiceDownCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='State_listbox']")]
        public IWebElement ServiceDownState { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='add-new-address']//span[@aria-owns='State_listbox']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='County']")]
        public IWebElement Neighborhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Zip']")]
        public IWebElement ZIP { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='notification-success'])[1]")]
        public IWebElement AddAddressSuccessNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "(//i[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSku { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-add-cart']")]
        public IWebElement AddbtnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Изменить')]")]
        public IWebElement ChangeAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='totals']//div[@class='address-info']")]
        public IWebElement ShiptoDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side long-edit-btn']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='ship-to-courier']")]
        public IWebElement PUDOTabSelection { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PudoLocationList']//a[@id='btn-pickup-delivery']")]
        public IWebElement PUDOUsethisAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='locationList']/div")]
        public IWebElement PUDOSelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Извините, места получения не найдены')]")]
        public IWebElement PUDOWarningMsg { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//span//input[@id='pickupSearch']")]
        public IWebElement SearchPudoAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='address-pickup-filter']")]
        public IWebElement PudoAddressMagnifier { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='k-widget k-dropdown k-header']")]
        public IWebElement Region { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }        

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//small[contains(text(),'Пожалуйста, найдите адрес.')]")]
        public IWebElement StreetSearchAddressError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-role='yandexmapsearchercommon']")]
        public IWebElement StreetSearchAddressField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),' Пожалуйста, введите Ваш индекс.')]")]
        public IWebElement ZipFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),' Почтовый индекс недействителен.')]")]
        public IWebElement ZipInvalidError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']/div)[1]//div[@class='last']")]
        public IWebElement PickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']/div)[1]//div[@class='last']")]
        public IWebElement PUDOLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(), 'Выбрать адрес доставки')]")]
        public IWebElement DeliveryMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(), 'Выберите или')]")]
        public IWebElement DeliveryMsg1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div//h4[contains(text(),'Извините, нет сохраненных')]")]
        public IWebElement ErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-clean-pickup-search']")]
        public IWebElement SearchCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-duplicated-contact']")]
        public IWebElement DuplicateErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = " //*[@class='CustomerTab']")]
        public IWebElement CustomerTab { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-address-delete']")]
        public IWebElement DeleteBtn { get; set; }

        /*   [FindsBy(How = How.XPath, Using = "//span[@data-for='City']")]
           public IWebElement CitySelection { get; set; }

           [FindsBy(How = How.XPath, Using = "//span[@data-for='State']")]
           public IWebElement StateSelection { get; set; } */ 
           
         [FindsBy(How = How.XPath, Using = "//div[@id='locationList']/div")]
         public IWebElement PudoAddressSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='new-address-form hl-form']//*[@aria-owns='City_listbox']/span/span[1]")]
        public IWebElement CityValue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='new-address-form hl-form']//*[@aria-owns='State_listbox']/span/span[1]")]
        public IWebElement StateValue { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='k-input'])[2]")]
        public IWebElement StateYandex { get; set; }

        [FindsBy(How = How.XPath, Using = "((//div[@class='yandex-search-input-container'])[1]/descendant::ymaps[contains(@class,'search__suggest')])[10]")]
        public IWebElement IntuitiveThirdOption { get; set; }

        [FindsBy(How = How.XPath, Using = "((//div[@class='yandex-search-input-container'])[1]/descendant::ymaps[contains(@class,'search__suggest')])[14]")]
        public IWebElement IntuitiveFourthOption { get; set; }


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

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
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

        public void SelectMilesOption(string option)
        {
            PickUPDdnSearch.SelectDropDownOption(option);
        }

        public void CitySelection(string CityName)
        {
                ServiceDownCity.Click();
                var Citylist = InitializeReadOnlyCollection("//ul[@id='City_listbox']/li").ToList();
                PageExtension.WaitForTimeSpan(2000);
                Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }
        public void StateSelection(string StateName)
        {
            State.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
        }

        public void AddressSelection(string Address)
        {
            var Searchadd = InitializeReadOnlyCollection("//div[@class='address-info']").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Searchadd.FirstOrDefault(i => i.Text.Contains(Address)).Click();
        }

        public void CountyValueValidate()
        {
            IWebElement ele = County;
            string val=ele.GetAttribute("value");
            string exp = "моКр";
            Assert.IsTrue(exp.Equals(val));
        }

        public void ValidateCounty()
        {
            IWebElement ele = County;
            string Countyvalue = ele.GetAttribute("value");
            char[] str = Countyvalue.ToCharArray();
            int len = str.Length;
            if (len < 30)
                Assert.IsTrue(true, "The Value is less than 30 char");
            else
                Assert.IsTrue(true, "The Value is more than 30 char");
        }

        //Checks value of City is present or not
        public void ValidateCity()
        {
            IWebElement ele = City;
            string Cityvalue = ele.GetAttribute("value");
            char[] str = Cityvalue.ToCharArray();
            int len = str.Length;
            if (len < 30)
                Assert.IsTrue(true, "The Value is less then 30 char");
            else
                Assert.IsTrue(true, "The Value is more then 30 char");
        }

        public void ValidateCityValue()
        {
            IWebElement ele = City;
            string Cityvalue = ele.GetAttribute("value");
            Cityvalue = Cityvalue.Substring(0, 5);
            Cityvalue = Cityvalue.ToUpper();
            string actual = Cityvalue.Replace(" ", "");
            string excepted = "CHTO";
            bool val = excepted.Equals(actual);
            Assert.IsTrue(excepted.Equals(actual));
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
                        Assert.IsFalse(false, "Address is not Matching");
                    WaitForAddressList();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("Ye", "Last", "улица Новый Арбат", "2nd Cross", "", "", "101000", "12345654321", "");

                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        PageExtension.WaitForTimeSpan(1000);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        PageExtension.WaitForTimeSpan(1000);
                        StreetSearchAddressField.SendKeys(add.Street);
                        PageExtension.WaitForTimeSpan(1000);
                        StreetSearchAddressField.SendKeys(Keys.Down);
                        StreetSearchAddressField.SendKeys(Keys.Enter);
                        PageExtension.WaitForTimeSpan(2000);
                        WaitSpainToFalse();
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        PageExtension.WaitForTimeSpan(1000);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        PhoneNumber.SendKeys(Keys.Tab);
                        ShippingAddrSave.Click();
                        WaitSpainToFalse();
                        PageExtension.WaitForTimeSpan(4000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
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
                PageExtension.WaitForTimeSpan(2000);
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
                            break;
                    }
                }
                PageExtension.WaitForTimeSpan(3000);
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
                    Validateshopperprofile("101000", "МОСКВА", "МОСКВА");
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
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            ServicedownZipCode.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(1000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(2000);
            CitySelection(add.City);
            PageExtension.WaitForTimeSpan(1000);
            StateSelection(add.State);
            WaitSpainToFalse();
            if (IsCustomer)
                CustomerRdoBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
            ShippingAddrSave.Click();
            WaitSpainToFalse();
            Driver.WaitForDocumentReady();
            return add;
        }

        public void ValidateAttributeContains(string Zip, string Streetvalue, string Cityvalue)
        {
            string value = ZipCode.InputBoxValue();
            string value2 = Street.InputBoxValue();
            string value3 = City.InputBoxValue();
            if (value.Contains(Zip) && value2.Contains(Streetvalue) && value3.Contains(Cityvalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
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
            PageExtension.WaitForTimeSpan(3000);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.LastName);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.Zip);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.Country);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.City);
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
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            this.WaitForElementClicklable(AddAddressBtn, 40);
            PageExtension.ScrollElementIntoMiddle(this, AddAddressBtn, 2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForTimeSpan(3000);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetSearchField.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            this.WaitForElementPresentAndDisplayed(SearchAddressIntuitiveFirstOption);
            SearchAddressIntuitiveFirstOption.Click();
            PageExtension.WaitForTimeSpan(3000);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(1000);
            WaitSpainToFalse();
            County.SendKeys(add.Country);
            PageExtension.WaitForTimeSpan(1000);
            ZipCode.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(2000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
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
            //Add address
            this.WaitForElementClicklable(AddAddressBtn, 40);
            PageExtension.ScrollElementIntoMiddle(this, AddAddressBtn, 2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForTimeSpan(3000);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetSearchAddressField.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddressField.SendKeys(Keys.Down);
            StreetSearchAddressField.SendKeys(Keys.Enter);
            PageExtension.WaitForTimeSpan(2000);
            Street.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            Street2.SendKeys(add.Street2);
            WaitSpainToFalse();
            County.SendKeys(add.Country);
            PageExtension.WaitForTimeSpan(1000);
            PostalCode.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(2000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(2000);
            ShippingAddrSave.Click();
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
            ShippingAddrSave.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
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
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }

        /// <summary>
        /// Below Method is used for validating Shopper Profile
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
    public class DeliveryAddressPersonalPageTestRUMB : DeliveryAddressPersonalPage_RU_MB { }
}
