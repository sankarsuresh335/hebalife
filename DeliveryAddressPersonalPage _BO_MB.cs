using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_BO_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressItems { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='btn-add-cart'])[1]")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='totals']//*[@class='address-info']")]
        public IWebElement ShipToInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement AddSku { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldClsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickupDistanceDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewonMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='pickupSearch']")]
        public IWebElement SearchFieldPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='address-pickup-filter']//i[@class='icon-magnifier-fl-1']")]
        public IWebElement PickupSearchMagnifier { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='locationList']//img[@src='/Shop/Address/images/CLexpress.png']")]
        public IWebElement PickupChileLogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='/Shop/Address/images/cis-latam.png']")]
        public IWebElement PickupCISLATAMLOGO { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='/Shop/Address/images/pickup-herbalife.png']")]
        public IWebElement PickupHerbalifeLOGO { get; set; }

        [FindsBy(How = How.XPath, Using = "//img[@src='/Shop/Address/images/Herbalife_BO.png']")]
        public IWebElement PickupIQUIQUELOGO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='EmailAddress']")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement SelectAddrs { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='html: DisplayedInfo']")]
        public IWebElement ShopperAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

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
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement Province { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'County_listbox')])[1]")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@aria-owns,'Zip_listbox')])[1]")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='note']")]
        public IWebElement PhoneNumberFormat { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='customer-ship']//a[@id='btn-default-address-changed']")]
        public IWebElement ShippingShiptothisButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='visible:ShowOnlyHerbalife']//a[contains(text(),'Usar dirección seleccionada')]")]
        public IWebElement PickupShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[1]")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-info']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='notification-success'])[1]")]
        public IWebElement AddressUpdatedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickup-search-value']")]
        public IWebElement PickupSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Neighborhood']")]
        public IWebElement NeighborhoodFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='note error']")]
        public IWebElement FnameLameExceedingErrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Zip']")]
        public IWebElement PostalCodeFieldError { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.PhoneNumber']")]
        public IWebElement readOnlyPhoneNumberValue { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement MileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement GoogleSearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement GoogleSearchButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[1]")]
        public IWebElement btbShowMap { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[2]")]
        public IWebElement btbViewLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div")]
        public IWebElement PickupAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nombre:')]//span[@class='color-red']")]
        public IWebElement FirstNameAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Apellidos:')]//span[@class='color-red']")]
        public IWebElement LastNameAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Dirección de la Calle 1 :')]//span[@class='color-red']")]
        public IWebElement StreetAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Región:')]//span[@class='color-red']")]
        public IWebElement StateAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Provincia:')]//span[@class='color-red']")]
        public IWebElement CityAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Commune:')]//span[@class='color-red']")]
        public IWebElement CountyAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Código Postal:')]//span[@class='color-red']")]
        public IWebElement PostalAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Número Telefónico:')]//span[@class='color-red']")]
        public IWebElement PhoneNumberAstrick { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='pickupSearch']")]
        public IWebElement PickupSearchWaterMark { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(), 'CHILEXPRESS SIMON BOLIVAR')]")]
        public IWebElement PickupAddressSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']//div[@class='address-info']")]
        public IWebElement ShippingSelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Lo sentimos, no se encontraron sucursales. Por favor expande tus criterios de búsqueda.')]")]
        public IWebElement PickupLocationSearchWrngMsg { get; set; }      

        [FindsBy(How = How.XPath, Using = "//div[@id='duplicated-contacts']//div[@class='address-item']")]
        public IWebElement SelectDuplicateAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-continue']")]
        public IWebElement DuplicateContinueAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement DuplicateCancelAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-duplicated-contact']")]
        public IWebElement DuplicatePopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//strong[contains(text(),'CHILEXPRESS SIMON BOLIVAR')]")]
        public IWebElement PickupAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']/div)[1]//div[@class='last']")]
        public IWebElement PickUpLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-clean-pickup-search'])[2]")]
        public IWebElement CleanSearchPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement CleanSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']/h4")]
        public IWebElement AddressInvalidMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='note error']")]
        public IWebElement NameCombinationMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement AddAddress_ManageAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind= 'invisible: firstPULoad']")]
        public IWebElement PickUpErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class= 'address-content']/p/font")]
        public IWebElement AddressMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete']")]
        public IWebElement Delete_ManageAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-info']")]
        public IWebElement DeliveryAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement CartPage_ChangeLink { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='search']")]
        public IWebElement PL_SearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='icon-add-fl-2']")]
        public IWebElement PL_IncrementIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-add-cart']")]
        public IWebElement PL_BuyNowButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }


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
            string value2 = City.InputBoxValue();
            string value3 = State.InputBoxValue();
            if (value.Contains(Streetvalue) && value2.Contains(Cityvalue) && value3.Contains(Statevalue))
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
        public void ValidateshopperprofilePickUP(string Streetvalue, string Street2value)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(Street2value))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void SelectAddress()
        {
            var val = MandatryFieldCount("//*[@id='locationList']");
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
        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public string SelectExistingSavedAddress()
        {
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            IList<IWebElement> contactList = Driver.FindElements(By.XPath("//*[@id='addressList']/div"));
            string FullNameSelectedSavedPersonalAddress = string.Empty;
            for (int i = 0; i <= contactList.Count; i++)
            {
                contactList[i].Click();
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                PageExtension.WaitForTimeSpan(1000);
                if (!CommonMethods.IsElementDisplayed(ShippingAddrSave) && !CommonMethods.IsElementDisplayed(CancelAddAddress))
                {
                    Assert.IsFalse(CommonMethods.IsElementDisplayed(PersonalTag));
                    FullNameSelectedSavedPersonalAddress = displayName.Text.Trim();
                    break;
                }
            }
            return FullNameSelectedSavedPersonalAddress;
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

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.City))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                       Assert.IsTrue(false, "Address is not Matching");
                    WaitForAddressList(); 
                    PageExtension.WaitForTimeSpan(2000);
                    PersonalAddrList.Click();
                    add.ClearAddress();
                    add.FillAddressforSAMCAM("FNNN", "LAMMMSTN", "Comaria", "Main", "DOLORES", "CABANAS", "", "99287533", "");
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        Street.Clear();
                        Street.SendKeys(add.Street);
                        Street2.Clear();
                        Street2.SendKeys(add.Street2);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        PageExtension.WaitForTimeSpan(2000);
                        SelectStateOption(add.State);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        PageExtension.WaitForTimeSpan(2000);
                        SelectCityOption(add.City);
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        WaitSpainToFalse();
                       
                        ShippingAddrSave.Click();
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
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
                        if (ele.Contains(add.FirstName.Remove(add.FirstName.Length - 2)) && ele.Contains(add.Street) && ele.Contains(add.City))
                            Assert.IsTrue(true, "The address is successfully Edited");
                        else
                            Assert.IsTrue(false, "Address is not Matching");

                       
                    }
                }
                PersonalAddrList.Click();
                if (CommonMethods.IsElementDisplayed(ShiptothisBtn))
                {
                    PageExtension.WaitForElementPresentAndVisible(this, ShiptothisBtn);
                    PageExtension.WaitForTimeSpan(1000);
                    ShiptothisBtn.Click();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    Driver.WaitForDocumentReady();
                    PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
                    PageExtension.WaitForElementPresentAndVisible(this, ShoppersAddr);
                    Validateshopperprofile(add.LastName, add.City, add.State);
                    Driver.WaitForDocumentReady();
                }
                else
                    Assert.IsFalse(false, "No address found");
            }
            else
                Assert.IsFalse(false, "No address found");
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

        /// <summary>
        /// Below Method is use for Searching Customer/Personal data
        /// </summary>
        /// <param name="add"></param>
        public void SearchAddress(String FirstName)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }


        /// <summary>
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        /// </summary>
        /// <param name="IsCustomer"></param>
        /// <returns></returns>
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            WaitSpainToFalse();
            PageExtension.WaitForTimeSpan(2000);
            //Add address
            AddAddressBtn.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectStateOption(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);          
            SelectCityOption(add.City);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            return add;
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
            Street.SendKeys(add.Street);
            Street2.SendKeys(add.Street2);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectStateOption(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectCityOption(add.City);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            SelectColonyOption(add.StreetNumber);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PhoneNumber.SendKeys(add.PhoneNumber);
            CustomerRadioBtn.Click();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
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
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 20);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Duplicatelist.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled(Overwrite));
            Overwrite.Click();
            PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave, 5);
            //Search Address
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }                      
       
        public IList<IWebElement> verifyMileDropDown()
        {
            SelectElement oSelect = new SelectElement(MileDropdown);
            IList<IWebElement> elementCount = oSelect.Options;
            return elementCount;
        }

        public void SelectStateOption(string option)
        {
            State.Click();
            var Statelist = InitializeReadOnlyCollection("//*[@id='State']/option").ToList();
            PageExtension.WaitForTimeSpan(3000);
            Statelist.FirstOrDefault(i => i.Text.Contains(option)).Click();
        }

        public void SelectCityOption(string option)
        {
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='Neighborhood']/option").ToList();
            PageExtension.WaitForTimeSpan(3000);
            Citylist.FirstOrDefault(i => i.Text.Contains(option)).Click();
        }

        public void SelectColonyOption(string option)
        {
            County.Click();
            var Countylist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            PageExtension.WaitForTimeSpan(3000);
            Countylist.FirstOrDefault(i => i.Text.Contains(option)).Click();
        }

        public void SelectZipOption(string option)
        {
            PostalCode.Click();
            var Ziplist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            PageExtension.WaitForTimeSpan(3000);
            Ziplist.FirstOrDefault(i => i.Text.Contains(option)).Click();
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
    public class DeliveryAddressPersonalPageTestBOMB : DeliveryAddressPersonalPage_BO_MB { }
}
