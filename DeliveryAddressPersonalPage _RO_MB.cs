using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_RO_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ship-to-courier']")]
        public IWebElement CourierTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='new-saved-address-']")]
        public IWebElement AddNewAddressPopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//section[@class='saved-content']")]
        public IWebElement SavedAddressesPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='StreetInput']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street4']")]
        public IWebElement Street4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='County']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement ZIP { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedPickupAddress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[@id='County']")]
        public IWebElement CountryErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement StreetInputErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//Span[@data-for='Street2']")]
        public IWebElement Street2ErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Zip']")]
        public IWebElement PostalCodeFieldErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'shipping selected']")]
        public IWebElement VerifyShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Gestionează adrese ')]")]
        public IWebElement ManageAddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn - default - address - changed']")]
        public IWebElement SendAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='shopping -as personal']")]
        public IWebElement ShoppingPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='source: MyHerbalifeLocations, events: {change: onSelectPickup, dataBound: onPickupsBound}']")]
        public IWebElement PickupLocationList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickupSelection { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Locații ridicare')]")]
        public IWebElement PickupNote { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Selectează adresa')]")]
        public IWebElement PickupNote1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div")]
        public IWebElement SelectPickupaddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='html: DisplayedInfo']")]
        public IWebElement ShopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Editează informațiile')]")]
        public IWebElement EditAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-cancel-new-address']")]
        public IWebElement CancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-address-delete'])[1]")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-duplicated-contact']//div[@class='address-info']")]
        public IWebElement DuplicateAddressSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Se Encontraron Duplicados')]")]
        public IWebElement DuplicatePopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'În lista ta am găsit cont')]")]
        public IWebElement DuplicateWarningMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class = 'customer-ship']")]
        public IWebElement ShopperAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

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
        public void ValidateAttributeContains(string Streetvalue, string CountyValue, string Cityvalue, string StateValue , string Street2value)
        {
            string value = Street.InputBoxValue();
            string value1 = County.GetAttribute("innerHTML");
            string value2 = City.GetAttribute("innerHTML");
            string value3 = State.GetAttribute("innerHTML");
            string value4 = Street2.InputBoxValue();
            if (value.Contains(Streetvalue) && value1.Contains(CountyValue) && value2.Contains(Cityvalue) && value3.Contains(StateValue) && value4.Contains(Street2value))                
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsFalse(false, "The Value not set Correctly");
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

        /// <summary>
        /// Below Method is use for Searching and Edit Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        /// <param name="IsCustomer"></param>
        public void SearchAndEdit(Framework.Address add)
        {

            //Select address from list and Edit address
            var count1 = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.Street2) && ele.Contains(add.City) && ele.Contains(add.State))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");

                    WaitForAddressList();
                    PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressForEMEA("Y3", "Last", "Straight@Road12", "1111", "Berlesti", "", "994353453", "Bulevard", "Braila");

                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        PageExtension.WaitForTimeSpan(2000);
                        WaitSpainToFalse();
                        StateSelection(add.State);
                        PageExtension.WaitForTimeSpan(2000);
                        CitySelection(add.City);
                        PageExtension.WaitForTimeSpan(2000);
                        CountySelection(add.Street);
                        PageExtension.WaitForTimeSpan(2000);
                        StreetSelection(add.Street2);
                        Street2.Clear();
                        Street2.SendKeys(add.Street2);
                        Street4.Clear();
                        Street4.SendKeys(add.Street);
                        PageExtension.WaitForTimeSpan(3000);
                        ValidateAttributeContains(add.Street2, add.Street, add.City, add.State, add.Street2);
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
                        if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.City) && ele.Contains(add.State))
                            Assert.IsTrue(true, "The address is successfully Edited");
                        else
                            Assert.IsTrue(false, "Address is not Matching");

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
            else
                Assert.IsFalse(false, "No address found");
        }
        /// <summary>
        /// Below Method is use for Searching Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        public void SearchAddress(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 2));
            WaitSpainToFalse();
            WaitForAddressList();
        }
        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
           // Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            //string firstName, string lastname, string street, string street2, string city, string postalCode, string phoneNumber, string country = null, string state = null
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            StateSelection(add.State);
            PageExtension.WaitForTimeSpan(2000);
            CitySelection(add.City);
            PageExtension.WaitForTimeSpan(2000);
            CountySelection(add.Country);
            PageExtension.WaitForTimeSpan(2000);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            return add;
        }

        public void StateSelection(string StateName)
        {
            State.SelectDropDownOption(StateName);

        }


        public void CitySelection(string CityName)
        {
            City.SelectDropDownOption(CityName);

        }

        public void CountySelection(string CountyName)
        {
            County.SelectDropDownOption(CountyName);

        }

        public void StreetSelection(string StreetName)
        {
            Street.SelectDropDownOption(StreetName);

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
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            StateSelection(add.State);
            PageExtension.WaitForTimeSpan(2000);
            CitySelection(add.City);
            PageExtension.WaitForTimeSpan(2000);
            CountySelection(add.Street);
            PageExtension.WaitForTimeSpan(2000);
            StreetSelection(add.Street2);
            Street2.SendKeys(add.Zip);
            Street4.SendKeys(add.StreetNumber);
            PhoneNumber.SendKeys(add.PhoneNumber);
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
            SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 2));
            WaitSpainToFalse();
            WaitForAddressList();
        }
        public void VerifyFieldLength()
        {
            AddAddressBtn.Click();
            TextFieldCount(FirstName, 20, "weuwqtetqweiywqeyoqw");
            TextFieldCount(LastName, 20, "weuwqtetqweiywqeyow1");
            TextFieldCount(Street2, 4, "r7493");
            TextFieldCount(Street4, 50, "r7493hfh4392ruowejrooerjewjrlwejrwlrwle45435345435");
            TextFieldCount(PhoneNumber, 9, "123456789");

        }
        public static void TextFieldCount(IWebElement webEle, int Count, string Actvalue)
        {
            webEle.SendKeys(Actvalue);
            int ActualCount = webEle.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        public void VerifyFieldErrorMessage()
        {
            //SAVE WITH THE BLANK ADDRESSES 
            PageExtension.WaitForTimeSpan(3000);
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
            ShippingAddrSave.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameFieldErrorMsg));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(StateFieldErrorMsg));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(CityFieldErrorMsg));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(CountryErrorMsg));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(StreetInputErrorMsg));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Street2ErrorMsg));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PostalCodeFieldErrorMsg));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PhoneFieldErrorMsg));

        }

        public void Validateshopperprofile(string FirstName, string State, string City, string County, string StreetInput, string Street2, string Zip, string PhoneNumber)
        {
            string value = ShopperAddr.GetAttribute("innerHTML");
            if (value.Contains(FirstName) && value.Contains(State) && value.Contains(City) && value.Contains(County) && value.Contains(StreetInput) && value.Contains(Street2) && value.Contains(Zip) && value.Contains(PhoneNumber))
                Assert.IsTrue(true, "The Value Displayed Correctly");
            else
                Assert.IsTrue(false, "The Values are Not Displaying Correctly");
        }
        public void VerifyShipping()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(VerifyShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddressButton));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ManageAddressButton));
        }
            public static void NumberFieldCount(IWebElement webEle, int Count, string Actvalue)
            {
                webEle.SendKeys(Actvalue);
                int ActualCount = webEle.InputBoxValue().Length;
                Assert.AreEqual(ActualCount, Count);
            }

        }
    public class DeliveryAddressPersonalPageTestROMB : DeliveryAddressPersonalPage_RO_MB { }
}


