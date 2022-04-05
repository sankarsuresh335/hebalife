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
    public class DeliveryAddressPersonalPage_SV : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        public string CatalogPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";
        public string CartPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}" + "??orderCategory=RSO" + "";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']//*[@class='plus btn-increment']")]
        public IWebElement PlusBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@onclick='UpdateProject()']")]
        public IWebElement ProjectPopUp { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='price-list-section']//*[@class='btn-add-cart'][1]")]
        public IWebElement AddtoCartBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "(//*[@id='locationList']/div)[1]//div[@class='last']")]
        public IWebElement PickUpLocation { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='City_listbox']")]
        public IWebElement CityDropDown { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@aria-owns='State_listbox']")]
        public IWebElement StateDropDown { get; set; }
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
        [FindsBy(How = How.XPath, Using = "//*[@class='ship-to-courier']")]
        public IWebElement PUDOTab { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='address-item']/div/span")]
        public IWebElement PersonalTag { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='State_listbox']/li[1]")]
        public IWebElement Statelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='html: DisplayedInfo' and contains(text(), 'Por favor, selecciona la dirección')]")]
        public IWebElement ShoppersAddr_Empty { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@data-bind,'clearCart')]")]
        public IWebElement lnkClearSelectedItems_PVC { get; set; }

        public IReadOnlyList<IWebElement> Increase_QtyList => Driver.FindElements(By.XPath("//a[contains(@data-bind,'increaseQty')]/i"));


        [FindsBy(How = How.XPath, Using = "//*[@id='City_listbox']/li[1]")]
        public IWebElement Muncilist { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='saved-item']//*[@class='address-info']/span[@class='type Personal']")]
        public IWebElement SavedPersonalTag { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='address-item']/div/span[@class='type Customer']")]
        public IWebElement CustomerTag { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='k-textbox k-button k-space-right pickupSearch']//*[@id='pickupSearch']")]
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
        [FindsBy(How = How.XPath, Using = "//*[@id='Customer']")]
        public IWebElement CustomerAddressType { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]

        public IWebElement PersonalAddressType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']/li[1]//*[@class='type Customer']")]

        public IWebElement CusSavedAddressTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2Address { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='new-saved-address-']/h4[@data-bind='invisible:IsEditMode']")]
        public IWebElement AddNewAddressText { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Prénom:')]/span")]
        public IWebElement FirstnameAsterick { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Nom:')]/span")]
        public IWebElement LastNameAsterick { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Rue 1:')]/span")]
        public IWebElement StreetAsterick { get; set; }
        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']//*[@class='address-item']")]
        public IWebElement PickUpAddressItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='price-list-section']/div[2]/div/div[1]/a[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street1TextBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']/ul[3]/li[2]/label")]
        public IWebElement Line2Text { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2TextBox { get; set; }
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

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address-edit']")]
        public IWebElement ShippingAddrEditCancel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='new-saved-address-']//h4[@data-bind='invisible:IsEditMode']")]
        public IWebElement AddNewAddressForm { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip']")]

        public IWebElement ZipcodeErrorMsg { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }
        [FindsBy(How = How.XPath, Using = "(//div[@class='button-set']/a[@class='close-reveal-modal btn-delete'])[4]")]
        public IWebElement DeleteConfirmCustomer { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Code postal incorrect')]")]
        public IWebElement ZipcodeErrorMsgInvalidNumber { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@wire-model='OrderIntention'][@id='edit-address']")]
        public IWebElement ModifierLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-shipping-address']//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='address-section']//*[@class='saved-addresses']")]
        public IWebElement SavedAddressText { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement DepartmentDropDown { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form-sav']//*[@aria-owns='City_listbox']")]
        public IWebElement MunciplityDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-section']")]
        public IWebElement ManageSavedAddress { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }
        [FindsBy(How = How.XPath, Using = "(//div[@class='notification-success'])[2]")]
        public IWebElement AddressaddedsuccessfullyMSG { get; set; }
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
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']/ul[2]/li[3]/span[1]/span/span[1]")]
        public IWebElement City { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']/ul[2]/li[4]/span[1]/span/span[1]")]
        public IWebElement StateList { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement DistrictText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Additional']")]
        public IWebElement Additional { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='Province']")]
        public IWebElement State { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='AreaCode']")]
        public IWebElement AreaCode { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement displayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement GoogleSearchButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='click: clearSearch']")]
        public IWebElement SearchFieldCloseBtnP { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']//span[@data-bind='invisible: showMap']")]
        public IWebElement ViewMap { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: showMap']")]
        public IWebElement ViewMapLocation { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//*[@data-bind='visible: isLocationFound']//h4")]
        public IWebElement NoPickUpLocationFound { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pudo-location']//*[@data-bind='invisible: PickupLocationsFoundFunc']")]
        public IWebElement NoPUDOLocationFound { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement ShippingAddrEdit { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@class='customer-form hl-form']//div[@class='read-only break-wrap']")]
        public IWebElement AddressItem_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCustomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']/div[4]/div[3]/a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUp { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUpLocation { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='PudoLocationList']//a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPUDOLocation { get; set; }
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

        [FindsBy(How = How.XPath, Using = "//*[@src='/Shop/Address/images/pickup-herbalife.png']")]
        public IWebElement HerbalifeLogo { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement ErrorMsgFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Merci de renseigner le nom')]")]
        public IWebElement ErrorMsgLastName { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement ErrorMsgStreet { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='LastName']")]
        public IWebElement ErrorMsgInvalidLastName { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='State']/ancestor::li/span[contains(.,'Por favor, proporcione el Departamento.')]")]
        public IWebElement ErrorMsgState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement ErrorMsgMuncipality { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement ErrorMsgPhoneNumber { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street2']")]
        public IWebElement ErrorMsgStreet2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='State']")]
        public IWebElement ErrorMsgDepartmet { get; set; }
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

        public void ValidateAttributeContains(string Zip, string Streetvalue, string Cityvalue)
        {
            string value = PostalCode.InputBoxValue();
            string value2 = Street.InputBoxValue();
            string value3 = City.InputBoxValue();
            if (value.Contains(Zip) && value2.Contains(Streetvalue) && value3.Contains(Cityvalue))
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
        public void SelectMilesInd(int ind)
        {
            PickUPDdnSearch.Click();
            PickUPDdnSearch.SelectDropDownIndex(ind);
        }

        public void CitySelection(string CityName)
        {
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }
        public void SelectCityOption(string option)
        {
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@class='k-list k-reset']//*[@class='k-item']").ToList();
            PageExtension.WaitForTimeSpan(3000);

            Citylist.FirstOrDefault(i => i.Text.Contains(option)).Click();
        }

        public void SelectStateOption(string StateName)
        {
            PageExtension.WaitForTimeSpan(3000);
            StateDropDown.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();



        }
        public void SelectMunciOption(string CityName)
        {
            CityDropDown.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Ctylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Ctylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();


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
            Street2TextBox.SendKeys(add.Street2);
            PageExtension.WaitForTimeSpan(3000);
            SelectStateOption(add.State);
            PageExtension.WaitForTimeSpan(4000);
            SelectMunciOption(add.City);
            PageExtension.WaitForTimeSpan(2000);
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
               // PageExtension.ScrollIntoView(this, ShippingAddrSave);
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
                    add.FillAddressforSAMCAM("Tes1h", "S", "streer44", "GHG", "AHUACHAPAN", "AHUACHAPAN", "", "12345678");
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {

                        PageExtension.WaitForTimeSpan(1000);
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

                        PageExtension.WaitForTimeSpan(3000);
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
                    PageExtension.WaitForTimeSpan(2000);
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
        public void SearchAddress(string FirstName)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            PageExtension.ScrollToTop(this);
            SearchFieldCloseBtn.Click();
            SearchFieldPersonal.SendKeys(FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }
        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
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
        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        public void SearchValidAddress()
        {

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
                    if (CommonMethods.IsElementDisplayed(ShiptothisBut))
                    {
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditInformation));
                        Assert.IsTrue(true, "The selected customer address is Valid");
                        break;
                    }

                }
            }
            else
                Assert.IsFalse(true, "No Valid customer address found");
        }

        public void SearchInValidAddress(Framework.Address add)
        {
            bool isInvalid = false;
            var cus = MandatryFieldCount("//*[@id='addressList']//div[@role='option']");
            if (cus.Count > 0)
            {
                foreach (var val in cus)
                {
                    
                    this.ScrollIntoView(val);
                    this.ScrollToTop();
                    //PageExtension.WaitForTimeSpan(1000);
                    val.Click();
                    this.WaitForElementGone(CommonFindBy.LoadIndicator);
                    if (CommonMethods.IsElementDisplayed(ShippingAddrSave) && CommonMethods.IsElementDisplayed(ShippingAddrCancel))
                    {
                        PageExtension.WaitForTimeSpan(1000);
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
                        SelectStateOption(add.State);
                        PageExtension.WaitForTimeSpan(1000);
                        SelectMunciOption(add.City);
                        PageExtension.WaitForTimeSpan(1000);
                        PageExtension.ScrollElementIntoMiddle(this, ShippingAddrSave);
                        ShippingAddrSave.Click();
                        PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                        Driver.WaitForDocumentReady();
                        WaitForAddressList();
                        ShiptothisBut.Click();
                        WaitSpinToFalse();
                        PageExtension.WaitForTimeSpan(2000);
                        PageExtension.WaitForElementPresentAndVisible(this, ShoppersAddr);
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(ShoppersAddr));
                        isInvalid = true;
                        break;
                    }
                }

                if (isInvalid == false)
                    Assert.IsTrue(false, "No Invalid Customer address found");

            }

            else
                Assert.IsFalse(true, "No customer address found");
        }
    }
    public class DeliveryAddressPersonalPageTestSV : DeliveryAddressPersonalPage_SV { }
}
