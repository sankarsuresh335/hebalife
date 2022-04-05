using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_BR : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public string AddressPathPricelist => $"{RunSettings.FarmUrl}/Shop/Catalog/Pricelist/Index/{RunSettings.ValidUser.Schema}";

        public string CartPage => $"{RunSettings.FarmUrl}/Shop/Cart/Home/Index/{RunSettings.ValidUser.Schema}";

        [FindsBy(How = How.XPath, Using = "//*[@class='type Personal']")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement ManageAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup-addresses']//*[@id='addressList']/div")]
        public IWebElement PickupPersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@id='locationList']//div[@class='address-item'])[1]")]
        public IWebElement PickupFirstAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement MileDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-showmap']")]
        public IWebElement PickupViewonMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']/i[@class='icon-magnifier-fl-1']")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Gerenciar endereços')]")]
        public IWebElement ManageAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='notification-success']")]
        public IWebElement AddressupdatesuccessfullMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='IsPrimaryContact' and @type='checkbox' and @value='1']")]
        public IWebElement CheckBoxPrimary { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='tag primary' and contains(text(),'Principal')]")]
        public IWebElement PricipalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[1]/div/div[contains(text(),'Principal')]")]
        public IWebElement PricipalTagFirstPlace { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-continue']")]
        public IWebElement btnConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping-list']//*[@id='add-customer']")]
        public IWebElement CustomerAddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@id='addressList']//div[@class='tag primary'])[1]")]
        public IWebElement PrimaryTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-add-new-address']")]
        public IWebElement ManageAddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Nome é obrigatório')]")]
        public IWebElement FirstNameErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickupDistanceDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName' and contains(text(),' Sobrenome é obrigatório')]")]
        public IWebElement LastNameErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip' and contains(text(),' CEP é obrigatório')]")]
        public IWebElement CEP1ErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'CEP não encontrado')]")]
        public IWebElement CEP1CodeNotFoundErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement SelectAddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-address-edit'])[1]")]
        public IWebElement ManageAddressEditValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Zip2' and contains(text(),' CEP é obrigatório')]")]
        public IWebElement CEP2ErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='StreetNumber' and contains(text(),' Número é obrigatório')]")]
        public IWebElement StreetNumberErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='AreaCode' and contains(text(),' Código de área é obrigatório')]")]
        public IWebElement AreaCodeErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Telefone é obrigatório')]")]
        public IWebElement PhoneNumberErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Desculpe, nenhum endereço salvo corresponde à sua busca. Por favor, tente novamente.')]")]
        public IWebElement SearchWarningMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),' CEP inválido')])[1]")]
        public IWebElement InvalidCep1ErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),' CEP inválido')])[2]")]
        public IWebElement InvalidCep2ErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),'Formato do telefone inválido. Só números.')]")]
        public IWebElement InvalidPhoneNumberErrorMSg { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@data-bind='visible: HasAddresses']/descendant::input[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement ManageAddressSearchField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clean-pickup-search']")]
        public IWebElement SearchFieldCloseBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//form[@id='new-address-form'])[1]/descendant::input[@id='Club']")]
        public IWebElement ClubRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form']//*[@id='FirstName']")]
        public IWebElement CustomerPickupFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form']//*[@id='LastName']")]
        public IWebElement CustomerPickupLastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form']//*[@id='Zip']")]
        public IWebElement CustomerPickupZip1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form']//*[@id='Zip2']")]
        public IWebElement CustomerPickupZip2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form']//*[@id='PhoneNumber']")]
        public IWebElement CustomerPickupPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form']//*[@id='btn-save-new-address']")]
        public IWebElement CustomerPickupSaveBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form']//*[@id='AreaCode']")]
        public IWebElement CustomerPickupAreaCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form']//*[@id='StreetNumber']")]
        public IWebElement CustomerPickupStreetNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Pessoal')]")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='type Nutrition Club']")]
        public IWebElement ManageAddressNutritionClubTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip']")]
        public IWebElement CEP1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Zip2']")]
        public IWebElement CEP2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Street']")]
        public IWebElement Street { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Neighbourhood']")]
        public IWebElement Neighbourhood { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='StreetNumber']")]
        public IWebElement StreetNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='City']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='State']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Additional']")]
        public IWebElement Complement { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='AreaCode']")]
        public IWebElement Areacode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PhoneNumber']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFieldPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']")]
        public IWebElement PickUPDdnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//h4[contains(text(),'Desculpe, nenhum local de retirada foi encontrado. Por favor, amplie raio de busca.')]")]
        public IWebElement PickSearchNoAddressfoundMSG { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='locationList']/div")]
        public IWebElement PickUPList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement PickUPSearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']/option[contains(text(),'8 km de distância')]")]
        public IWebElement MilesDropdown8Kms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']/option[contains(text(),'16 km de distância')]")]
        public IWebElement MilesDropdown16Kms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']/option[contains(text(),'24 km de distância')]")]
        public IWebElement MilesDropdown24Kms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']/option[contains(text(),'32 km de distância')]")]
        public IWebElement MilesDropdown32Kms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']/option[contains(text(),'100 km de distância')]")]
        public IWebElement MilesDropdown100Kms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='select-miles-away']/option[contains(text(),'Todos')]")]
        public IWebElement MilesDropdownAllKms { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pickupSearch']")]
        public IWebElement SearchFiledPickup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-clean-pickup-search'])[2]")]
        public IWebElement PickupSearchCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-pickup-filter']")]
        public IWebElement PickupSearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']")]
        public IWebElement AddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div[2]")]
        public IWebElement AddressItem2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='icon-add-fl-2'])[1]")]
        public IWebElement FirstSKU { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn-add-cart']")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='edit-address']")]
        public IWebElement ChangeAddressLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='fadeIn: MemberStateDifferent']")]
        public IWebElement Different_State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='visible:ShowOnlyHerbalife']//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='pickup-addresses']//*[@id='address-search-value']")]
        public IWebElement ShippingSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='choose-personal-address']//*[@class='btn-continue']")]
        public IWebElement Confirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Ver locais')]")]
        public IWebElement PickupViewLocations { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-info']")]
        public IWebElement AddressValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-duplicated-contact']//a[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement DuplicatelistCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-duplicated-contact']//div[@class='address-info']")]
        public IWebElement DuplicatePopupSelectAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='modal-duplicated-contact']")]
        public IWebElement DuplicatePopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='modal-content']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(@data-bind,'clearCart')]")]
        public IWebElement lnkClearSelectedItems_PVC { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-bind='html: DisplayedInfo' and contains(text(), 'Por favor, selecciona la dirección')]")]
        public IWebElement ShoppersAddr_Empty { get; set; }

        [FindsBy(How = How.XPath, Using = "//form[@class='customer-form hl-form']//div[@class='read-only break-wrap']")]
        public IWebElement AddressItem_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-clear-cart']")]
        public IWebElement ClearCartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@id='btn-go-checkout'])[2]")]
        public IWebElement GOToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='address-info'])[last() - 1]/strong")]
        public IWebElement FirstAddressFullName { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='address-info'])[1]/parent::div")]
        public IWebElement FirstShippingSavedAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='text: shippingSelectedAddress.DisplayName']")]
        public IWebElement DisplayName { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-bind,'AddressSavedCorrectly')]")]
        public IWebElement AddressSavedSuccessfullyNotification { get; set; }

        public IReadOnlyList<IWebElement> Increase_QtyList => Driver.FindElements(By.XPath("//a[contains(@data-bind,'increaseQty')]/i"));

        public ReadOnlyCollection<IWebElement> webelementsColl;

        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
        }

        //Validates Shopper Profile for Pick Locations
        public void ValidateshopperprofilePickUP(string Streetvalue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) )
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public IList<IWebElement> verifyMileDropDown()
        {
            SelectElement oSelect = new SelectElement(MileDropdown);
            IList<IWebElement> elementCount = oSelect.Options;
            return elementCount;
        }

        //Selects Address in Pickuptab
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

        public void WaitForAddressList()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']");
            while (Iweb.Count < 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']");
            }
        }

        //Checks the Text field Count of the particular Webelement
        public void TextFieldCount(IWebElement ele, int Count, string Actvalue)
        {
            ele.SendKeys(Actvalue);
            int ActualCount = ele.InputBoxValue().Length;
            Assert.AreEqual(ActualCount, Count);
        }

        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        public Framework.Address AddAddress(Framework.Address add, bool IsNutritionClub = false, bool IsCancel = false, bool IsPrimary = false)
        {
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            FirstName.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(1000);
            LastName.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            CEP1.SendKeys(add.Zip);
            PageExtension.WaitForTimeSpan(1000);
            CEP2.SendKeys(add.CEP);
            PageExtension.WaitForTimeSpan(1000);
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            StreetNumber.SendKeys(add.StreetNumber);
            PageExtension.WaitForTimeSpan(1000);
            Complement.SendKeys(add.Complement);
            PageExtension.WaitForTimeSpan(1000);
            Areacode.SendKeys(add.AreaCode);
            ValidateAttributeContains(add.Zip, add.Street2, add.StreetNumber);
            PageExtension.WaitForTimeSpan(1000);
            PhoneNumber.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            if (IsPrimary)
                CheckBoxPrimary.Click();
            
            if (IsNutritionClub)
                ClubRdoBtn.Click();

            if (IsCancel)
                ShippingAddrCancel.Click();
            else
                ShippingAddrSave.Click();
            WaitSpinToFalse();
            Driver.WaitForDocumentReady();
            WaitForAddressList();
            return add;
        }

        public void SearchValidAddress(Framework.Address add, bool isValidaddress = false)
        {
            bool isInValidaddressFound = true;
            var cus = MandatryFieldCount("//*[@class='shipping-addresses']//div[@class='address-item']");
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
                        Assert.IsTrue(CommonMethods.IsElementDisplayed(EditCostomerLink));
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
                            LastName.Clear();
                            LastName.SendKeys(add.LastName);
                            CEP1.Clear();
                            CEP1.SendKeys(add.Zip);
                            CEP2.Clear();
                            CEP2.SendKeys(add.CEP);
                            WaitSpinToFalse();
                            StreetNumber.Clear();
                            StreetNumber.SendKeys(add.StreetNumber);
                            PageExtension.WaitForTimeSpan(2000);
                            ValidateAttributeContains(add.Zip, add.Street2, add.StreetNumber);
                            PageExtension.WaitForTimeSpan(3000);
                            Complement.Clear();
                            Complement.SendKeys(add.Complement);
                            Areacode.Clear();
                            Areacode.SendKeys(add.AreaCode);
                            PhoneNumber.Clear();
                            PhoneNumber.SendKeys(add.PhoneNumber);
                            PhoneNumber.SendKeys(Keys.Tab);
                            ShippingAddrSave.Click();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            Driver.WaitForDocumentReady();
                            PageExtension.WaitForTimeSpan(3000);
                            WaitSpinToFalse();
                            WaitForAddressList();
                            ShiptothisBut.Click();
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

        public Framework.Address SearchAndEditAddress(Framework.Address add, bool IsClub = false)
        {
            //Search Address
            PageExtension.WaitForElementTextToBeDisplayed(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();

            //Select address from list and Edit address
            var count1 = InitializeReadOnlyCollection("//*[@id='addressList']//div[@class='address-item']/div");
            if (count1 != null && count1.Count > 0)
            {
                foreach (var item in count1)
                {
                    string ele = item.FindElement(By.XPath("//*[@id='addressList']//div[@class='address-item']/div")).Text;

                    if (ele.Contains(add.FirstName) && ele.Contains(add.Street) && ele.Contains(add.Zip))
                        Assert.IsTrue(true, "The address is successfully Added");
                    else
                        Assert.IsTrue(false, "Address is not Matching");

                    string ele1 = CommonMethods.FindElement(item, "//*[@id='addressList']//div[@class='address-item']//span[@class='type Personal']").Text;
                    if (ele1 != null)
                        Assert.IsTrue(true);
                    else
                        Assert.IsFalse(true, "No Personal tag found");
                    PageExtension.WaitForTimeSpan(3000);
                    WaitForAddressList();

                    PersonalAddrList.Click();
                    PageExtension.WaitForTimeSpan(3000);

                    add.ClearAddress();
                    PageExtension.WaitForTimeSpan(1000);
                    add.FillAddressforSAMCAM("FN", "Edit", "R Roberto Cunha", "EstÃ¢ncia Piratininga", "Suzano", "SP", "08633", "545465465", "54545454", "341", "47", "51854848487");
                    PageExtension.WaitForTimeSpan(2000);
                    if (CommonMethods.IsElementDisplayed(EditCostomerLink))
                    {
                        PageExtension.WaitForTimeSpan(2000);
                        PageExtension.WaitForElementPresentAndVisible(this, EditCostomerLink);
                        WaitSpinToFalse();
                        PageExtension.WaitForTimeSpan(2000);
                        EditCostomerLink.Click();
                        PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                        FirstName.Clear();
                        FirstName.SendKeys(add.FirstName);
                        LastName.Clear();
                        LastName.SendKeys(add.LastName);
                        CEP1.Clear();
                        CEP1.SendKeys(add.Zip);
                        CEP2.Clear();
                        CEP2.SendKeys(add.CEP);
                        WaitSpinToFalse();
                        ValidateAttributeContains(add.Zip, add.Street2, add.StreetNumber);
                        PageExtension.WaitForTimeSpan(3000);
                        StreetNumber.Clear();
                        StreetNumber.SendKeys(add.StreetNumber);
                        Complement.Clear();
                        Complement.SendKeys(add.Complement);
                        Areacode.Clear();
                        Areacode.SendKeys(add.AreaCode);
                        PhoneNumber.Clear();
                        PhoneNumber.SendKeys(add.PhoneNumber);
                        PhoneNumber.SendKeys(Keys.Tab);
                        if (IsClub)
                        {
                            ClubRdoBtn.Click();
                            ShippingAddrSave.Click();
                        }                            
                        else
                        ShippingAddrSave.Click();
                        PageExtension.WaitForTimeSpan(3000);
                        Driver.WaitForDocumentReady();
                        PageExtension.WaitForElementClicklable(this, SearchFieldCloseBtn, 40);
                        SearchFieldCloseBtn.Click();
                        WaitForAddressList();
                        Assert.IsTrue(true, "Address successfully Edited");
                        break;
                    }
                    else
                        Assert.IsFalse(true, "No address found");
                }
            }
            return add;
        }
        public void ValidateAttributeContains(string Streetvalue, string Neighbourhoodvalue, string StreetNumbervalue)
        {
            string value = CEP1.InputBoxValue();
            string value1 = Neighbourhood.InputBoxValue();
            string value3 = StreetNumber.InputBoxValue();
            if (value.Contains(Streetvalue) && value1.Contains(Neighbourhoodvalue) && value3.Contains(StreetNumbervalue))
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

        public void SelectMilesOption(string option)
        {
            PickUPDdnSearch.SelectDropDownOption(option);
        }

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.City));
        }

        public void SearchAddress(string FirstName)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.Clear();
            SearchFieldPersonal.SendKeys(FirstName);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            WaitForAddressList();
        }

       
           
    }


    public class DeliveryAddressPersonalPageTestBR : DeliveryAddressPersonalPage_BR { }
}