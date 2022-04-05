using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Shop.Automation.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressCustomerPage_PR : Page
    {
        public const string CustomerList1 = "//*[@id='contactList']//div[@class='address-info']";

        #region Page WebElement

        [FindsBy(How = How.XPath, Using = "//*[@class='address-content']/h3")]
        public IWebElement PageHeading1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-content']//p")]
        public IWebElement PageHeading2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@id='contactList']//div[@class='address-item'])[1]")]
        public IWebElement SelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-search']")]
        public IWebElement SearchFieldCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//div[@class='address-info']")]
        public IWebElement CustomerList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-customer-direct-compare-address']")]
        public IWebElement AddressMatching { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@data-bind='visible: IsAddressMatchedWithNC']")]
        public IWebElement NCAddressWarning { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='close-reveal-modal btn-cancel opp-side']")]
        public IWebElement NCAddressWarning_GoBackbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='close-reveal-modal btn-delete']")]
        public IWebElement NCAddressWarning_Continuebtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@class='close-reveal-modal btn-delete'])[2]")]
        public IWebElement AddressWarning_Continuebtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='add-customer']")]
        public IWebElement AddNewCustomerBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Agregar nueva dirección de envío')]")]
        public IWebElement AddNewManageAddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-shipping-address']//*[@id='btn-save-new-address']")]
        public IWebElement ManageAddShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement ManageAddShippingAddAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='manage-customer']")]
        public IWebElement ManageMyCustomerBtn { get; set; }

        //Customer address fields
        [FindsBy(How = How.XPath, Using = "//ul[@data-bind='visible:IsUsResident']//*[@id='FirstName']")]
        public IWebElement FirstNameCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement Zip { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-shipping-address']//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:IsUsResident']//*[@id='FirstName']")]
        public IWebElement FirstNameCD1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastNameCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:IsUsResident']//*[@id='LastName']")]
        public IWebElement LastNameCD1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Address1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement CityCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement StateCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement ZipCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='EmailAddress']")]
        public IWebElement EmailCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumberCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneType']")]
        public IWebElement PhoneTypeCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-contact']")]
        public IWebElement CancelBtnCD { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-save-new-contact'])[1]")]
        public IWebElement SaveBtnCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-address-form']//span[@class='color-red']")]
        public IWebElement AddrMandatry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-address-form']/ul/li[7]/label/span")]
        public IWebElement EmailMandatryChk { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='Primary' and @value='1']")]
        public IWebElement PrimaryHomeCheckBox { get; set; }

        //DS address warning popup
        [FindsBy(How = How.XPath, Using = "//*[@id='modal-customer-direct-compare-address']//*[@class='close-reveal-modal btn-delete']")]
        public IWebElement ConfirmBtn { get; set; }

        //address not found by search message
        [FindsBy(How = How.XPath, Using = "//*[@class='customer-list']/h4")]
        public IWebElement AddrNotFoundMsg { get; set; }

        //Duplicate address popup elements
        [FindsBy(How = How.XPath, Using = "//*[@class='btn-cancel close-reveal-modal']")]
        public IWebElement AddAsNewContact { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PickupSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement SelectMilesDdn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement SearchBtn { get; set; }

        //Address Field error message
        [FindsBy(How = How.XPath, Using = "//*[@id='formError' and @class='error']")]//please complete all required fields
        public IWebElement AllError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='k-invalid-msg error' and @name='customer-direct-generic-error']")]//This is not a valid address
        public IWebElement InvalidAddrError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-form']//*[@class='k-invalid-msg error']")]
        public IWebElement ErrorCodeAddrMessage { get; set; }

        public ReadOnlyCollection<IWebElement> webelementsColl;

        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Address/DeliveryAddress/CustomerDirect/{RunSettings.ValidUser.Schema}";

        //New 4 tab user story elements
        //choose delivery options below
        [FindsBy(How = How.XPath, Using = "//*[@id='customer-toggle']")]
        public IWebElement CustomerAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='club-toggle']")]
        public IWebElement ClubAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='new-shipping-address']//input[@id='Street2']")]
        public IWebElement Address2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='hl-toggle']")]
        public IWebElement HerbalifeLocationBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='fedex-toggle']")]
        public IWebElement FedExLocationBtn { get; set; }

        //customer shipping use selected address button
        [FindsBy(How = How.XPath, Using = "//*[@id='customer-direct-customer-address']//*[@id='btn-cancel-contact-addresss']")]
        public IWebElement UseSelectedAddrBtn { get; set; }

        //Any address edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-edit-contact-addresss']")]
        public IWebElement EditAddr { get; set; }

        //customer club use selected address button
        [FindsBy(How = How.XPath, Using = "//*[@id='customer-direct-club-addresses']//*[@id='btn-cancel-contact-addresss']")]
        public IWebElement ClubUseSelectedAddrBtn { get; set; }

        //Herbalife locations use selected address button
        [FindsBy(How = How.XPath, Using = "//*[@id='customer-direct-hl-addresses']//*[@id='btn-pickup-delivery']")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        //Herbalife locations use selected address button
        [FindsBy(How = How.XPath, Using = "//*[@id='customer-direct-fedex-addresses']//*[@id='btn-pickup-delivery']")]
        public IWebElement FedExUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='close-reveal-modal btn-delete' and @data-bind='visible:ContactAddressConfirmation, click: ConfirmContactAddress']")]
        public IWebElement ConfirmBtn1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer-direct-club-addresses']//h4")]
        public IWebElement ClubAddrNotFoundMsg { get; set; }

        //If Club address is invalid
        [FindsBy(How = How.XPath, Using = "//*[@id='club-addresses']/span[@class='error']")]
        public IWebElement ClubAddrInvalid { get; set; }

        //customer address info
        [FindsBy(How = How.XPath, Using = "//*[@class='primary-address']/h4[@class='read-only']")]
        public IWebElement FNameLname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='primary-address']//*[@class='edit-customer-link']")]
        public IWebElement EditCostomerLink { get; set; }

        //Add new customer alternate address fields
        [FindsBy(How = How.XPath, Using = "//*[@class='primary-address']//*[@class='add-address-link']")]
        public IWebElement AddCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//*[@id='btn-save-new-contact']")]
        public IWebElement CostomerAlternateAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//*[@id='Street']")]
        public IWebElement CostomerAlternateAddrStreet { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='CustomerAddressesList']//div[@class='address-item']")]
        public IWebElement SelectCustomerAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerAddressesList']/div")]
        public IWebElement SelectCustomerAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//*[@id='City']")]
        public IWebElement CostomerAlternateAddrCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//*[@id='State']")]
        public IWebElement CostomerAlternateAddrState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//*[@id='Zip']")]
        public IWebElement CostomerAlternateAddrZip { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//*[@id='Primary']")]
        public IWebElement CostomerAlternateHomeChkBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//*[@id='btn-cancel-new-contact']")]
        public IWebElement CostomerAlternateAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='delete-address-link']")]
        public IWebElement CostomerAlternateAddrDelete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//span[@data-for='AddressStreet']")]
        public IWebElement CostomerAlternateAddrStreetWrngMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//span[@data-for='AddressCity']")]
        public IWebElement CostomerAlternateAddrCityWrngMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//span[@data-for='AddressState']")]
        public IWebElement CostomerAlternateAddrStateWrngMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-new-address-form']//span[@data-for='AddressZip']")]
        public IWebElement CostomerAlternateAddrZipWrngMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='add-new-addresss']//div[@class='notification-error' and @data-bind='fadeIn: IsAddressMatchedWithPickupForSaveUpdate']")]
        public IWebElement CostomerAlternateAddrWHBlockMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-form']//*[contains(@data-bind,'IsAddressMatchedWithPickupForSaveUpdate')]")]
        public IWebElement CostomerAddrWHBlockMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-form']//div[@data-bind='fadeIn: IsPhoneMatchedWithPickupForSaveUpdate']")]
        public IWebElement CostomerPhoneNbrWHBlockMsg { get; set; }

        //Customer invalid phone warning message
        [FindsBy(How = How.XPath, Using = "//*[@class='notification-error' and @data-bind='fadeIn: IsInvalidPhone']")]
        public IWebElement InvalidPhoneWarningMsg { get; set; }

        //Customer invalid email warning message
        [FindsBy(How = How.XPath, Using = "//*[@class='notification-error' and @data-bind='fadeIn: IsInvalidEmail']")]
        public IWebElement InvalidEmailWarningMsg { get; set; }

        //Customer invalid address warning message
        [FindsBy(How = How.XPath, Using = "//*[@class='notification-error' and @data-bind='fadeIn: IsInvalidHomeAddress']")]
        public IWebElement InvalidAddrWarningMsg { get; set; }

        //Customer invalid FN/LN warning message
        [FindsBy(How = How.XPath, Using = "//*[@class='notification-error' and @data-bind='fadeIn: IsNameMatchedWithComplianceForSaveUpdate']")]
        public IWebElement BlockedFirstNameErroMsg { get; set; }

        //Customer invalid FN/LN warning message
        [FindsBy(How = How.XPath, Using = "//*[@class='notification-error' and @data-bind='fadeIn: IsHCAddressForSaveUpdate']")]
        public IWebElement HCBlockedFirstNameErroMsg { get; set; }

        //Edit Customer address
        [FindsBy(How = How.XPath, Using = "//*[@class='address-verifed']//*[@class='btn-edit opp-side']")]
        public IWebElement EditCustomerAddrBtn { get; set; }

        //US 439767
        [FindsBy(How = How.XPath, Using = "//*[@id='ResidentType']")]
        public IWebElement ResidentChkbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:IsUsResident']//*[@id='FirstName']")]
        public IWebElement NonUsFN { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:IsUsResident']//*[@id='LastName']")]
        public IWebElement NonUsLN { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='full']//*[@id='NonUsStreet']")]
        public IWebElement NonUsAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='NonUsCity']")]
        public IWebElement NonUsCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='NonUsState']")]
        public IWebElement NonUsState { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='NonUsZip']")]
        public IWebElement NonUsZip { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='NonUsCountry']")]
        public IWebElement NonUsCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:IsUsResident']//*[@id='EmailAddress']")]
        public IWebElement NonUsEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumberNonUS']")]
        public IWebElement NonUsPhone { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:IsUsResident']//*[@id='PhoneType']")]
        public IWebElement NonUsPhoneType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='customer-direct-customer-address']//h4")]
        public IWebElement NoAddrMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement FedExAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='UsStateList']")]
        public IWebElement PRStateCD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-form']//*[contains(@data-bind,'IsPOAddressForSaveUpdate')]")]
        public IWebElement CostomerAddrPOBOXBlockMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:IsUsResident']//*[@id='PhoneNumber']")]
        public IWebElement NonUsPRPhone { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible:IsSelectedUSCountry']//*[@data-for='NonUsStreet']")]
        public IWebElement NonUsStreetError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-address-form']//*[@data-for='NonUsCity']")]
        public IWebElement NonUsCityError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-address-form']//*[@data-for='NonUsState']")]
        public IWebElement NonUsStateError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-address-form']//*[@data-for='NonUsCountry']")]
        public IWebElement NonUsCountryError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-address-form']//*[@data-for='PhoneNumberNonUS']")]
        public IWebElement NonUsPhoneError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contactList']//div[@class='address-info'][1]")]
        public IWebElement NonUsFirstElementinlist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ClubMembersList']/div[@class='address-item']")]
        public IWebElement ClubAddresses { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='customer-direct-customer-address']//*[@class='address-info'])[1]")]
        public IWebElement CustomerAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@class='close-reveal-modal btn-delete'])[1]")]
        public IWebElement AddressMatchContinue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']//*[@class='icon-magnifier-fl-1']")]
        public IWebElement LocationMagnifierIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='fadeIn: ContactSavedCorrectly']")]
        public IWebElement Successmessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: IsSelectedUSCountry']//*[@id='FirstName']")]
        public IWebElement NonPRFN { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: IsSelectedUSCountry']//*[@id='LastName']")]
        public IWebElement NonPRLN { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='NonUsStreet']")]
        public IWebElement NonPRAddress1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible: IsSelectedUSCountry']//*[@id='PhoneNumber']")]
        public IWebElement NonPRPhone { get; set; }

        #endregion

        #region Page Functions

        public void WaitForAddressList()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@id='contactList']//div[@class='address-info']");
            while (Iweb.Count < 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@id='contactList']//div[@class='address-info']");
            }

        }

        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
        }

        public void SelectStateOption(string option)
        {
            StateCD.SelectDropDownOption(option);
        }
        public void SelectNonUSStateOption(string option)
        {
            PRStateCD.SelectDropDownOption(option);
        }
        public void SelectStateOption1(string option)
        {
            CostomerAlternateAddrState.SelectDropDownOption(option);
        }
        public void SelectPhoneOption(string option)
        {
            PhoneTypeCD.SelectDropDownOption(option);
        }

        public void SelectPhoneOptionNonUS(string option)
        {
            NonUsPhoneType.SelectDropDownOption(option);
        }

        public void SelectCountryOption(string option)
        {
            NonUsCountry.SelectDropDownOption(option);
        }

        public void SelectMilesOption(string option)
        {
            SelectMilesDdn.SelectDropDownOption(option);
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


        public List<string> getListofInvalidFistName()
        {
            List<string> Fname = new List<string>();
            Fname.Add("Retail");
            Fname.Add("Aasassy");
            Fname.Add("A club");
            Fname.Add("Walk");
            Fname.Add("A");
            Fname.Add("HERBA");
            Fname.Add("Test");
            Fname.Add("Pizza");
            Fname.Add("Unknown");
            Fname.Add("Clear");
            Fname.Add("%");
            Fname.Add(")");
            Fname.Add("Sales");
            Fname.Add("^");
            Fname.Add("Sales Center");
            Fname.Add("@");
            Fname.Add("test");
            Fname.Add("32432");
            Fname.Add("Love");
            Fname.Add("Love12456");
            return Fname;

        }
        public List<string> getListofInvalidLastName()
        {
            List<string> Lname = new List<string>();
            Lname.Add("Sales");
            Lname.Add("Club");
            Lname.Add("Buddy");
            Lname.Add("In");
            Lname.Add("K");
            Lname.Add("LOVE");
            Lname.Add("Customer");
            Lname.Add("CS");
            Lname.Add("Place");
            Lname.Add("Retail");
            Lname.Add("Skies");
            Lname.Add("Q");
            Lname.Add("+");
            Lname.Add("Unknown");
            Lname.Add("Sales Center");
            Lname.Add("%$^");
            Lname.Add("Love12456");
            Lname.Add("test");
            Lname.Add("Test");
            Lname.Add("Pizza");
            Lname.Add("2376");
            return Lname;
        }

        private static Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public void WaitForCustomerAddressLoad()
        {
            var Iweb = MandatryFieldCount("//*[@id='contactList']//div[@class='address-info']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = MandatryFieldCount("//*[@id='contactList']//div[@class='address-info']").ToList();
                break;
            }
        }

        public void SearchValidAddress(bool isNonUS = false)
        {
            bool found = false;
            PageExtension.WaitForElementPresentAndVisible(this, NonUsFirstElementinlist);
            var cus = MandatryFieldCount("//*[@id='contactList']//div[@class='address-info']");
            if (cus.Count > 0)
            {
                foreach (var val in cus)
                {
                    if (val != null)
                    {
                        PageExtension.WaitForTimeSpan(1000);
                        //PageExtension.ScrollElementIntoMiddle(this, val, 5);
                        val.Click();
                    }
                    WaitSpainToFalse();
                    PageExtension.WaitForElementPresentAndVisible(this, ConfirmBtn, 2);
                    if (CommonMethods.IsElementDisplayed(ConfirmBtn))
                    {
                        ConfirmBtn.Click();
                        WaitSpainToFalse();
                        PageExtension.WaitForElementPresentAndVisible(this, CustomerAddrBtn, 2);
                        if (CommonMethods.IsElementDisplayed(CustomerAddrBtn) && (isNonUS ? ValidateAddressForUS() : ValidateAddressForNonUS()))
                        {
                            Assert.IsTrue(CommonMethods.IsElementDisplayed(EditCostomerLink));
                            Assert.IsTrue(CommonMethods.IsElementDisplayed(FNameLname));
                            found = true;
                            break;
                        }
                    }
                    else if (CommonMethods.IsElementDisplayed(CustomerAddrBtn) && ((isNonUS) ? ValidateAddressForUS() : ValidateAddressForNonUS()))
                    {
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditCostomerLink));
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(FNameLname));
                        found = true;
                        break;
                    }
                    else if (CommonMethods.IsElementDisplayed(InvalidPhoneWarningMsg))
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(InvalidPhoneWarningMsg));
                    else if (CommonMethods.IsElementDisplayed(InvalidEmailWarningMsg))
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(InvalidEmailWarningMsg));
                    else if (CommonMethods.IsElementDisplayed(InvalidAddrWarningMsg))
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(InvalidAddrWarningMsg));
                    else
                        Assert.IsTrue(true, "The selected customer address US resident address");
                    found = false;
                }
                if (found == false)
                {
                    if (isNonUS)
                        AddNewCustomerPRAddress();
                    else
                        AddNewCustomerNonUSAddress();
                }
            }
            else
                Assert.IsFalse(true, "No customer address found");
        }

        public void AddNewCustomerPRAddress()
        {
            bool isPresent = false;
            this.Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            this.WaitForElementPresentAndVisible(CustomerList);
            AddNewCustomerBtn.Click();
            this.WaitForElementPresentAndVisible(SaveBtnCD);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameCD));
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddress("", "DSJD", "F45 CALLE 14   ALT RIO GRANDE", "RIO GRANDE", "PR", "00745-5126", "3236212019", "Mobile");
            FirstNameCD.SendKeys(RandomString(8));
            LastNameCD.SendKeys(add.LastName);
            Address1.SendKeys(add.Street);
            CityCD.SendKeys(add.City);
            SelectStateOption(add.State);
            ZipCD.SendKeys(add.Zip);
            EmailCD.SendKeys(RandomEmail());
            PhoneNumberCD.SendKeys(add.PhoneNumber);
            SelectPhoneOption(add.PhoneType);
            SaveBtnCD.Click();
            this.WaitForElementGone(CommonFindBy.BusyIndicator);
            this.WaitForElementPresentAndVisible(AddAsNewContact, 4);
            if (CommonMethods.IsElementDisplayed(AddAsNewContact))
            {
                AddAsNewContact.Click();
                this.WaitForElementGone(CommonFindBy.BusyIndicator);
            }
            this.WaitForElementPresentAndVisible(CustomerAddrBtn, 4);
            var count = MandatryFieldCount("//*[@id='contactList']//div[@class='address-info']");
            foreach (var v in count)
            {
                if (v.Text.Contains(add.FirstName))
                {
                    Assert.IsTrue(true);
                    isPresent = true;
                    break;
                }
            }
            if (isPresent)
                Assert.IsTrue(true, "Address found in the list");
            else
                Assert.IsTrue(false, "Address not found");
        }

        public void AddNewCustomerNonUSAddress()
        {
            this.Driver.WaitForDocumentReady();
            this.WaitForElementGone(CommonFindBy.LoadIndicator);
            this.WaitForElementPresentAndVisible(CustomerList);
            AddNewCustomerBtn.Click();
            this.WaitForElementPresentAndVisible(SaveBtnCD);
            this.WaitForElementPresentAndVisible(ResidentChkbox);
            ResidentChkbox.Click();
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ResidentChkbox));
            this.WaitForElementPresentAndVisible(FirstNameCD);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameCD));
            Shop.Automation.Framework.Address add = new Shop.Automation.Framework.Address();
            add.FillAddressForNonUS("DSJ", "last", "MG road", "Bangalore", "Karnataka", "560012", "IN", "test", "9999988888", "Mobile");
            add.FirstName = RandomString(10);
            NonUsFN.SendKeys(add.FirstName);
            NonUsLN.SendKeys(add.LastName);
            NonUsAddress1.SendKeys(add.Street);
            NonUsCity.SendKeys(add.City);
            NonUsState.SendKeys(add.State);
            NonUsZip.SendKeys(add.Zip);
            SelectCountryOption(add.Country);
            NonUsEmail.SendKeys(add.Email);
            NonUsPhone.SendKeys(add.PhoneNumber);
            SelectPhoneOptionNonUS(add.PhoneType);
            SaveBtnCD.Click();
            this.WaitForElementGone(CommonFindBy.BusyIndicator);
            PageExtension.WaitForTimeSpan(3000);
            var count = MandatryFieldCount("//*[@id='contactList']//div[@class='address-info']");
            foreach (var v in count)
            {
                if (v.Text.Contains(add.FirstName))
                {
                    Assert.IsTrue(true);
                    break;
                }
                else
                    Assert.IsFalse(true, "Address has not saved");
            }
            if (CommonMethods.IsElementDisplayed(CustomerAddrBtn))
            {
                Assert.IsTrue(CommonMethods.IsElementDisplayed(CustomerAddrBtn));
                Assert.IsTrue(CommonMethods.IsElementDisplayed(NoAddrMsg));
                Assert.IsTrue(CommonMethods.IsElementDisplayed(UseSelectedAddrBtn));
                Assert.IsFalse(CommonMethods.IsElementEnabled(UseSelectedAddrBtn), "The Button is disabled");
            }
            else
                Assert.IsFalse(true, "The selected customer address is not valid");
        }

        public bool ValidateAddressForNonUS()
        {
            var cus = MandatryFieldCount("//*[@id='CustomerAddressesList']/div");
            if (cus.Count > 0)
            {
                foreach (var va in cus)
                {
                    if (va.FindElement(By.TagName("strong")).Text.Contains("Dirección de Casa"))
                    {
                        Assert.IsTrue(true, "US address");
                        return false;
                    }
                }
            }
            else
            {
                Assert.IsTrue(true, "Non US address");
                return true;
            }

            return true;
        }

        public bool ValidateAddressForUS()
        {
            var cus = MandatryFieldCount("//*[@id='CustomerAddressesList']/div");
            if (cus.Count > 0)
            {
                foreach (var va in cus)
                {
                    if (va.FindElement(By.TagName("strong")).Text.Contains("Dirección de Casa"))
                    {
                        Assert.IsTrue(true, "PR address");
                    }
                    else
                    {
                        Assert.IsTrue(true, "No address found");
                        return false;
                    }

                }
            }          

            return true;
        }

        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@id='customer-direct-choose-customer-address']//*[@class='h-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@id='customer-direct-choose-customer-address']//*[@class='h-loading-mask']").ToList();
            }
        }
        public bool IsAddressSaved()
        {
            webelementsColl = Driver.FindElements(By.XPath("//*[@class='saved-item']"));
            return webelementsColl.ToList().Any(item => item.Text.Contains(""));
        }

        public string RandomEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            return "username" + randomInt + "@gmail.com";
        }

        public void Validateshopperprofile(string Postalcodevalue, string Cityvalue, string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Postalcodevalue) && value.Contains(Cityvalue) && value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
        #endregion
    }
    public class DeliveryAddressCustomerPageTestPR : DeliveryAddressCustomerPage_PR { }
}
