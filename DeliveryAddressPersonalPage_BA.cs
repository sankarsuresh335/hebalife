using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_BA : Page
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

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='button-set']//*[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Spremljene adrese')]")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement GetAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Lično')]")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']")]
        public IWebElement GetAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CitySK { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditInformationLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ime:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Prezime:')]/span")]
        public IWebElement LastnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Grad:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ulica 1:')]/span")]
        public IWebElement Street1Asterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Telefonski broj:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Poštanski broj:')]/span")]
        public IWebElement PostalCodeAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        public IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='City_listbox']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='State_listbox']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='button-set']/a[@class='close-reveal-modal btn-delete'])[4]")]
        public IWebElement DeleteConfirmCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='close-reveal-modal btn-delete']")]
        public IWebElement DeleteConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street1']")]
        public IWebElement Street1TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street2']")]
        public IWebElement Street2TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),'Molimo upišite ime')]")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName' and contains(text(),'Molimo upišite prezime')]")]
        public IWebElement LastnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),'Molimo upišite Vaš poštanski broj.')]")]
        public IWebElement PostalCodeerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City' and contains(text(),' Molimo odaberite Vaš grad.')]")]
        public IWebElement CityerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street1' and contains(text(),'Molimo upišite ulicu.')]")]
        public IWebElement Street1errorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),'Molimo upišite telefonski broj')]")]
        public IWebElement PhoneNumbererrorMsg { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Kombinacija imena i prezimena ne smije biti veća od 40 znakova')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),'Broj telefona je nevažeći')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns='Zip_listbox']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='Zip_listbox']/li")]
        public IList<IWebElement> PostalCodeList { get; set; }

        


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
            Street1TextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            CitySelection(add.City);
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
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditInformationLink));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        isValidaddress = true;
                        break;
                    }
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        if (CommonMethods.IsElementDisplayed(ShippingAddrSave))
                        {
                            PageExtension.WaitForTimeSpan(1000);
                            FirstNameTextBox.Clear();
                            FirstNameTextBox.SendKeys(add.FirstName);
                            PageExtension.WaitForTimeSpan(1000);
                            LastNameTextBox.Clear();
                            LastNameTextBox.SendKeys(add.LastName);
                            PageExtension.WaitForTimeSpan(1000);
                            Street1TextBox.Clear();
                            Street1TextBox.SendKeys(add.Street);
                            PageExtension.WaitForTimeSpan(1000);
                            CitySelection(add.City);
                            PageExtension.WaitForTimeSpan(2000);
                            PhoneTextBox.Clear();
                            PhoneTextBox.SendKeys(add.PhoneNumber);
                            PhoneTextBox.SendKeys(Keys.Tab);
                            PageExtension.WaitForTimeSpan(1000);
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            Driver.WaitForDocumentReady();
                            WaitForAddressList();
                            ShiptothisBut.Click();
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

        public void SearchAddress(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
            ValidateAttributeContains(add);
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

        public void SearchAndEdit(Framework.Address add, bool IsCustomer = false)
        {

            //Select address from list and Edit address

            WaitForAddressList();
            PersonalAddrList.Click();
            add.ClearAddress();
            add.FillAddressForEMEA("DJ", "Akash", "Street1Edit", "", "ARIZONA (BHP SA)", "76219", "9848002222");
            if (CommonMethods.IsElementDisplayed(EditInformationLink))
            {
                PageExtension.WaitForTimeSpan(1000);
                PageExtension.WaitForElementPresentAndVisible(this, EditInformationLink);
                EditInformationLink.Click();
                PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                FirstNameTextBox.Clear();
                FirstNameTextBox.SendKeys(add.FirstName);
                PageExtension.WaitForTimeSpan(1000);
                LastNameTextBox.Clear();
                LastNameTextBox.SendKeys(add.LastName);
                PageExtension.WaitForTimeSpan(1000);
                Street1TextBox.Clear();
                Street1TextBox.SendKeys(add.Street);
                PageExtension.WaitForTimeSpan(1000);
                CitySelection(add.City);
                PageExtension.WaitForTimeSpan(2000);
                PhoneTextBox.Clear();
                PhoneTextBox.SendKeys(add.PhoneNumber);
                PhoneTextBox.SendKeys(Keys.Tab);
                PageExtension.WaitForTimeSpan(1000);
                if (IsCustomer)
                    CustomerRdoBtn.Click();
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
                ShippingAddrSave.Click();
                PageExtension.WaitForTimeSpan(3000);
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                WaitForAddressList();
                Assert.IsTrue(true, "Address successfully Edited");
                //Edited address validation and Ship to same address
                PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
                SearchFieldPersonal.Clear();
                SearchFieldPersonal.SendKeys(add.FirstName);
                WaitSpinToFalse();
                PageExtension.WaitForTimeSpan(2000);
                var count = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
                if (count != null && count.Count > 0)
                {
                    foreach (var item in count)
                    {
                        string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;
                        PageExtension.WaitForTimeSpan(1000);
                        if (ele.Contains(add.Street) && ele.Contains(add.Zip))
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
                    Validateshopperprofile(add);
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    Driver.WaitForDocumentReady();
                }
                else
                    Assert.IsFalse(false, "No address found");
            }
            else
                Assert.IsFalse(true, "No address found");
            
        }

        public void ValidateAttributeContains(Framework.Address add)
        {
            GetAddressList.Click();
            WaitSpinToFalse();
            string value = GetAddAddress.Text;
            PageExtension.WaitForTimeSpan(1000);
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
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }
        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
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

        public void CitySelectionRandom()
        {
            City.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            int randnMumber = new System.Random().Next(0, Citylist.Count);
            Citylist.ElementAt(randnMumber).Click();
        }

        public void ZipSelection()
        {
            PostalCode.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Ziplist = InitializeReadOnlyCollection("//ul[@id='Zip_listbox']/li").ToList();
            Ziplist.ElementAt(0);
        }


    }
    public class DeliveryAddressPersonalPageTestBA : DeliveryAddressPersonalPage_BA { }
}
