using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_BR_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public string CartPage => $"{RunSettings.FarmUrl}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}";
        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Personal']")]
        public IWebElement PersonalradioButton { get; set; }

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

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditShippingAddresLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-item']")]
        public IWebElement AddressItem { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']")]
        public IWebElement Productlines { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-pickup-delivery'])[2]")]
        public IWebElement SelectAddressButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement PickupSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='address-pickup-primary']")]
        public IWebElement PrimaryCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i")]
        public IWebElement PickupSearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement ViewMapBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='viewMap']")]
        public IWebElement ViewMapPage { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='address-search-value'])[2]")]
        public IWebElement AddressSearchValue { get; set; }

        [FindsBy(How = How.XPath, Using = "((//*[@class='shipping-list'])[2]//div[@class='address-item'])[1]")]
        public IWebElement AddressSearchValueElement { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form new-customer']//a[@class='btn-continue']")]
        public IWebElement ConfrimBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='duplicated-contacts']//*[@class='address-item']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Escolha um endereço de entrega')]")]
        public IWebElement AddresHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list pu-list']/h4")]
        public IWebElement PickUpNoAddressMsg { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[contains(text(),' Sobrenome é obrigatório')]")]
        public IWebElement LastNameErrorMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Primeiro Nome:')]/span[contains(text(),'*')]")]
        public IWebElement FirstNameAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Último Nome:')]/span[contains(text(),'*')]")]
        public IWebElement LastNameAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'CEP:')]/span[contains(text(),'*')]")]
        public IWebElement CEPAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Número:')]/span[contains(text(),'*')]")]
        public IWebElement StreetNumberAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'DDD:')]/span[contains(text(),'*')]")]
        public IWebElement DDDsterisk { get; set; }
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Número de telefone:')]/span[contains(text(),'*')]")]
        public IWebElement PhoneNumberAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Rua:')]/span[contains(text(),'*')]")]
        public IWebElement StreetAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Bairro:')]/span[contains(text(),'*')]")]
        public IWebElement NeighbourhoodAsterisk { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@data-for='FirstName'])[1]")]
        public IWebElement FirstNameErrorMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@data-for='LastName'])[1]")]

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),' CEP inválido')])[1]")]
        public IWebElement InvalidCep1ErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' CEP é obrigatório')]")]
        public IWebElement CEP1ErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='k-widget k-tooltip k-tooltip-validation k-invalid-msg zip-error']")]
        public IWebElement CEP1CodeNotFoundErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip2' and contains(text(),' CEP é obrigatório')]")]
        public IWebElement CEP2ErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='StreetNumber' and contains(text(),' Número é obrigatório')]")]
        public IWebElement StreetNumberErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='AreaCode' and contains(text(),' Código de área é obrigatório')]")]
        public IWebElement AreaCodeErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement PhoneNumberErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber']")]
        public IWebElement InvalidPhoneNumberErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }
        [FindsBy(How = How.XPath, Using = "(//input[@id='Zip']/following-sibling::span[@data-bind='visible: ZipNotFound'])[1]")]
        public IWebElement ZipErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='FirstName'])[1]")]
        public IWebElement FirstNameErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@data-for='LastName'])[1]")]
        public IWebElement LastNameErrormsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Personal']")]
        public IWebElement PersonalRadioBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='Customer']")]
        public IWebElement CustomerRadioBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete']")]
        public IWebElement Delete_ManageAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement CancelAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-list' and @data-bind= 'invisible: ShippingAddressesFound']")]
        public IWebElement NoAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchField_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement PersonalList_ManageAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressLink { get; set; }

        public ReadOnlyCollection<IWebElement> webelementsColl;

        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }
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

        public void AddAddress(Shop.Automation.Framework.Address add, bool isEdit = false, bool isCancelled = false)
        {
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(1000);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            PostalCode.SendKeys(add.Zip);
            PostalCode2.SendKeys("000");
            StreetNumber.SendKeys(add.Street);
            AreaCode.SendKeys("05");
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(3000);
            if (isCancelled)
                Cancel.Click();
            else
                SaveButton.Click();
            //if (isEdit) { CurrentPage.EditFiledSaveButton.Click();} else {

            //}
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            Driver.WaitForDocumentReady();
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

        public void SelectPhoneOption(string option)
        {
    //        PhoneType.SelectDropDownOption(option);
        }

        public void AddNewAddress(Shop.Automation.Framework.Address add, bool isEdit = false)
        {
            //PageExtension.WaitForTimeSpan(600);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstName));
            FirstName.SendKeys(add.FirstName);
            LastName.SendKeys(add.LastName);
            PostalCode.SendKeys(add.Zip);
            PostalCode2.SendKeys("000");
            StreetNumber.SendKeys(add.Street);
            Additional.SendKeys("");
            AreaCode.SendKeys("05");
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
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

        public void ClearFiled()
        {
            FirstName.Clear();
            LastName.Clear();
            PostalCode.Clear();
            PostalCode2.Clear();
        }

        public void EditNewlyAddedAddressAndVerify(Shop.Automation.Framework.Address add)
        {
            string ele = AddressItem.Text;

            if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.Zip))
                Assert.IsTrue(true, "The address is successfully Added");
            else
                Assert.IsTrue(false, "Address is not Matching");
            WaitForAddressList();
            PersonalAddrList.Click();

            PageExtension.WaitForTimeSpan(2000);
            if (CommonMethods.IsElementDisplayed(EditCostomerLink))
            {
                PageExtension.WaitForElementPresentAndVisible(this, EditShippingAddresLink);
                EditShippingAddresLink.Click();
                ClearFiled();
                add.FillAddress("BR", "Edit", "23455", "", "", "66053", "9020007859", "");
                AddNewAddress(add, true);
                PageExtension.WaitForTimeSpan(3000);
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                WaitForAddressList();
                Assert.IsTrue(true, "Address successfully Edited");
            }
            else
                Assert.IsFalse(true, "No address found");

            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpainToFalse();
            WaitForAddressList();
            var count = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']");
            if (count != null && count.Count > 0)
            {
                foreach (var item in count)
                {
                    ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']")).Text;
                    if (ele.Contains(add.FirstName) && ele.Contains(add.Zip))
                        Assert.IsTrue(true, "The address is successfully Edited");
                    else
                        Assert.IsTrue(false, "Address is not Matching");
                }
            }

        }

        public void MoveToPickupTab()
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PickUpTab));
            PickUpTab.Click();
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            Driver.WaitForDocumentReady();
        }

        public void VerifyPickupAddress(string AddressList, bool isHLPickup = true)
        {

            PickupSearch.SendKeys("Carapicuíba");
            PickupSearch.SendKeys(OpenQA.Selenium.Keys.Space);
            PickupSearchIcon.Click();
            PageExtension.WaitForTimeSpan(2000);
            var val = MandatryFieldCount(AddressList);
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
            PageExtension.WaitForElementPresentAndVisible(this, SelectAddressButton, 5);
            SelectAddressButton.Click();
            PageExtension.WaitForElementPresentAndVisible(this,AddressSearchValue, 5);
            AddressSearchValue.SendKeys("SP");
            PageExtension.WaitForTimeSpan(3000);
            AddressSearchValueElement.Click();
            PageExtension.WaitForTimeSpan(2000);
            ConfrimBtn.Click();
            PageExtension.WaitForTimeSpan(3000);
            WaitSpainToFalse();
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementPresentAndVisible(this, Productlines, 5);
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
    }
    public class DeliveryAddressPersonalPageTestBRMB : DeliveryAddressPersonalPage_BR_MB { }
}
