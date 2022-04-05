using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_FR_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']//*[@class='plus btn-increment']")]
        public IWebElement PlusBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='price-list-section']//*[@class='btn-add-cart'][1]")]
        public IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/div")]
        public IWebElement AddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//*[@class='btn-close btn-change']")]
        public IWebElement UseselectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-go-checkout']")]
        public IWebElement ProceedCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h4")]
        public IWebElement ShoppersAddrPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h5")]
        public IWebElement ShoppersAddrText { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@style='float:left']/label[@for='address-type']")]
        public IWebElement AddressType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerAddressType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PersonalAddressType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-saved-address-']/h4[@data-bind='invisible:IsEditMode']")]
        public IWebElement AddNewAddressText { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Prénom:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nom de familie:')]/span")]
        public IWebElement LastNameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Rue 1:')]/span")]
        public IWebElement StreetAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street1TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']/ul[3]/li[2]/label")]
        public IWebElement Line2Text { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Line2TextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Ville:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Code postal:')]/span")]
        public IWebElement ZIPAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement ZIPTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Numéro de téléphone:')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CityTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-saved-address-']//h4[@data-bind='invisible:IsEditMode']")]
        public IWebElement AddNewAddressForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Le code postal est invalide.')]")]
        public IWebElement ZipcodeErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Code postal incorrect')]")]
        public IWebElement ZipcodeErrorMsgInvalidNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@wire-model='OrderIntention'][@id='edit-address']")]
        public IWebElement ModifierLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(), 'Aucune adresse enregistrée')]")]
        public IWebElement SearchWrngMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Choisir une adresse de livraison')]")]
        public IWebElement ChooseAnAddressTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Choisissez ou ajoutez une')]")]
        public IWebElement ChooseAnAddressTitle1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-shipping-address']//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-section']")]
        public IWebElement ManageSavedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Additional']")]
        public IWebElement Additional { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Province']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='AreaCode']")]
        public IWebElement AreaCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]")]
        public IWebElement AddressItems { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='btn-add-cart'])[1]")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement ShippingAddrEdit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCustomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement EditAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='badge-counter']")]
        public IWebElement CartIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address']")]
        public IWebElement ShopProfileAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneType']")]
        public IWebElement PhoneType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditShippingAddresLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement SaveEditedShippingAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-item']")]
        public IWebElement AddressItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']/section/h3")]
        public IWebElement Choosepersonaladdress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']/section/p")]
        public IWebElement ChoosepersonaladdressText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='fedex-toggle']")]
        public IWebElement FedexToggleButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']")]
        public IWebElement Productlines { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PickupSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']/a/span")]
        public IWebElement shopperProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i")]
        public IWebElement PickupSearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-search-value'])[2]")]
        public IWebElement AddressSearchValue { get; set; }

        [FindsBy(How = How.XPath, Using = "((//*[@class='shipping-list'])[2]//div[@class='address-item'])[1]")]
        public IWebElement AddressSearchValueElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form new-customer']//a[@class='btn-continue']")]
        public IWebElement ConfrimBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Zip2']")]
        public IWebElement Zip2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),' Merci de renseigner le prénom')]")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),' Merci de renseigner le Nom de familie')]")]
        public IWebElement ErrorMsgLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),' Merci de renseigner la rue')]")]
        public IWebElement ErrorMsgStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']/ancestor::li/span[contains(.,'Por favor, proporcione el Departamento.')]")]
        public IWebElement ErrorMsgState { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Merci de renseigner la ville')]")]
        public IWebElement ErrorMsgCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),' Merci de sélectionner le numéro de téléphone')]")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Numéro de téléphone incorrect')]")]
        public IWebElement ErrorMsgPhoneNumberInvalid { get; set; }
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

        public void CitySelection(string CityName)
        {
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }
        public Framework.Address AddAddress(Shop.Automation.Framework.Address add, bool IsCustomer = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
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
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            return add;
        }
        public void ValidateshopperprofilePickUp(string expected, string expectedText)
        {
            Assert.IsTrue(ShoppersAddrPickUp.Text.Contains(expected));
            Assert.IsTrue(ShoppersAddrText.Text.Contains(expectedText));
        }

        public void SelectPhoneOption(string option)
        {
            PhoneType.SelectDropDownOption(option);
        }

        public void SearchAddress(string FirstName)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
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

        public void ShopperProfileContains(string display_Name, Framework.Address add)
        {
            string ShopperProfileText = shopperProfile.Text;
            Assert.IsTrue(ShopperProfileText.Contains(display_Name));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street2));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }

        //Shopper Profile Validation for Pickup
        public void ValidateshopperprofilePickUp(string expected)
        {
            string Actual = ShoppersAddr.Text;
            Assert.IsTrue(Actual.Contains(expected));
        }


    }
    public class DeliveryAddressPersonalPageTestFRMB : DeliveryAddressPersonalPage_FR_MB { }
}
