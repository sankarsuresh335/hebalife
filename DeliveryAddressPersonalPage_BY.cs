using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_BY : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Управление адресами')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Сохраненные адреса')]")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-address-form']//*[@aria-owns='County_listbox']")]
        public IWebElement CustomerCounty { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='close-reveal-modal btn-delete']")]
        public IWebElement DeleteConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement GetAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='County_listbox']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='projectID']")]
        public IWebElement ProjectID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']")]
        public IWebElement GetAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CitySK { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side long-edit-btn']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        public IWebElement ProjectPopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='userNamePrj']")]
        public IWebElement ProjectUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Имя:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Фамилия:')]/span")]
        public IWebElement LastnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Почтовый индекс:')]/span")]
        public IWebElement ZipAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Область:')]/span")]
        public IWebElement CountyAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Город:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Улица:')]/span")]
        public IWebElement StreetAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Дом / Квартира:')]/span")]
        public IWebElement Street2Asterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Номер телефона:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        public IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street2']")]
        public IWebElement HouseFlatTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Zip']")]
        public IWebElement ZIPTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Пожалуйста, введите свое имя')]")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName' and contains(text(),' Пожалуйста, введите свою фамилию')]")]
        public IWebElement LastnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' Пожалуйста, введите почтовый индекс')]")]
        public IWebElement ZipErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='County' and contains(text(),' Пожалуйста, введите почтовый индекс')]")]
        public IWebElement CountyErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City' and contains(text(),'Пожалуйста,введите название города')]")]
        public IWebElement CityErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),'Пожалуйста, введите название улицы')]")]
        public IWebElement StreetErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street2' and contains(text(),'Пожалуйста, введите номер дома и квартиры')]")]
        public IWebElement Street2ErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),'Пожалуйста, введите номер телефона')]")]
        public IWebElement PhoneNumberErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Сочетание имени и фамилии не может превышать 40 символов')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Неверный номер телефона')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' Неверный Почтовый индекс')]")]
        public IWebElement ZipInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side long-edit-btn']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']//*[@id='btn-default-address-changed']")]
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
            ZIPTextBox.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(1000);
            CountySelection(add.Country, true);
            PageExtension.WaitForTimeSpan(2000);
            City.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(2000);
            StreetTextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            HouseFlatTextBox.SendKeys(add.Street2);
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

        public void EditAddress(Framework.Address add, bool IsCustomer = false, bool IsCancelled = false)
        {
            WaitForAddressList();
            PageExtension.WaitForTimeSpan(1000);
            PersonalAddrList.Click();
            add.ClearAddress();
            add.FillAddressForEMEA("DJ", "AkashEdit", "Street1Edit", "Street2Edit", "Southern", "", "876543265432", "", "Витебская обл.");
            PageExtension.WaitForTimeSpan(1000);
            if (CommonMethods.IsElementDisplayed(EditCostomerLink))
            {
                PageExtension.WaitForTimeSpan(2000);
                PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                EditCostomerLink.Click();
                PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                CountySelection(add.Country, true);
                PageExtension.WaitForTimeSpan(2000);
                FirstNameTextBox.Clear();
                FirstNameTextBox.SendKeys(add.FirstName);
                PageExtension.WaitForTimeSpan(2000);
                LastNameTextBox.Clear();
                LastNameTextBox.SendKeys(add.LastName);
                PageExtension.WaitForTimeSpan(1000);
                City.Clear();
                City.SendKeys(add.City);
                PageExtension.WaitForTimeSpan(2000);
                StreetTextBox.Clear();
                StreetTextBox.SendKeys(add.Street);
                PageExtension.WaitForTimeSpan(2000);
                HouseFlatTextBox.Clear();
                HouseFlatTextBox.SendKeys(add.Street2);
                PageExtension.WaitForTimeSpan(2000);
                PhoneTextBox.Clear();
                PhoneTextBox.SendKeys(add.PhoneNumber);
                PhoneTextBox.SendKeys(Keys.Tab);
                PageExtension.WaitForTimeSpan(1000);
                if (IsCustomer)
                    CustomerRdoBtn.Click();
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
                if (IsCancelled)
                    ShippingAddrCancel.Click();
                else
                {
                    ShippingAddrSave.Click();
                    PageExtension.WaitForElementClicklable(this, ShiptothisBut, 2000);
                    if (CommonMethods.IsElementDisplayed(ShiptothisBut))
                    {
                        ShiptothisBut.Click();
                        PageExtension.WaitForTimeSpan(2000);
                        PageExtension.WaitForElementClicklable(this, ShoppersAddr);
                        Assert.True(CommonMethods.IsElementEnabledAndDisplayed(ShoppersAddr));
                    }
                    else
                        Assert.IsFalse(true, "Failed to click Ship to address button ");
                }
                PageExtension.WaitForTimeSpan(3000);
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                WaitForAddressList();
                Assert.IsTrue(true, "Address successfully Edited");
            }
            else
                Assert.IsFalse(true, "No address found");
        }

        public void CountySelection(string CountyName, bool isPersonal = false)
        {
            if (isPersonal)
            {
                PageExtension.WaitForElementPresentAndDisable(this, County, 10);
                PageExtension.WaitForElementClicklable(this, County, 200);
                County.Click();
                PageExtension.WaitForTimeSpan(2000);
                var Countylist1 = InitializeReadOnlyCollection("//*[@id='County-list']//*[@id='County_listbox']/li").ToList();
                Countylist1.FirstOrDefault(i => i.Text.Contains(CountyName)).Click();
            }
            else
            {
                PageExtension.WaitForElementClicklable(this, CustomerCounty, 40);
                PageExtension.WaitForTimeSpan(1000);
                CustomerCounty.Click();
                PageExtension.WaitForTimeSpan(2000);
                var Countylist = InitializeReadOnlyCollection("//*[@id='County-list']//*[@id='County_listbox']/li").ToList();
                PageExtension.WaitForTimeSpan(2000);
                Countylist.FirstOrDefault(i => i.Text.Contains(CountyName)).Click();
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
            WaitSpinToFalse();
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
                        PageExtension.WaitForElementPresentAndVisible(this, DeleteConfirm);
                        DeleteConfirm.Click();
                        PageExtension.WaitForTimeSpan(2000);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        Driver.WaitForDocumentReady();
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
        public void CitySelection(string CityName)
        {
            City.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
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

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }

    }
    public class DeliveryAddressPersonalPageTestBY : DeliveryAddressPersonalPage_BY { }
}
