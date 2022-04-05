using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPageTest_BO : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        
        public string CatalogPath => $"{RunSettings.FarmUrl}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";

        public string CartPath => $"{RunSettings.FarmUrl}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}" + "??orderCategory=RSO" + "";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressIteam { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-go-checkout']")]
        public IWebElement GOToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-list']//h4")]
        public IWebElement NoAddrWarningMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: HasAddresses' and contains(@href,'/es-BO/Shop')]")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[2]")]
        public IWebElement AllPickupDeliveryUseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div[2]")]
        public IWebElement Pickupaddress2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Direcciones guardadas')]")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement GoogleSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement GoogleSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='tag primary']")]
        public IWebElement PrimarTagPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='button-set']/a[@class='close-reveal-modal btn-delete'])[4]")]
        public IWebElement DeleteConfirmCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div[1]")]
        public IWebElement Pickupaddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressIteam2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Lo sentimos, ninguna de las direcciones guardadas coincide con tu búsqueda.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='saved-container']/div/child::text/span")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighborhood']")]
        public IWebElement Neighborhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighborhood']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Primer nombre es obligatorio')]")]
        public IWebElement FirstNameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),' Por favor, ingresa la calle')]")]
        public IWebElement StreetErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Neighborhood' and contains(text(),' Por favor, ingresa la Ciudad.')]")]
        public IWebElement CountyErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='State' and contains(text(),' Por favor, ingresa el nombre del estado')]")]
        public IWebElement StateErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Por favor, ingresa el número de Teléfono')]")]
        public IWebElement PhoneNumberErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Número de teléfono inválido')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nombre:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Calle 1:')]/span")]
        public IWebElement StreetAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Departamento:')]/span")]
        public IWebElement StateAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ciudad:')]/span")]
        public IWebElement CountyAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Provincia:')]/span")]
        public IWebElement ProvinceAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),' Número de Teléfono:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div")]
        public IWebElement PickUpLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        public IWebElement DropUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditCustomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement CancelDuplicate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-default-address-changed'])[2]")]
        public IWebElement ShippToAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement DisplayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@data-bind,'clearCart')]")]
        public IWebElement lnkClearSelectedItems_PVC { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@class='customer-form hl-form']//div[@class='read-only break-wrap']")]
        public IWebElement AddressItem_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressSavedCorrectly')]")]
        public IWebElement AddressSavedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='COCentroslocationList']/div)[1]//div[@class='last']")]
        public IWebElement HLPickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='COCentroslocationList']/div")]
        public IWebElement HLPickupAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickup-search-value']")]
        public IWebElement HLSearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='centros-toggle']")]
        public IWebElement HlSalesCenterQRC { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class,'address-item')]//*[text()[contains(.,'HERBALIFE SANTA CRUZ EL CRISTO')]]")]
        public IWebElement PickupOption { get; set; }

        public IReadOnlyList<IWebElement> Increase_QtyList => Driver.FindElements(By.XPath("//a[contains(@data-bind,'increaseQty')]/i"));

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

        /// Below Method is used for validating Duplicate popup 
        public void VerifyDuplicatePopUp(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            CancelDuplicate.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
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
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal, 5);
            //Search Address
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.FirstName.Remove(add.FirstName.Length - 1));
            WaitSpinToFalse();
            WaitForAddressList();
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
                    else if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                    {
                        Assert.IsTrue(true, "The selected customer address is Invalid");
                        isValidaddress = false;
                        if (CommonMethods.IsElementDisplayed(ShippingAddrSave))
                        {
                            PageExtension.WaitForTimeSpan(1000);
                            FirstName.Clear();
                            FirstName.SendKeys(add.FirstName);
                            PageExtension.WaitForTimeSpan(2000);
                            LastName.Clear();
                            LastName.SendKeys(add.LastName);
                            PageExtension.WaitForTimeSpan(1000);
                            Street.Clear();
                            Street.SendKeys(add.Street);
                            PageExtension.WaitForTimeSpan(1000);
                            Street2.Clear();
                            Street2.SendKeys(add.Street2);
                            PageExtension.WaitForTimeSpan(2000);
                            StateSelection(add.State);
                            PageExtension.WaitForTimeSpan(2000);
                            CitySelection(add.City);
                            //SelectOption(add.State,add.City);
                            PageExtension.WaitForTimeSpan(2000);
                            PhoneNumber.Clear();
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            PageExtension.WaitForTimeSpan(1000);
                            WaitSpinToFalse();
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            Driver.WaitForDocumentReady();
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
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            //Shop.Automation.Framework.Address add = CreateObject();
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            Street.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(2000);
            StateSelection(add.State);
            PageExtension.WaitForTimeSpan(2000);
            CitySelection(add.City);
            //SelectOption(add.State,add.City);
            PageExtension.WaitForTimeSpan(2000);
            PhoneNumber.SendKeys(add.PhoneNumber);
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

        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public Framework.Address SearchAndEdit(bool IsCustomer = false)
        {
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            //Select address from list and Edit address
            var count1 = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
            if (count1 != null && count1.Count > 0)
            {
                WaitForAddressList();
                PersonalAddrList.Click();
                WaitSpinToFalse();
                PageExtension.WaitForTimeSpan(3000);
                add.ClearAddress();
                add.FillAddressForEMEA("DJ", "AkashEdit", "Street1", "Street2", "COBIJA", "", "987654333", "", "PANDO");

                if (CommonMethods.IsElementDisplayed(EditCustomerLink))
                {
                    PageExtension.WaitForElementPresentAndVisible(this, EditCustomerLink);
                    EditCustomerLink.Click();
                    PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                    WaitSpinToFalse();
                    FirstName.Clear();
                    FirstName.SendKeys(add.FirstName);
                    PageExtension.WaitForTimeSpan(2000);
                    LastName.Clear();
                    LastName.SendKeys(add.LastName);
                    PageExtension.WaitForTimeSpan(1000);
                    Street.Clear();
                    Street.SendKeys(add.Street);
                    PageExtension.WaitForTimeSpan(1000);
                    Street2.Clear();
                    Street2.SendKeys(add.Street2);
                    PageExtension.WaitForTimeSpan(2000);
                    StateSelection(add.State);
                    PageExtension.WaitForTimeSpan(2000);
                    CitySelection(add.City);
                    //SelectOption(add.State,add.City);
                    PageExtension.WaitForTimeSpan(2000);
                    PhoneNumber.Clear();
                    PhoneNumber.SendKeys(add.PhoneNumber);
                    WaitSpinToFalse();
                    if (IsCustomer == true)
                        CustomerRdoBtn.Click();
                    PageExtension.WaitForTimeSpan(1000);
                    ShippingAddrSave.Click();
                    PageExtension.WaitForTimeSpan(3000);
                    WaitSpinToFalse();
                    Driver.WaitForDocumentReady();
                    WaitForAddressList();
                    Assert.IsTrue(true, "Address successfully Edited");
                }
                else
                    Assert.IsFalse(true, "No address found");

                //Edited address validation and Ship to same address
                PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
                SearchFieldCloseBtn.Click();
                WaitSpinToFalse();
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

                        string ele1 = CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']").Text;
                        if (ele1 != null)
                            Assert.IsTrue(true);
                        else
                            Assert.IsFalse(true, "No Nutrition club tag found");
                        break;
                    }
                }
                PersonalAddrList.Click();
            }
            return add;
        }

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }

        public void CitySelection(string CityName)
        {
            County.SelectDropDownOption(CityName);
        }

        public void StateSelection(string StateName)
        {
            State.SelectDropDownOption(StateName);
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

        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
    }

    public class DeliveryAddressPersonalPageBO : DeliveryAddressPersonalPageTest_BO { }
}