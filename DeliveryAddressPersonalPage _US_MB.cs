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
    public class DeliveryAddressPersonalPage_US_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        public string HapOrderAddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/Haporders/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='savedAddressesList']/li")]
        public IWebElement ManagePersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//section[@class='address-content']/p")]
        public IWebElement ShippingMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@data-bind='click: ClearSearchBox']")]
        public IWebElement SearchFieldCloseBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@name='generic-error']")]
        public IWebElement InvalidAddress { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement PostalCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street2']")]
        public IWebElement Street2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighbourhood']")]
        public IWebElement Neighbourhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='FirstName']")]
        public IWebElement FirstNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='LastName']")]
        public IWebElement LastNameFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='PhoneType']")]
        public IWebElement PhoneTypeError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Street']")]
        public IWebElement StreetFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='City']")]
        public IWebElement CityFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='Zip']")]
        public IWebElement ZipFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//span[@data-for='State']")]
        public IWebElement StateFieldError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement EditShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='fadeIn: AddressUpdatedCorrectly']")]
        public IWebElement AddressUpdated { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneType']")]
        public IWebElement PhoneType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@value='Other']")]
        public IWebElement OthersPhoneType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement MileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@id='fedex-toggle']")]
        public IWebElement AllPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div")]
        public IWebElement HerbalifeLocationList { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip']")]
        public IWebElement ZipInvalid { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneInvalid { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditShippingAddresLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address-edit']")]
        public IWebElement SaveEditedShippingAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@data-bind='visible: HasAddresses']")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-add-new-address']")]
        public IWebElement ManageAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='address-item']")]
        public IWebElement PersonalList { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Sorry, no Pickup Locations found. Please expand your search criteria.')]")]
        public IWebElement PickSearchNoAddressfoundMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement PickUPList { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//img[@src='https://maps.gstatic.com/mapfiles/transparent.png']")]
        public IWebElement LocationsOnMap { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[1]")]
        public IWebElement btbShowMap { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-pickup-showmap']/span)[2]")]
        public IWebElement btbViewLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='total-locations']")]
        public IWebElement totalLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "(//strong[@data-bind='text: WarehouseName, visible: WarehouseName'])[1]")]
        public IWebElement Pickup1stAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@class='btn-select btn-ship'])[2]")]
        public IWebElement Shiptobtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='btn-address-edit']")]
        public IWebElement PersonalListEdit { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-pickup-location']//a[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-item']")]
        public IWebElement AddressItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='fedex-toggle']")]
        public IWebElement FedexToggleButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']")]
        public IWebElement Productlines { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[2]")]
        public IWebElement FedexSelectAddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PickupSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName' and contains(text(),'Invalid First Name')]")]
        public IWebElement invalidFirstNameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='LastName' and contains(text(),'Invalid Last Name')]")]
        public IWebElement invalidLastNameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip' and contains(text(),'Zip is not valid')]")]
        public IWebElement invalidZipErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber' and contains(text(),' Phone number is not valid')]")]
        public IWebElement invalidPhoneErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='generic-error']/div")]
        public IWebElement genericErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='FirstName']")]
        public IWebElement RequiredFirstNameErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='LastName']")]
        public IWebElement RequiredLastNameErrorMsg { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//*[@data-for='Street']")]
        public IWebElement RequiredAddress1ErrorMsg { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@data-for='City']")]
        public IWebElement RequiredCityErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='Zip']")]
        public IWebElement RequiredZipErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneNumber']")]
        public IWebElement RequiredPhoneNumberErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-for='PhoneType']")]
        public IWebElement RequiredPhoneTypeErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal' and @value='1']")]
        public IWebElement PersonalRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='address-info'])[1]")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='btn-add-cart']")]
        public IWebElement Buynow { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@wire-model='OrderIntention']")]
        public IWebElement ChangeAddrOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[contains(@data-bind, 'click: checkoutPage1Submit')])[2]")]
        public IWebElement Proceedtocheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),'Ship To')]")]
        public IWebElement Shiptolabel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'ContactSavedCorrectly')]")]
        public IWebElement ContactSavedSuccessfullyNotification { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='add-new-address']//div[contains(@data-bind,'visible: IsPhoneMatchedWithPickup')]")]
        public IWebElement BlockNotificationForHLPhone { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@data-bind='invisible: CanProceed'])[2]")]
        public IWebElement invalidContactInformationMSG { get; set; }



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

        public void ValidateAttributeContains(string Cityexpval, string Phonetypeexpval)
        {
            string CityVal = City.InputBoxValue();
            string Phoneypeval = PhoneType.InputBoxValue();

            if (Phoneypeval.Contains(Cityexpval) && CityVal.Contains(Phonetypeexpval))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void SelectMilesOption(int option)
        {
            WebElementExtension.SelectDropDownIndex(PickUPDdnSearch, option);
        }

        public void CitySelection(string CityName)
        {
            City.Click();
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }

        public void VerifyFieldLength()
        {
            
            AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            TextFieldCount(FirstName, 18, "LMMuwqtetqweiywqeyoqw1");
            TextFieldCount(LastName, 18, "KDeuwqtetqwNiywqeyoqw1");
            TextFieldCount(Street, 40, "r7493hfh4392ruowejrooerjewjrlwejrwlr#wle1");
            TextFieldCount(City, 30, "r7493hfh4392ruowejrooerjewjrlwejrwlr;wle45435345435435trrtre;wle1");
            TextFieldCount(PostalCode, 5, "12345");
            TextFieldCount(PhoneNumber, 10, "123456789012");
        }
        public void TextFieldCount(IWebElement webEle, int Count, string Actvalue)
        {
            webEle.SendKeys(Actvalue);
            int ActualCount = webEle.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        public void SelectPickupAddress()
        {
            var val = MandatryFieldCount("//*[@id='MyHerbalifelocationList']/div[@class='address-item']//strong");
            if (val.Count > 0)
            {
                foreach (var v in val)
                {
                    if ((v.Text).Contains("XZ – El Super"))
                    {
                        v.Click();
                        break;
                    }
                }
            }
            else
                Assert.IsTrue(false, "No address found");

        }

        public IList<IWebElement> verifyMileDropDown()
        {
            SelectElement oSelect = new SelectElement(MileDropdown);
            IList<IWebElement> elementCount = oSelect.Options;
            return elementCount;
        }

        public void ValidateshopperprofilePickUP(string Streetvalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void SelectPhoneOption(string option)
        {
            PhoneType.SelectDropDownOption(option);
        }

        public void SelectStateOption(string option)
        {
            State.SelectDropDownOption(option);
        }

        public void VerifyDuplicatePopUp(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(3000);
            ShippingAddrSave.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Duplicatelist.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled(Overwrite));
            Overwrite.Click();
        }
        public void AddNewAddress(Shop.Automation.Framework.Address add, bool IsCancelled = false, bool isEdit = false)
        {
            if (Driver.Url.Contains("SavedAddresses"))
                ManageAddAddress.Click();
            else
                AddAddressBtn.Click();
            PageExtension.WaitForElementPresentAndVisible(this, FirstName);
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            Street.SendKeys(add.Street);
            City.SendKeys(add.City);
            PostalCode.SendKeys(add.Zip);

            PageExtension.WaitForTimeSpan(1000);
            if (isEdit)
            {
                SaveEditedShippingAddressBtn.Click();
            }
            else
            {

                PhoneNumber.SendKeys(add.PhoneNumber);
                SelectPhoneOption(add.PhoneType);
                SelectStateOption(add.State);
                
            }
            if (IsCancelled)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            Driver.WaitForDocumentReady();
        }

        public void SearchSavedAddress(Shop.Automation.Framework.Address add)
        {
            //Search Address
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
        }

        //Shopper Profile Validation for Pickup
        public void ValidateshopperprofileShipping(string expected)
        {
            string Actual = ShoppersAddr.Text;
            Assert.IsTrue(Actual.Contains(expected));
        }

        public void VerifyPhoneTypeDroupdownList() {
            List<string> expectedDropDownValues = new List<string>();
            expectedDropDownValues.Add("Select");
            expectedDropDownValues.Add("Mobile");
            expectedDropDownValues.Add("Work");
            expectedDropDownValues.Add("Home");
            expectedDropDownValues.Add("Other");
            SelectElement original = new SelectElement(PhoneType);
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

    }
    public class DeliveryAddressPersonalPageTestUSMB : DeliveryAddressPersonalPage_US_MB { }
}
