using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Shop.Automation.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_MD : Page
    {
        public string AddressPathHome => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/Home/Login/DS/{RunSettings.ValidUser.DSID}";

        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='City_listbox']")]
        public IWebElement CityDropDown { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='City-list']//*[@id='City_listbox']/li")]
        public IWebElement Citylist { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='State_listbox']")]
        public IWebElement StateDropDown { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']/span")]
        public IWebElement ShopperAddr { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h5")]
        public IWebElement ShoppersAddrText { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerAddressType { get; set; }
       
        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PersonalAddressType { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='State-list']//*[@class='k-list-optionlabel']")]
        public IWebElement SelectText { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']//*[@class='address-item']")]
        public IWebElement PickUpAddressItem { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street1TextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement ZIPTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CityTextBox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address-edit']")]
        public IWebElement ShippingAddrEditCancel { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-shipping-address']//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='address-section']//*[@class='saved-addresses']")]
        public IWebElement SavedAddressText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//li[2]//span[@class='note']")]
        public IWebElement ZipFormat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//ul[4]//li[1]//span[@class='note']")]
        public IWebElement PhoneFormat { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Combinația de prenume și prenume nu poate depăși 40 de caractere')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']/ul[2]/li[2]/label")]
        public IWebElement City { get; set; }
        
        [FindsBy(How = How.XPath, Using = "(//div[@class='address-info'])[1]")]
        public IWebElement SelectAddressValue1 { get; set; }

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

        [FindsBy(How = How.XPath, Using = " //div[@data-bind='fadeIn: AddressUpdatedCorrectly']")]
        public IWebElement AddressUpdated { get; set; }
       

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCustomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUpLocation { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address']")]
        public IWebElement ShopProfileAddress { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneType']")]
        public IWebElement PhoneType { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']/section/h3")]
        public IWebElement Choosepersonaladdress { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']/section/p")]
        public IWebElement ChoosepersonaladdressText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']/a/span")]
        public IWebElement shopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement ErrorMsgFirstName { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement ErrorMsgStreet { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-for='LastName']")]
        public IWebElement ErrorMsgLastName { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement ErrorMsgRegion { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-for='State']")]
        public IWebElement ErrorMsgArea { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h4")]
        public IWebElement ShoppersAddrPickUp { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }
        
        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='saved-information']//*[@id='contactList']")]
        public IWebElement CustomerList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement PersonalList { get; set; }

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

        public void ValidateAttributeContains(string Zip, string Streetvalue, string Cityvalue)
        {
            string value2 = Street.InputBoxValue();
            string value3 = City.InputBoxValue();
            if (value2.Contains(Streetvalue) && value3.Contains(Cityvalue))
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


     
        public void SelectAreaOption(string StateName)
        {
            PageExtension.WaitForTimeSpan(3000);
            StateDropDown.Click();
            PageExtension.WaitForTimeSpan(3000);
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(3000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
            PageExtension.WaitForTimeSpan(3000);


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
            PageExtension.WaitForTimeSpan(3000);
            SelectAreaOption(add.State);
            PageExtension.WaitForTimeSpan(4000);
            CityTextBox.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(2000);
            ZIPTextBox.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(3000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            if (IsCustomer)
                CustomerRdoBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            PageExtension.ScrollElementIntoMiddle(this, ShippingAddrCancel);
            if (iscancelled)

                ShippingAddrCancel.Click();
            else
                PageExtension.ScrollIntoView(this, ShippingAddrSave);
            PageExtension.ScrollElementIntoMiddle(this, ShippingAddrCancel);
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
                    //PersonalAddrList.Click();

                    add.ClearAddress();
                    add.FillAddressforSAMCAM("PErRVY222", "rRY321", "PrERYStr12#", "", "VYMaldova", "Anenii Noi", "XX1255", "12322259995");
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {

                        PageExtension.WaitForTimeSpan(5000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        PageExtension.ScrollElementIntoMiddle(this, EditCostomerLink);
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
                        PhoneTextBox.Clear();
                        PhoneTextBox.SendKeys(add.PhoneNumber);
                        PageExtension.WaitForTimeSpan(1000);
                        if (IsCustomer)
                            CustomerRdoBtn.Click();
                        PageExtension.WaitForTimeSpan(3000);
                        WaitSpinToFalse();
                        if (CommonMethods.IsElementDisplayed(ShippingAddrEdit))

                            ShippingAddrEdit.Click();
                        else
                            PageExtension.ScrollElementIntoMiddle(this, ShippingAddrSave);
                        ShippingAddrSave.Click();

                        PageExtension.WaitForTimeSpan(5000);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);

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

                        string ele1 = IsCustomer == true ? CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text : CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal'] ").Text;
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
                    PageExtension.WaitForTimeSpan(3000);
                    ShiptothisBut.Click();
                    PageExtension.WaitForTimeSpan(8000);
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
        public void ValidateshopperprfilePickUp(string expectedText)
        {

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


        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

        
        public void SearchNewlyAddedAddress(Framework.Address add, bool IsCustomer = false)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchField);
            SearchField.Clear();
            SearchField.SendKeys(add.FirstName);
            WaitSpainToFalse();
            if (IsCustomer)
                PageExtension.WaitForElementPresentAndVisible(this, CustomerList);
            else
                PageExtension.WaitForElementPresentAndVisible(this, PersonalList);
        }


    }

    public class DeliveryAddressPersonalPageTestMD : DeliveryAddressPersonalPage_MD { }
}