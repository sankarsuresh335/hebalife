using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_AR_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public string CartPath => $"{RunSettings.FarmUrl}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}" + "??orderCategory=RSO" + "";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        public string AddressPathPricelist => $"{RunSettings.FarmUrl}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement CancelDuplicate { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nombre:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Dirección 1:')]/span")]
        public IWebElement StreetAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Localidad:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Provincia:')]/span")]
        public IWebElement StateAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Código postal:')]/span")]
        public IWebElement PostalCodeAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Número telefónico:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "(//label[contains(text(),'Barrio:')]/span)[1]")]
        public IWebElement CountyAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Por favor llena el Nombre')]")]
        public IWebElement FirstnameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),' Por favor, completa la Dirección.')]")]
        public IWebElement StreetErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='State' and contains(text(),' Por favor selecciona tu estado.')]")]
        public IWebElement StateErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City' and contains(text(),' Por favor selecciona tu ciudad.')]")]
        public IWebElement CityErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' Por favor selecciona tu código postal.')]")]
        public IWebElement PostalCodeErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Se requiere el número de teléfono')]")]
        public IWebElement PhoneNumberErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='button-set']/a[@class='close-reveal-modal btn-delete'])[4]")]
        public IWebElement DeleteConfirmCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickupDistanceDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Lo sentimos, ninguna de las direcciones guardadas coincide con tu búsqueda.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewonMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Administrar direcciones')]")]
        public IWebElement ManageAddressBtn { get; set; }

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
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='County']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement ShippingAddrEditSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address-edit']")]
        public IWebElement ShippingEditCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div")]
        public IWebElement PickUpLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Direcciones guardadas')]")]
        public IWebElement ManageAddressPageTitle { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Número de teléfono inválido.')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement ShippingChangedAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@id='City']")]
        public IWebElement CityAR { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement StateAR { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement PickupAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']/div[1]")]
        public IWebElement SearchAddres { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement DistantMilesddl { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Sucursales')]")]
        public IWebElement PickupPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Escriba la dirección de tu domicilio para visualizar los puntos más cercanos de recojo a continuación.')]")]
        public IWebElement PickupPageTitleDesc { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='icon-cart-fl-6']")]
        public IWebElement CartIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Enviar a:')]")]
        public IWebElement ShipTo { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='shipping-list']//h4[contains(text(),'Lo sentimos, ninguna de las direcciones guardadas coincide con tu búsqueda. Por favor, inténtalo de nuevo.')]")]
        public IWebElement NoAddressfoundMSG { get; set; }


        public object StateMx { get; private set; }
        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
        }
        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
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
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditInformation));
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
                            PageExtension.WaitForTimeSpan(1000);
                            LastName.Clear();
                            LastName.SendKeys(add.LastName);
                            PageExtension.WaitForTimeSpan(1000);
                            StreetTextBox.Clear();
                            StreetTextBox.SendKeys(add.Street);
                            PageExtension.WaitForTimeSpan(1000);
                            SelectStateOption(add.State);
                            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
                            SelectCityOption(add.City);
                            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
                            //SelectZipOption(add.Zip);
                            PageExtension.WaitForTimeSpan(1000);
                            PhoneNumber.Clear();
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            PageExtension.WaitForTimeSpan(1000);
                            WaitSpainToFalse();
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

        public void ValidateshopperprofilePickUP(string Postalcodevalue, string Streetvalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(Postalcodevalue))
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

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));

        }


        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        public Framework.Address AddAddress(Framework.Address add, bool iscancelled = false)
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
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetTextBox.SendKeys(add.Street);
            PageExtension.WaitForTimeSpan(1000);
            SelectStateOption(add.State);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
            SelectCityOption(add.City);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
            SelectZipOption(add.Zip);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
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
        public Framework.Address EditAddress(Framework.Address add, bool iscancelled = false)
        {
            WaitForAddressList();
            AddressListValue1.Click(); 
            PageExtension.WaitForTimeSpan(2000);
            add.ClearAddress();
            add.FillAddressForEMEA("DJ", "AkashEdit", "Street1", "", "BOTIJA", "3714", "22334466", "", "Chaco");

            if (CommonMethods.IsElementDisplayed(EditInformation))
            {
                PageExtension.WaitForElementPresentAndVisible(this, EditInformation);
                EditInformation.Click();
                PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                WaitSpinToFalse();
                FirstName.Clear();
                FirstName.SendKeys(add.FirstName);
                PageExtension.WaitForTimeSpan(1000);
                LastName.Clear();
                LastName.SendKeys(add.LastName);
                PageExtension.WaitForTimeSpan(1000);
                StreetTextBox.Clear();
                StreetTextBox.SendKeys(add.Street);
                PageExtension.WaitForTimeSpan(1000);
                SelectStateOption(add.State);
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
                SelectCityOption(add.City);
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 40);
                //SelectZipOption(add.Zip);
                PageExtension.WaitForTimeSpan(1000);
                PhoneNumber.Clear();
                PhoneNumber.SendKeys(add.PhoneNumber+Keys.Tab);
                WaitSpinToFalse();
                PageExtension.WaitForTimeSpan(1000);
                if (!iscancelled)
                {
                    ShippingAddrEditSave.Click();
                    PageExtension.WaitForTimeSpan(3000);
                    WaitSpinToFalse();
                    Driver.WaitForDocumentReady();
                    WaitForAddressList();
                    Assert.IsTrue(true, "Address successfully Edited");
                }
                else {
                    ShippingEditCancel.Click();
                    PageExtension.WaitForTimeSpan(3000);
                    WaitSpinToFalse();
                }
            }
            else
                Assert.IsFalse(true, "No address found");
            

            return add;
        }

        public void SelectStateOption(string option)
        {
            State.SelectDropDownOption(option);
        }
        public void SelectCityOption(string option)
        {
            City.SelectDropDownOption(option);
        }
        public void SelectZipOption(string option)
        {
            PostalCode.SelectDropDownOption(option);
        }
        public void ValidateAttributeContains(Framework.Address add)
        {
            string value = State.InputBoxValue();
            string value1 = City.InputBoxValue();
            string value2 = County.InputBoxValue();
            string value3 = PostalCode.InputBoxValue();
            if (value.Contains(add.State) && value1.Contains(add.City) && value3.Contains(add.Zip))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        public void SelectMilesOption(string option)
        {
            PickUPDdnSearch.SelectDropDownOption(option);
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
        public void ValidateAttributeContains(string expectedvalue, string expectedvalue1)
        {
            string value = CityAR.GetAttribute("innerHTML");
            string value1 = StateAR.GetAttribute("innerHTML");

            if (value.Contains(expectedvalue) && value1.Contains(expectedvalue1))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void ValidateDistanceDroupDown()
        {
            List<string> expectedDropDownValues = new List<string>();
            expectedDropDownValues.Add("5 km de distancia");
            expectedDropDownValues.Add("10 km de distancia");
            expectedDropDownValues.Add("15 km de distancia");
            expectedDropDownValues.Add("20 km de distancia");
            SelectElement original = new SelectElement(DistantMilesddl);
            List<IWebElement> originalListElements = original.Options.ToList();
            for (int i = 0; i < originalListElements.Count; i++)
            {

                if (originalListElements[i].Text.Equals(expectedDropDownValues[i]))
                {

                    Assert.IsTrue(true, "The Value displayed Correctly");
                }
                else
                {
                    Assert.IsTrue(false, "The Value not set Correctly");
                }
            }
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


    }
    public class DeliveryAddressPersonalPageTestAR_MB : DeliveryAddressPersonalPage_AR_MB { }
}

