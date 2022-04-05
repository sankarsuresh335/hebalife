using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_CR_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";
        public string CartPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}" + "??orderCategory=RSO" + "";

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-content']/h3")]
        public IWebElement DeliveryPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement ShippingAddresslist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='saved-addresses']/h3")]
        public IWebElement ManageAddPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div")]
        public IWebElement PickUpLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement SearchWarningMSG { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighborhood']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-default-address-changed'])[2]")]
        public IWebElement UsethisSelectedAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement InvalidPhoneNumberErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@id='Zip']/following-sibling::span[@data-bind='visible: ZipNotFound'])[1]")]
        public IWebElement ZipErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='FirstName'])[1]")]
        public IWebElement FirstNameErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='LastName'])[1]")]
        public IWebElement LastNameErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='Street'])[1]")]
        public IWebElement StreetErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='State'])[1]")]
        public IWebElement StateErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='City'])[1]")]
        public IWebElement CityErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='Neighborhood'])[1]")]
        public IWebElement CountyErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='PhoneNumber'])[1]")]
        public IWebElement PhoneNumberErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        public ReadOnlyCollection<IWebElement> webelementsColl;
        
        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
        }

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));

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
        public void AddAddress(Shop.Automation.Framework.Address add, bool isEdit = false, bool isCancelled = false)
        {
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(600);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(2000);
            Street.SendKeys(add.Street);
            SelectStateOption(add.State);
            WaitSpainToFalse();
            PageExtension.WaitForTimeSpan(2000);
            SelectCityOption(add.City);
            WaitSpainToFalse();
            PageExtension.WaitForTimeSpan(2000);
            SelectCountyOption(add.Country);
            PageExtension.WaitForTimeSpan(1000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(3000);
            if (isCancelled)
                Cancel.Click();
            else
                SaveButton.Click();
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            Driver.WaitForDocumentReady();
        }

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        public void WaitSpainToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void SelectStateOption(string option)
        {
            State.SelectDropDownOption(option);
        }

        public void SelectCityOption(string option)
        {
            City.SelectDropDownOption(option);
        }
        public void SelectCountyOption(string option)
        {
            County.SelectDropDownOption(option);
        }

        /// <summary>
        /// Below Method is used for validating Duplicate popup 
        /// </summary>
        /// <param name="add"></param>
        public void VerifyDuplicatePopUp(Framework.Address add)
        {
            //PageExtension.WaitForElementPresentAndVisible( this.Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpainToFalse();
            //need to check 
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(2000);
            //PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Duplicatelist.Click();
            //PageExtension.WaitForElementPresentAndVisible(this, CurrentPage.Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled(Overwrite));
            Overwrite.Click();

        }

        public void Validateshopperprofile(string Statevalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Statevalue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }
    }
    public class DeliveryAddressPersonalPageTestCRMB : DeliveryAddressPersonalPage_CR_MB { }
}
