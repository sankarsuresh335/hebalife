﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_NO_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']/span")]
        public IWebElement ShopperAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement PickupAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h4")]
        public IWebElement ShoppersAddrPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h5")]
        public IWebElement ShoppersAddrText { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@style='float:left']/label[@for='address-type']")]
        public IWebElement AddressType { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PersonalAddressType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street1TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement ZIPTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CityTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip']")]
        public IWebElement ZipcodeErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-shipping-address']//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Beklager, søket ditt ga ingen treff i lagrede adresser. Prøv igjen.')]")]
        public IWebElement NoAddressfoundMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Fornavn og etternavn kan ikke overstige 40 tegn')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Country']")]
        public IWebElement Country { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement GoogleSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='click: clearSearch']")]
        public IWebElement SearchFieldCloseBtnP { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']//span[@data-bind='invisible: showMap']")]
        public IWebElement ViewMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: showMap']")]
        public IWebElement ViewMapLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//*[@data-bind='visible: isLocationFound']//h4")]
        public IWebElement NoPickUpLocationFound { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']/div[4]/div[3]/a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement EditAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Vennligst fyll ut etternavn')]")]
        public IWebElement ErrorMsgLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement ErrorMsgStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement ErrorMsgCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement DisplayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement SelectAddrs { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[1]")]
        public IWebElement USeSelectedAddPUdo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PUDOTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']/option")]
        public IWebElement MilesDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='address-pickup-filter']")]
        public IWebElement MagnifierIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement SelectAddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible: Distance']")]
        public IWebElement DistanceinKM { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Oppgi poststed for å finne et hentested i nærheten av deg.')]")]
        public IWebElement PudoTabTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@placeholder='Skriv inn gate, by eller fylke, mer enn tre tegn.']")]
        public IWebElement PudoSearchWaterMark { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewonMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PUDOSearchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='last'])[1]")]
        public IWebElement AddressValue { get; set; }


        [FindsBy(How = How.XPath, Using = "(//*[@src='/Shop/Address/images/Bring_priRGBpos.jpg'])[1]")]
        public IWebElement AddressValueInpostIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='notification-success'])[1]")]
        public IWebElement AddressUpdatedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'shippingSelectedAddress.FullAddress')]")]
        public IWebElement FullAddressDelivery { get; set; }

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

        public Framework.Address AddAddress(Framework.Address add, bool iscancelled = false)
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
            Street2.SendKeys(add.Street2);
            City.SendKeys(add.City);
            PageExtension.WaitForTimeSpan(2000);
            PostalCode.SendKeys(add.Zip);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            
            if (iscancelled)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add; ;
        }

        public void ValidateAddressDisplayedByAlphabeticalOrder()
        {
            List<String> originalList = new List<String>();
            List<String> SortedList = new List<String>();
            var count = InitializeReadOnlyCollection("//*[@class='address-item']/div/strong");
            if (count != null && count.Count > 0)
            {
                foreach (var item in count)
                {
                    string ele = item.Text.ToString().Trim();
                    string[] FullName = Regex.Split(ele, " ");
                    originalList.Add(FullName[0]);
                    SortedList.Add(FullName[0]);
                }
            }
            SortedList.Sort();
            Assert.AreEqual(SortedList, originalList);
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
                    add.FillAddressforSAMCAM("Tes1tSh", "Shikar", "streer44", "strrer565", "bangalore", "", "9170", "32997859");
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
                        Street2.Clear();
                        Street2.SendKeys(add.Street2);
                        PageExtension.WaitForTimeSpan(2000);
                        City.Clear();
                        City.SendKeys(add.City);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
                        PostalCode.Clear();
                        PostalCode.SendKeys(add.Zip);
                        PageExtension.WaitForTimeSpan(2000);
                        PhoneTextBox.Clear();
                        PhoneTextBox.SendKeys(add.PhoneNumber);
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
        }

        /// <summary>
        /// Below Method is used for adding Duplicate data to System
        /// Below Method is used for validating Duplicate popup 
        /// </summary>
        /// <param name="add"></param>
        public void VerifyDuplicatePopUP(Shop.Automation.Framework.Address add)
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
            //Search address
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();                      
        }

        public void ValidateshopperprfilePickUp(string expected, string expectedText)
        {
            Assert.IsTrue(ShopperAddr.Text.Contains(expected));
            Assert.IsTrue(ShopperAddr.Text.Contains(expectedText));
        }

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void SearchAddress(string FirstName)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }

        //Shopper Profile Validation for Shipping
        public void ValidateShopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
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

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        public string SelectValidPersonalSavedAddress()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            string FullNameSelectedSavedPersonalAddress = string.Empty;
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);
                if (!CommonMethods.IsElementDisplayed(ShippingAddrSave) && !CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                {
                    Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalTag));
                    FullNameSelectedSavedPersonalAddress = DisplayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedPersonalAddress;
        }
    }
    public class DeliveryAddressPersonalPageTestNOMB : DeliveryAddressPersonalPage_NO_MB { }
}