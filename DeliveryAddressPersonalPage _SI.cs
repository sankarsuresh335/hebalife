using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_SI : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
       
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Osebna')]")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Stranka')]")]
        public IWebElement CustomerTag { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']/span")]
        public IWebElement ShopperAddr { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h4")]
        public IWebElement ShoppersAddrPickUp { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h5")]
        public IWebElement ShoppersAddrText { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerAddressType { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PersonalAddressType { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']//*[@class='address-item']")]
        public IWebElement PickUpAddressItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street1TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip']")]
        public IWebElement ZipcodeErrorMsg { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-shipping-address']//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='saved-addresses']/h3")]
        public IWebElement ManageAddressPageTitle { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']/li")]
        public IWebElement SavedAddressText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Combination of First Name and Last Name cannot exceed 40 characters')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Zip2']")]
        public IWebElement PostalCode2 { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='StreetNumber']")]
        public IWebElement StreetNumber { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Neighbourhood']")]
        public IWebElement Neighbourhood { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='City_listbox']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Additional']")]
        public IWebElement Additional { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Province']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='AreaCode']")]
        public IWebElement AreaCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement ShippingAddrEdit { get; set; }
   
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUpLocation { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneType']")]
        public IWebElement PhoneType { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-item']")]
        public IWebElement AddressItem { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']/section/h3")]
        public IWebElement Choosepersonaladdress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']/section/p")]
        public IWebElement ChoosepersonaladdressText { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement ErrorMsgStreet { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='LastName']")]
        public IWebElement ErrorMsgInvalidLastName { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement ErrorMsgCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

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
            string value1 = Neighbourhood.InputBoxValue();
            string value2 = City.InputBoxValue();
            string value3 = State.InputBoxValue();
            if (value.Contains(Streetvalue) && value1.Contains(Neighbourhoodvalue) && value2.Contains(Cityvalue) && value3.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        
        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }
        
        public void CitySelection(string CityName)
        {
            PageExtension.WaitForTimeSpan(2000);
            City.Click();
            
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            //PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }



        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
            if (CommonMethods.IsElementDisplayed(AcceptCookies))
            {
                AcceptCookies.Click();
            }
            PageExtension.WaitForTimeSpan(2000);
            AddAddressBtn.Click();
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            CitySelection(add.City);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
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
            return add; ;
        }

        public void SearchAndEdit(Framework.Address add, bool IsCustomer = false)
        {

            //Select address from list and Edit address
            var count1 = InitializeReadOnlyCollection("//*[@id='addressList']/div/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");


                    WaitForAddressList();
                    PersonalAddrList.Click();

                    add.ClearAddress();
                    add.FillAddressforSAMCAM("Tes1h", "S", "streer44", "strrer565", "Begunje na Gorenjskem", "@#423sd", "19170", "1232997859");
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        PageExtension.WaitForTimeSpan(2000);
                        LastName.SendKeys(add.LastName);
                        Street1TextBox.Clear();
                        PageExtension.WaitForTimeSpan(1000);
                        Street1TextBox.SendKeys(add.Street);
                        PageExtension.WaitForTimeSpan(1000);
                        CitySelection(add.City);
                        PhoneTextBox.Clear();
                        PhoneTextBox.SendKeys(add.PhoneNumber);
                        PageExtension.WaitForTimeSpan(1000);
                        if (IsCustomer)
                            CustomerRdoBtn.Click();
                        PageExtension.WaitForTimeSpan(3000);
                        WaitSpinToFalse();
                        ShippingAddrEdit.Click();
                        PageExtension.WaitForTimeSpan(3000);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
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
                WaitSpinToFalse();
                WaitForAddressList();
                var count = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
                if (count != null && count.Count > 0)
                {
                    foreach (var item in count)
                    {
                        string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;
                        if (ele.Contains(add.FirstName) && ele.Contains(add.Street))
                            Assert.IsTrue(true, "The address is successfully Edited");
                        else
                            Assert.IsTrue(false, "Address is not Matching");

                        
                    }
                }
                PersonalAddrList.Click();
                if (CommonMethods.IsElementDisplayed(ShiptothisBut))
                {
                    PageExtension.WaitForElementPresentAndVisible(this, ShiptothisBut);
                    PageExtension.WaitForTimeSpan(2000);
                    ShiptothisBut.Click();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    Driver.WaitForDocumentReady();
                    PageExtension.WaitForTimeSpan(6000);
                    PageExtension.WaitForElementPresentAndVisible(this, ShoppersAddr);
                    Driver.WaitForDocumentReady();
                }
                else
                    Assert.IsFalse(false, "No address found");
            }
        }

        public void ValidateshopperprofilePickUp(string expected, string expectedText)
        {
            Assert.IsTrue(ShoppersAddrPickUp.Text.Contains(expected));
            Assert.IsTrue(ShoppersAddrText.Text.Contains(expectedText));
        }
        public void ValidateshopperprfilePickUp(string expected, string expectedText)
        {
            Assert.IsTrue(ShopperAddr.Text.Contains(expected));
            Assert.IsTrue(ShopperAddr.Text.Contains(expectedText));
        }
        public void SelectPhoneOption(string option)
        {
            PhoneType.SelectDropDownOption(option);
        }
        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
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
        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            //Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));

        }
        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        public void ValidateAttributeContains(string Cityvalue, string Statevalue)
        {

            string value = City.InputBoxValue();
            string value2 = State.InputBoxValue();
            if (value.Contains(Statevalue) && value2.Contains(Cityvalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

        
        //Shopper Profile Validation for Pickup
        public void ValidateshopperprofilePickUp(string expected)
        {
            string Actual = ShoppersAddr.Text;
            Assert.IsTrue(Actual.Contains(expected));
        }
        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        
    }
    public class DeliveryAddressPersonalPageTestSI : DeliveryAddressPersonalPage_SI { }
}
