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
    public class DeliveryAddressPersonalPage_UY : Page
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

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='button-set']//*[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='saved-addresses']/h3")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement GetAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']")]
        public IWebElement GetAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']/h4")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns='State_listbox' and @class='k-widget k-dropdown k-header']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State_listbox']/li")]
        public IWebElement StateList { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement CityList { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns='City_listbox' and @class='k-widget k-dropdown k-header']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns='County_listbox' and @class='k-widget k-dropdown k-header']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Zip']")]
        public IWebElement PostalCodeTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Nombre es obligatorio')]")]
        public IWebElement FirstnameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName' and contains(text(),' Apellido es obligatorio')]")]
        public IWebElement LastnameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),' Por favor ingrese calle')]")]
        public IWebElement StreetErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City' and contains(text(),' Por favor complete la ciudad')]")]
        public IWebElement CityErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='State' and contains(text(),' Por favor complete el Estado')]")]
        public IWebElement StateErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Por favor ingrese el número de teléfono')]")]
        public IWebElement PhoneNumbererrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Numero de telefono invalido')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' Código postal no válido')]")]
        public IWebElement PostalCodeInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Combinación de Nombre y Apellido no pueden exceder los 40 caracteres.')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='close-reveal-modal btn-delete']")]
        public IWebElement DeleteConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressSavedCorrectly')]")]
        public IWebElement AddressSavedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressUpdatedCorrectly')]")]
        public IWebElement AddressUpdatedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-cancel-new-address-edit']")]
        public IWebElement CancelButtonEditAddressForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btn-save-new-address-edit']")]
        public IWebElement SaveButtonEditAddressForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

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
            PageExtension.WaitForTimeSpan(1000);
            LastNameTextBox.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetTextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            StateSelection(add.State);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            CitySelection(add.City);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            CountySelection(add.Country);
            PageExtension.WaitForTimeSpan(1000);
            WaitSpinToFalse();
            PostalCodeTextBox.SendKeys(add.Zip);
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
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 60);
            return add;
        }

        public void SearchAddress(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
        }

        public Framework.Address EditAddress(Framework.Address add, bool IsCustomer = false, bool IsAlreadyCustomer = false, bool IsAlreadyPersonal = false, bool IsCancel = false)
        {
            if (CommonMethods.IsElementDisplayed(PersonalAddrList))
                PersonalAddrList.Click();
            add.ClearAddress();
            add.FillAddressForEMEA("DJ", "AkashEdit", "Street1New", "", "MONTEVIDEO", "78900", "3456111111", "ATAHUALPA", "MONTEVIDEO");
            if (CommonMethods.IsElementDisplayed(EditInformation))
            {
                PageExtension.WaitForTimeSpan(1000);
                PageExtension.WaitForElementPresentAndVisible(this, EditInformation);
                EditInformation.Click();
                PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                FirstNameTextBox.Clear();
                FirstNameTextBox.SendKeys(add.FirstName);
                PageExtension.WaitForTimeSpan(1000);
                LastNameTextBox.Clear();
                LastNameTextBox.SendKeys(add.LastName);
                PageExtension.WaitForTimeSpan(1000);
                StreetTextBox.Clear();
                StreetTextBox.SendKeys(add.Street);
                PageExtension.WaitForTimeSpan(1000);
                StateSelection(add.State);
                PageExtension.WaitForTimeSpan(2000);
                CitySelection(add.City);
                PageExtension.WaitForTimeSpan(2000);
                CountySelection(add.Country);
                PageExtension.WaitForTimeSpan(1000);
                PostalCodeTextBox.Clear();
                PostalCodeTextBox.SendKeys(add.Zip);
                PageExtension.WaitForTimeSpan(2000);
                PhoneTextBox.Clear();
                PhoneTextBox.SendKeys(add.PhoneNumber);
                PageExtension.WaitForTimeSpan(1000);
                if (IsCustomer)
                    CustomerRdoBtn.Click();
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
                if (IsCancel)
                    ShippingAddrCancel.Click();
                else
                    ShippingAddrSave.Click();
                PageExtension.WaitForTimeSpan(3000);
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                WaitForAddressList();
                Assert.IsTrue(true, "Address successfully Edited");
            }
            else
                Assert.IsFalse(true, "No address found");
            return add;

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

        public void CountySelection(string CountyName)
        {
            County.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Countylist = InitializeReadOnlyCollection("//*[@id='County-list']//*[@id='County_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Countylist.FirstOrDefault(i => i.Text.Contains(CountyName)).Click();
        }

        public void StateSelectionAll(string StateName)
        {
            State.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.Find(i => i.Text.Contains(StateName)).Click();
        }

        public void CitySelectionAll(string CityName)
        {
            City.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.Find(i => i.Text.Contains(CityName)).Click();
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

        public void RefreshPage(Framework.Address add)
        {
            WaitSpinToFalse();
            Driver.Navigate().Refresh();
            WaitSpinToFalse();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
            Driver.WaitForDocumentReady();
            PageExtension.WaitForTimeSpan(5000);
            SearchFieldPersonal.SendKeys(add.FirstName);
            SearchFieldPersonal.SendKeys(Keys.Control + "a");
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
        }

        public void ValidateAttributeContains(Framework.Address add)
        {
            GetAddressList.Click();
            WaitSpinToFalse();
            string value = GetAddAddress.Text;
            if (value.Contains(add.FirstName) && value.Contains(add.LastName) && value.Contains(add.Street) && value.Contains(add.PhoneNumber))
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

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
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

        public string SelectValidPersonalSavedAddressToEdit()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            string FullNameSelectedSavedPersonalAddress = string.Empty;
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);
                if (! CommonMethods.IsElementDisplayed(ShippingAddrSave) && ! CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalTag));
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalTag));
                    FullNameSelectedSavedPersonalAddress = displayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedPersonalAddress;
        }

        public string SelectValidCustomerSavedAddressToEdit()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> customerContactList = Driver.FindElements(By.XPath("//*[@class='type Customer']"));
            string FullNameSelectedSavedCustomerAddress = string.Empty;
            new Actions(Driver).MoveToElement(CustomerTag).Perform();
            for (int i = 0; i <= customerContactList.Count; i++)
            {

                if (i == customerContactList.Count)
                {
                    Assert.False(false, "Customer address not valid.");
                    break;
                }

                customerContactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 60);
                PageExtension.WaitForTimeSpan(1000);
                if (! CommonMethods.IsElementDisplayed(ShippingAddrSave) && ! CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(CustomerTag));
                    FullNameSelectedSavedCustomerAddress = displayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedCustomerAddress;
        }
    }
    public class DeliveryAddressPersonalPageTestUY : DeliveryAddressPersonalPage_UY { }
}