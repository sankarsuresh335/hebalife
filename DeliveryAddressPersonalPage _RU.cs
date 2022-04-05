using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_RU : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement ManageAddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ship-to-courier']")]
        public IWebElement ShipToCourierTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Извините, нет сохраненных адресов, соответствующих Вашему поиску. Пожалуйста, попробуйте снова.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-delete-contact']//*[@class='close-reveal-modal btn-delete']")]
        public IWebElement DeleteConfirmCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickupDistanceDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div/div[1]")]
        public IWebElement FirstPickUpAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-primary']")]
        public IWebElement PickUpPrimaryCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewonMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Показать местоположения')]")]
        public IWebElement PickupViewLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.Street,disabled:DoAddressFieldsDisabled']")]
        public IWebElement Street_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.Street2,disabled:DoAddressFieldsDisabled']")]
        public IWebElement HouseNumber_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.State,disabled:DoAddressFieldsDisabled']")]
        public IWebElement Region_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.City,disabled:DoAddressFieldsDisabled']")]
        public IWebElement City_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.County,disabled:DoAddressFieldsDisabled']")]
        public IWebElement Area_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='value: Address.Zip,disabled:DoAddressFieldsDisabled, enabled:IsYandexServiceAvailable']")]
        public IWebElement Zipcode_Disabled { get; set; }

        [FindsBy(How = How.XPath, Using = "(//i[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSku { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='notification-success'])[1]")]
        public IWebElement AddAddressSuccessNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement SelectAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-add-cart']")]
        public IWebElement AddbtnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Изменить')]")]
        public IWebElement ChangeAddressbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='totals']//div[@class='address-info']")]
        public IWebElement ShiptoDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-role='yandexmapsearchercommon']")]
        public IWebElement StreetSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement HouseNumberTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street3']")]
        public IWebElement ApartmentTextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Имя:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Пожалуйста, найдите адрес.')]")]
        public IWebElement SearchAddressErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Введите Ваш индекс:')]/span")]
        public IWebElement ZipAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Город:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Личный')]")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Клиент ')]")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Область:')]/span")]
        public IWebElement StateAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Управление адресами')]")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Выберите адрес доставки заказа или создайте новый. Если Вы хотите пропускать этот шаг в будущем')]")]
        public IWebElement DeliveryPageMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='notification-success']")]
        public IWebElement AddressupdatesuccessfullMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='saved-addresses']")]
        public IWebElement SavedAddrTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Номер телефона недействителен')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='tag primary']")]
        public IWebElement PrimarTagPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Подходящих предложений не найдено.')]")]
        public IWebElement IntitiveSearchErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "((//div[@class='yandex-search-input-container'])[1]/descendant::ymaps[contains(@class,'search__suggest')])[1]")]
        public IWebElement SearchAddressIntuitiveFirstOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='fadeIn: DisplayExperianInValidAddressMessage']")]
        public IWebElement InvalidAddressErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-role='yandexmapsearchercommon']")]
        public IWebElement StreetSearchAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip-Yandex']")]
        public IWebElement ZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement Zip { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side long-edit-btn']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),' Почтовый индекс недействителен.')]")]
        public IWebElement InvalidZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Пожалуйста, введите имя')]")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),' Пожалуйста, введите адрес.')]")]
        public IWebElement StreetErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street3']")]
        public IWebElement Apartment { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Доставка в Постаматы и ПВЗ')]")]
        public IWebElement PudoTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PudoSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']//div[@class='address-info']")]
        public IWebElement PudoSelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@id='address-pickup-primary']")]
        public IWebElement PudoPrimaryCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement PudoUseThisBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City-Yandex']")]
        public IWebElement CityYandex { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='City_listbox']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State-Yandex']")]
        public IWebElement StateYandex { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='State_listbox']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='County']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side long-edit-btn']")]
        public IWebElement EditCustomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPudoLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@class='customer-form hl-form']//*[@id='btn-default-address-changed']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Пожалуйста, введите имя')]")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Пожалуйста, введите номер телефона')]")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Пожалуйста, введите Ваш индекс')]")]
        public IWebElement ZipFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement PersonalList_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']")]
        public IWebElement CustomerList_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchField_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[1]")]
        public IWebElement btbShowMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement MileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement GoogleSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind= 'invisible: PickupLocationsFoundFunc']/h4")]
        public IWebElement PickUpErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "((//div[@class='yandex-search-input-container'])[1]/descendant::ymaps[contains(@class,'search__suggest')])[15]")]
        public IWebElement IntuitiveFourthOption { get; set; }

        [FindsBy(How = How.XPath, Using = "((//div[@class='yandex-search-input-container'])[1]/descendant::ymaps[contains(@class,'search__suggest')])[10]")]
        public IWebElement IntuitiveThirdOption { get; set; }


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

        public void SelectAddress()
        {
            var val = MandatryFieldCount("//*[@id='locationList']/div");
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


        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
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
                    string ele = item.FindElement(By.XPath("//*[@class='address-info']")).Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.City) && ele.Contains(add.Zip))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");

                    string ele1 = IsCustomer == false ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text;
                    if (ele1 != null)
                        Assert.IsTrue(true);
                    else
                        Assert.IsFalse(true, "No tag found");

                    WaitForAddressList();
                    PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressForEMEA("DJ", "AkashEdit", "улица Арбат", "Street2", "МОСКВА", "102101", "654325654876544", "", "МОСКВА");

                    if (CommonMethods.IsElementDisplayed(EditCustomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCustomerLink);
                        EditCustomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        PageExtension.WaitForTimeSpan(1000);
                        StreetSearchAddress.SendKeys(add.Street);
                        PageExtension.WaitForTimeSpan(2000);
                        StreetSearchAddress.SendKeys(Keys.Down);
                        StreetSearchAddress.SendKeys(Keys.Enter);
                        PageExtension.WaitForTimeSpan(2000);
                        WaitSpinToFalse();
                        EditCustomerLink.Click();
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        PageExtension.WaitForTimeSpan(1000);
                        Street2.SendKeys(add.Street2);
                        PageExtension.WaitForTimeSpan(1000);
                        WaitSpinToFalse();
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
                        PageExtension.WaitForTimeSpan(2000);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        PageExtension.WaitForTimeSpan(1000);
                        WaitSpinToFalse();
                        if (IsCustomer)
                            CustomerRadioBtn.Click();
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
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
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
                    Validateshopperprofile(add.Zip, add.City, add.State);
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                }
                else
                    Assert.IsFalse(false, "No address found");
            }
            else
                Assert.IsFalse(false, "No address found");
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
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditCustomerLink));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        isValidaddress = true;
                        break;
                    }
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(Cancel))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        if (CommonMethods.IsElementDisplayed(ShippingAddrSave))
                        {
                            PageExtension.WaitForTimeSpan(1000);
                            PageExtension.WaitForTimeSpan(1000);
                            PageExtension.WaitForElementPresentAndVisible(this, EditCustomerLink);
                            EditCustomerLink.Click();
                            PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                            FirstName.Clear();
                            FirstName.SendKeys(add.FirstName);
                            PageExtension.WaitForTimeSpan(1000);
                            LastName.Clear();
                            LastName.SendKeys(add.LastName);
                            PageExtension.WaitForTimeSpan(1000);
                            Street.Clear();
                            Street.SendKeys(add.Street);
                            PageExtension.WaitForTimeSpan(1000);
                            Street2.Clear();
                            Street2.SendKeys(add.Street2);
                            PageExtension.WaitForTimeSpan(1000);
                            ZipCode.Clear();
                            ZipCode.SendKeys(add.Zip);
                            WaitSpinToFalse();
                            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
                            StateSelection(add.State);
                            PageExtension.WaitForTimeSpan(2000);
                            PhoneNumber.Clear();
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            PageExtension.WaitForTimeSpan(1000);
                            WaitSpinToFalse();
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            Driver.WaitForDocumentReady();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
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

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void ValidateshopperprofilePickUP(string Postalcodevalue, string Streetvalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(Postalcodevalue))
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
            SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 1, 1));
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            WaitForAddressList();
        }

        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false, bool IsCancel = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            this.WaitForElementClicklable(AddAddressBtn, 40);
            PageExtension.ScrollElementIntoMiddle(this, AddAddressBtn, 2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddress.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddress.SendKeys(Keys.Backspace);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddress.SendKeys(Keys.Down);
            StreetSearchAddress.SendKeys(Keys.Enter);
            PageExtension.WaitForTimeSpan(2000);
            Street.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            Street2.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(2000);
            ApartmentTextbox.SendKeys(add.Country);
            WaitSpinToFalse();
            ZipCode.SendKeys(add.Zip);
            WaitSpinToFalse();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
            PageExtension.WaitForTimeSpan(2000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            WaitSpinToFalse();
            if (IsCustomer)
                CustomerRadioBtn.Click();
            if (IsCancel)
                ShippingAddrCancel.Click();
            else 
            {
                ShippingAddrSave.Click(); 
            }
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }



        public Framework.Address ServiceDownAddAddress(Framework.Address add, bool IsCustomer = false, bool IsCancel = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            this.WaitForElementClicklable(AddAddressBtn, 40);
            PageExtension.ScrollElementIntoMiddle(this, AddAddressBtn, 2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddress.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddress.SendKeys(Keys.Backspace);
            PageExtension.WaitForTimeSpan(2000);
            StreetSearchAddress.SendKeys(Keys.Down);
            StreetSearchAddress.SendKeys(Keys.Enter);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            ZipCode.SendKeys(add.Zip);
            WaitSpinToFalse();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
            PageExtension.WaitForTimeSpan(2000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            WaitSpinToFalse();
            if (IsCustomer)
                CustomerRadioBtn.Click();
            if (IsCancel)
                ShippingAddrCancel.Click();
            else { ShippingAddrSave.Click(); }
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }


        /// <summary>
        /// Below Method is used for adding Duplicate data to System 
        /// </summary>
        /// <param name="add"></param>

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
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            ManageAddressLink.Click();
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
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
    public class DeliveryAddressPersonalPageTestRU : DeliveryAddressPersonalPage_RU { }
}
