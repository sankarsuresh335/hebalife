using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_ID : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']//div[@class='address-info'])[1]")]
        public IWebElement PickUpAddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='MyHerbalifelocationList']//div[@class='address-info'])[2]")]
        public IWebElement PickUpAddressValue2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickup-search-value']")]
        public IWebElement PickUpSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-pickup-delivery']")]
        public IWebElement PickUpUseselectedBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: HasAddresses' and contains(@href,'/id-ID/Shop')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-item']//*[@class='address-info']//*[@class='type Customer'])[1]")]
        public IWebElement CustomerFirstAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-item']//*[@class='address-info']//*[@class='type Personal'])[1]")]
        public IWebElement PersonalFirstAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]  //Alamat 1
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")] //Alamat 2
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City' and @data-bind='value: Address.City']")]
        public IWebElement CityID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']//parent::Span")]
        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State' and @data-bind='value: Address.State']")]
        public IWebElement StateID { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='County']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SubCounty']")]
        public IWebElement SubCounty { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@class='plus btn-increment'])[1]")]
        public IWebElement AddSkuplusbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-add-cart']")]
        public IWebElement Addcartbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCustomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']/ancestor::li/span[contains(.,' Silahkan masukkan Nama Depan.')]")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']/ancestor::li/span[contains(.,' Silahkan masukkan Alamat.')]")]
        public IWebElement ErrorMsgStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']/ancestor::li/span[contains(.,' Silahkan pilih Provinsi Anda')]")]
        public IWebElement ErrorMsgState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']/ancestor::li/span[contains(.,' Silahkan pilih Kota Anda')]")]
        public IWebElement ErrorMsgCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='County']/ancestor::li/span[contains(.,'  Silahkan pilih Kecamatan Anda')]")]
        public IWebElement ErrorMsgCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SubCounty']/ancestor::li/span[contains(.,'Silahkan pilih Kelurahan Anda')]")]
        public IWebElement ErrorMsgSubCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/ancestor::li/span[contains(.,' Silahkan masukkan Nomor Telepon')]")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']/following-sibling::span[contains(text(),' Nomor Telepon tidak benar')]")]
        public IWebElement PhoneFormat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']/a/span")]
        public IWebElement shopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']")]
        public IWebElement PickupList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='County' and @data-bind='value: Address.County']")]
        public IWebElement CountyID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SubCounty' and @data-bind='value: Address.SubCounty']")]
        public IWebElement SubCountyID { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nama Depan:')]/span[contains(text(),'*')]")]
        public IWebElement FirstNameAsterisk{ get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Alamat 1:')]/span[contains(text(),'*')]")]
        public IWebElement StreetAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Provinsi:')]/span[contains(text(),'*')]")]
        public IWebElement StateAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Kota:')]/span[contains(text(),'*')]")]
        public IWebElement CityAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Kecamatan:')]/span[contains(text(),'*')]")]
        public IWebElement Countysterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Kelurahan:')]/span[contains(text(),'*')]")]
        public IWebElement SubCountysterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Kode pos:')]/span[contains(text(),'*')]")]
        public IWebElement Zipsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nomor Telepon:')]/span[contains(text(),'*')]")]
        public IWebElement Phoneterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Pribadi')]")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),'Pelanggan')])[2]")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressIteam { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-go-checkout']")]
        public IWebElement GOToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div[1]")]
        public IWebElement Pickupaddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div[2]")]
        public IWebElement Pickupaddress2 { get; set; }
    
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressIteam2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Maaf, tidak ada alamat yang tersimpan yang cocok dengan pencarian Anda. Silakan coba lagi.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement CrossDelete { get; set; }

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement FNameLname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancelBtn { get; set; }
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

        public void ValidateAttributeContains(string Streetvalue, string Cityvalue, string Statevalue)
        {
            string value = Street.InputBoxValue();
            string value2 = CityID.InputBoxValue();
            string value3 = StateID.InputBoxValue();
            if (value.Contains(Streetvalue) &&  value2.Contains(Cityvalue) && value3.Contains(Statevalue))
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

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }
      

       // public void StateSelection(string StateName)
       // {
       //     State.SelectDropDownIndex(1);
       // }

       // public void CitySelection(string CityName)
       // {
       //     City.SelectDropDownIndex(1);
        //}

        public void SelectCityOption(string option)
        {
            CityID.SelectDropDownOption(option);

        }

        public void SelectStateOption(string option)
        {
            StateID.SelectDropDownOption(option);

        }

        public void SelectCountyoption(string option)
        {
            CountyID.SelectDropDownOption(option);

        }

        public void SelectZipOption(string option)
        {
            PostalCode.SelectDropDownOption(option);

        }
        public void SelectSubCountyOption(string option)
        {
            SubCountyID.SelectDropDownOption(option);

        }


        public string staicPhoneNR()
        {
            IWebElement inputbox = Driver.FindElement(By.XPath("//input[@id='PhoneNumber']/ancestor::li/span[text()='Format: 7-14 digit']"));
            string actvalue = inputbox.Text;
            return actvalue;

        }
        /// <summary>
        /// Below Method is use for Searching and Edit Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        /// <param name="IsCustomer"></param>
        public void SearchAndEdit(Framework.Address add, bool IsCustomer = false)
        {
            //Select address from list and Edit address
            var count1 =  InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.LastName) && ele.Contains(add.Street))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");
                    if(IsCustomer == true)
                    {
                        string ele1 = CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text;
                        if (ele1 != null)
                            Assert.IsTrue(true,"Personal tag found");
                        else
                            Assert.IsFalse(true, "Personal tag not found");
                    }
                    else
                    {
                        string ele1 = CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                        if (ele1 != null)
                            Assert.IsTrue(true, "Customer tag found");
                        else
                            Assert.IsFalse(true, "Customer tag not found");
                    }
                     WaitForAddressList();
                     PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "ACEH BARAT", "ACEH", "", "99849484", "ARONGAN LAMBALEK", "ALUE BAGOK", "", "");

                    if (CommonMethods.IsElementDisplayed( EditCustomerLink))
                    {
                        PageExtension.WaitForTimeSpan(1000);
                         PageExtension.WaitForElementPresentAndVisible(this,EditCustomerLink);
                         EditCustomerLink.Click();
                         PageExtension.WaitForElementPresentAndVisible(this,ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        Street.Clear();
                        Street.SendKeys(add.Street);
                        Street2.Clear();
                        Street2.SendKeys(add.Street2);
                        PageExtension.WaitForTimeSpan(2000);
                        SelectCityOption(add.City);
                        PageExtension.WaitForTimeSpan(2000);
                        SelectStateOption(add.State);
                        //StateSelection(add.State);
                        PageExtension.WaitForTimeSpan(2000);
                        SelectCountyoption(add.StreetNumber);
                        PageExtension.WaitForTimeSpan(2000);
                        SelectSubCountyOption(add.CEP);
                        //CitySelection(add.City);
                        //PostalCode.Clear();
                        //PostalCode.SendKeys(add.Zip);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        if (IsCustomer == true)
                        {
                            CustomerRadioBtn.Click();
                        }
                        else
                        {
                            PageExtension.WaitForTimeSpan(2000);
                            PersonalRdoBtn.Click();
                        }
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
                 PageExtension.WaitForElementPresentAndVisible(this,SearchFieldPersonal);
                 SearchFieldPersonal.Clear();
                 SearchFieldPersonal.SendKeys(add.FirstName);
                 WaitSpinToFalse();
                PageExtension.WaitForTimeSpan(2000);
                var count =  InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
                if (count != null && count.Count > 0)
                {
                    foreach (var item in count)
                    {
                        string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;
                        if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.LastName))
                            Assert.IsTrue(true, "The address is successfully Edited");
                        else
                            Assert.IsTrue(false, "Address is not Matching");

                        if (IsCustomer == false)
                        {
                            string ele1 = CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text;
                            if (ele1 != null)
                                Assert.IsTrue(true, "Personal tag found");
                            else
                                Assert.IsFalse(true, "Personal tag not found");
                        }
                        else
                        {
                            string ele1 = CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Customer']").Text;
                            if (ele1 != null)
                                Assert.IsTrue(true, "Customer tag found");
                            else
                                Assert.IsFalse(true, "Customer tag not found");
                        }
                        break;
                    }
                }
                 PersonalAddrList.Click();
                if (CommonMethods.IsElementDisplayed( ShiptothisBut))
                {
                    string fullName = displayName.Text;
                    PageExtension.WaitForElementPresentAndVisible(this,ShiptothisBut);
                    PageExtension.WaitForTimeSpan(1000);
                     ShiptothisBut.Click();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                     Driver.WaitForDocumentReady();
                    PageExtension.WaitForTimeSpan(5000);
                     PageExtension.WaitForElementPresentAndVisible(this,ShoppersAddr);
                     Driver.WaitForDocumentReady();
                    ShopperProfileContains(fullName, add);
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
             PageExtension.WaitForElementPresentAndVisible(this,SearchFieldPersonal);
             SearchFieldPersonal.SendKeys(add.FirstName);
             WaitSpinToFalse();
             WaitForAddressList();
        }



        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false)
        {
            this.WaitForElementClicklable(AddAddressBtn,40);
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this,CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this,PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed( ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( AddAddressBtn));
            //Add address
            PageExtension.ScrollElementIntoMiddle(this, AddAddressBtn, 2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForElementPresentAndVisible(this,PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            SelectStateOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectCityOption(add.City);
            PageExtension.WaitForTimeSpan(3000);
            SelectCountyoption(add.StreetNumber);
            PageExtension.WaitForTimeSpan(3000);
            SelectSubCountyOption(add.CEP);
            PageExtension.WaitForTimeSpan(2000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            //ValidateAttributeContains(add.Street, add.State, add.City);
            if (IsCustomer)
                CustomerRadioBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }
        /// <summary>
        /// Below Method is used for adding Duplicate data to System 
        /// </summary>
        /// <param name="add"></param>
        public void AddedDuplicateAddress(Framework.Address add)
        {
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this,PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            SelectStateOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectCityOption(add.City);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectCountyoption(add.StreetNumber);           
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectSubCountyOption(add.CEP);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PostalCode.SendKeys(add.Zip);
            CustomerRadioBtn.Click();
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
            PageExtension.WaitForElementPresentAndVisible(this,Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementPresentAndVisible(this,Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed( Cancel));
             Duplicatelist.Click();
             PageExtension.WaitForElementPresentAndVisible(this,Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled( Overwrite));
             Overwrite.Click();
             PageExtension.WaitForElementPresentAndVisible(this,ShippingAddrSave, 5);
            //Search Address
             PageExtension.WaitForElementPresentAndVisible(this,SearchFieldPersonal);
             SearchFieldPersonal.Clear();
             SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 2));
             WaitSpinToFalse();
             WaitForAddressList();
        }


        public void VerifyFieldsOnAddressPage()
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            PageExtension.WaitForTimeSpan(2000);
            AddAddressBtn.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(LastName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Street));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Street2));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(StateID));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(CityID));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(CountyID));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(SubCountyID));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PostalCode));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PhoneNumber));
        }
        /// <summary>
        /// 
        /// </summary>
        public void VerifyAsteriskSymbol()
        {
            AddAddressBtn.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(StreetAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(StateAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(CityAsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Countysterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(SubCountysterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Zipsterisk));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Phoneterisk));
            var count = InitializeReadOnlyCollection("//*[@id='new-address-form']//span[@class='color-red']");
            if (count.Count == 8)
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false, "some fields are not mandatry");

        }

        public void VerifyFieldsErrorMessages()
        {
            //SAVE with all blank fields
            PageExtension.WaitForTimeSpan(2000);
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            ShippingAddrSave.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgFirstName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgStreet));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgState));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgCity));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgCountry));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgSubCountry));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));
            PageExtension.WaitForTimeSpan(2000);
            //Enter first name and last name click on Save button
            AddAddressBtn.Click();
            FirstName.SendKeys("First Name");
            LastName.SendKeys("Last Name");
            PageExtension.WaitForTimeSpan(2000);
            ShippingAddrSave.Click();
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgFirstName));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgStreet));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgState));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgCity));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgCountry));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgSubCountry));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));
            //Enter all fileds and leave black for first name
            AddAddressBtn.Click();
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "ACEH BARAT", "ACEH", "", "99849484", "ARONGAN LAMBALEK", "ALUE BAGOK", "", "");
            LastName.SendKeys("LastName");
            Street.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            SelectStateOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectCityOption(add.City);
            PageExtension.WaitForTimeSpan(3000);
            SelectCountyoption(add.StreetNumber);
            SelectSubCountyOption(add.CEP);
            PhoneNumber.SendKeys(add.PhoneNumber);
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ErrorMsgFirstName));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgStreet));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgState));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgCity));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgCountry));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgSubCountry));
            Assert.IsFalse(CommonMethods.IsElementDisplayed(ErrorMsgPhoneNumber));


        }

        public void VerifyPhoneNumberFieldLength()
        {
            PageExtension.ScrollElementIntoMiddle(this,AddAddressBtn,2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PhoneNumber.SendKeys("123");
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PhoneFormat));
            PageExtension.ScrollElementIntoMiddle(this, AddAddressBtn, 2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PhoneNumber.SendKeys("1234567");
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsFalse(CommonMethods.IsElementDisplayed(PhoneFormat));
            PageExtension.ScrollElementIntoMiddle(this, AddAddressBtn, 2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PhoneNumber.SendKeys("12345678");
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsFalse(CommonMethods.IsElementDisplayed(PhoneFormat));
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddressforSAMCAM("DEV", "DEEP", "street", "street2", "ACEH BARAT", "ACEH", "", "99849484", "ARONGAN LAMBALEK", "ALUE BAGOK", "", "");
            PageExtension.ScrollElementIntoMiddle(this, AddAddressBtn, 2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(3000);
            SelectStateOption(add.State);
            PageExtension.WaitForTimeSpan(3000);
            WaitSpinToFalse();
            SelectCityOption(add.City);
            PageExtension.WaitForTimeSpan(3000);
            SelectCountyoption(add.StreetNumber);
            SelectSubCountyOption(add.CEP);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PhoneNumber.SendKeys(Keys.Tab);
            Assert.IsFalse(CommonMethods.IsElementDisplayed(PhoneFormat));
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
           
        }

        public void VerifyAllowedCharacters()
        {
            String Value = "";
            String AlphNumValue = "!@@%$&%DDDfff123";
            PageExtension.ScrollElementIntoMiddle(this,AddAddressBtn,2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            FirstName.SendKeys(AlphNumValue);
            Value = FirstName.InputBoxValue();
            Assert.AreEqual(Value, AlphNumValue);
            LastName.SendKeys(AlphNumValue);
            Value = LastName.InputBoxValue();
            Assert.AreEqual(Value, AlphNumValue);
            Street.SendKeys(AlphNumValue);
            Value = Street.InputBoxValue();
            Assert.AreEqual(Value, AlphNumValue);
            Street2.SendKeys(AlphNumValue);
            Value = Street2.InputBoxValue();
            Assert.AreEqual(Value, AlphNumValue);
            PhoneNumber.SendKeys(AlphNumValue);
            Value = PhoneNumber.InputBoxValue();
            Assert.AreNotEqual(Value, AlphNumValue);


        }
        public void VerifyFieldLength()
        {
            PageExtension.ScrollElementIntoMiddle(this,AddAddressBtn,2);
            AddAddressBtn.Click();
            PageExtension.ScrollToTop(this);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalRdoBtn);
            TextFieldCount(FirstName, 20, "weuwqtetqweiywqeyoqw1");
            TextFieldCount(LastName, 20, "weuwqtetqweiywqeyoqw1");
            TextFieldCount(Street, 40, "r7493hfh4392ruowejrooerjewjrlwejrwlr;wle1");
            TextFieldCount(Street2, 40, "r7493hfh4392ruowejrooerjewjrlwejrwlr;wle45435345435435trrtre;wle1");
            TextFieldCount(PhoneNumber, 14, "23456789234534");
        }
        public void TextFieldCount(IWebElement webEle, int Count, string Actvalue)
        {
            webEle.SendKeys(Actvalue);
            int ActualCount = webEle.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }
        public void ShopperProfileContains(string display_Name, Framework.Address add)
        {
            string ShopperProfileText = shopperProfile.Text;
            Assert.IsTrue(ShopperProfileText.Contains(display_Name));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }


       
   

        public void SearchValidAddress(bool isValidaddress = false)
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
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(FNameLname));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        isValidaddress = true;
                        break;
                    }
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        break;
                    }
                    else
                    {
                        isInValidaddressFound = false;
                    }

                }
                if (isInValidaddressFound == false)
                {
                    Assert.IsTrue(true, "No customer address found with Invalid address ");
                }
            }
            else
                Assert.IsFalse(true, "No customer address found");
        }


    }
    public class DeliveryAddressPersonalPageTestID : DeliveryAddressPersonalPage_ID { }
}
