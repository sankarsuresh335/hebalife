using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shop.Automation.Framework;
using System;
using System.Collections.ObjectModel;
using System.Linq;


namespace Shop.Automation.Pages.Address
{
    public class DeliveryAddressPersonalPage_HN_MB : Page
    {
        public string AddressPath => $"{RunSettings.FarmUrl}{RunSettings.Locale}/Shop/Address/DeliveryAddress/personal/{RunSettings.ValidUser.Schema}";

        public ReadOnlyCollection<IWebElement> webelementsColl;

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']/div")]
        public IWebElement PersonalAddrList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shipping selected']")]
        public IWebElement ShippingTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='pickup']")]
        public IWebElement PickUpTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='PickUpLocationList']/h4")]
        public IWebElement PickUpTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']")]
        public IWebElement AddAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-pickup-delivery']")]
        public IWebElement UseselectedAddressBtnPickUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-open-address-form']/following-sibling::a")]
        public IWebElement ManageAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoAddressSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='address-info'])[1]")]
        public IWebElement AddressListValue1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Direcciones guardadas')]")]
        public IWebElement ManageAddressPageTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address-search-value']")]
        public IWebElement SearchFieldPersonal { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contact-address-form']//*[@aria-owns='County_listbox']")]
        public IWebElement CustomerCounty { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='close-reveal-modal btn-delete']")]
        public IWebElement DeleteConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='addressList']//div[@class='address-info']")]
        public IWebElement GetAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']//*[@aria-owns='County_listbox']")]
        public IWebElement County { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='click: ClearPersonalListSearchBox']")]
        public IWebElement PersonalSearchclose { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='projectID']")]
        public IWebElement ProjectID { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@data-bind='invisible: ShippingAddressesFound']")]
        public IWebElement NoPersonalAddressMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='new-address-form']")]
        public IWebElement NewAddrressFORM { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Customer' and @value='2']")]
        public IWebElement CustomerRdoBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Personal')]")]
        public IWebElement PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),'Cliente')])[2]")]
        public IWebElement CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Personal')]")]
        public IWebElement AddAddress_PersonalTag { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[contains(text(),'Cliente')])[2]")]
        public IWebElement AddAddress_CustomerTag { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-form hl-form']")]
        public IWebElement GetAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-default-address-changed'])[2]")]
        public IWebElement HrblUseSelectedAddrBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-cancel-new-address']")]
        public IWebElement ShippingAddrCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-save-new-address']")]
        public IWebElement ShippingAddrSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='shopping-as personal']//*[@class='edit-address']")]
        public IWebElement ShoppersAddr { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='edit-address opp-side']")]
        public IWebElement EditCostomerLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='shipping-list']")]
        public IWebElement Duplicatelist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-continue']")]
        public IWebElement Overwrite { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='modal-duplicated-contact']//*[@class='btn-cancel close-reveal-modal opp-side']")]
        public IWebElement Cancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='optanon-allow-all accept-cookies-button']")]
        public IWebElement AcceptCookies { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='customer-ship']//*[@id='btn-default-address-changed']")]
        public IWebElement ShiptothisBut { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='button']")]
        public IWebElement ProjectPopup { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='userNamePrj']")]
        public IWebElement ProjectUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Primer Nombre: ')]/span")]
        public IWebElement FirstnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Apellido:')]/span")]
        public IWebElement LastnameAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Distrito:')]/span")]
        public IWebElement CityAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Departamento:')]/span")]
        public IWebElement StateAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Dirección de la dirección 1:')]/span")]
        public IWebElement StreetAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Primer Nombre: ')]/span")]
        public IWebElement PhoneNumberAsterick { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btn-address-delete' and @class='btn-cc-delete']")]
        public IWebElement Delete { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='FirstName']")]
        public IWebElement FirstNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='LastName']")]
        public IWebElement LastNameTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns='State_listbox' and @class='k-widget k-dropdown k-header']")]
        public IWebElement State { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns='City_listbox' and @class='k-widget k-dropdown k-header']")]
        public IWebElement City { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Street']")]
        public IWebElement StreetTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Zip']")]
        public IWebElement ZIPTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='PhoneNumber']")]
        public IWebElement PhoneTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Por favor complete el primer nombre.')]")]
        public IWebElement FirstnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName' and contains(text(),' Por favor ingrese el apellido.')]")]
        public IWebElement LastnameerrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),' Por favor introduzca el valor de la dirección.')]")]
        public IWebElement StreetErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='State' and contains(text(),' Por favor seleccione el departamento.')]")]
        public IWebElement StateErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='City' and contains(text(),' Por favor seleccione el distrito.')]")]
        public IWebElement CityErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Por favor introduzca el número de teléfono en el formato.')]")]
        public IWebElement PhoneNumberErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='FirstName' and contains(text(),' Primer nombre invalido')]")]
        public IWebElement FirstNameInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='LastName' and contains(text(),' Apellido invalido.')]")]
        public IWebElement LastNameInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='Street' and contains(text(),' Dirección invalida')]")]
        public IWebElement StreetInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'La combinación de nombre y apellido no puede exceder los 40 caracteres.')]")]
        public IWebElement FirstnameMaxCharErrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@data-for='PhoneNumber' and contains(text(),' Numero de telefono invalido')]")]
        public IWebElement PhoneNumberInvaliderrorMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='savedAddressesList']")]
        public IWebElement SavedAddressList { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='edit-address opp-side']")]
        public IWebElement EditInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-bind='invisible: DisplayShippingForm']//p")]
        public IWebElement ShippingConfirmationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='MyHerbalifelocationList']/div[@class='address-item']")]
        public IWebElement pickuplist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='address-item']")]
        public IWebElement Shippinglist { get; set; }

        //pricelist page
        [FindsBy(How = How.XPath, Using = "//*[@id='product-lines']/div[1]//input")]
        public IWebElement add_qty { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='price-list-section']//a[@class='btn-add-cart']")]
        public IWebElement buyNow { get; set; }

        [FindsBy(How = How.Id, Using = "btn-clear-cart")]
        public IWebElement clearCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@wire-model='CartCountViewModel']")]
        public IWebElement cartIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@wire-model='CartCountViewModel']/span")]
        public IWebElement cartCount { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@id='btn-go-checkout'])[2]")]
        public IWebElement ProceedToOrder { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='invoice-option-list']//span[contains(text(), 'Enviar Factura con el Paquete')]")]
        public IWebElement InvoiceOptionPkg { get; set; }


        private static Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        /// Below Method is used for adding Customer/Personal data(Pass True if its Customer data)
        public Framework.Address AddAddress(Framework.Address add, bool IsCustomer = false, bool iscancelled = false)
        {
            string firsrtname = "DJ";
            add.FirstName = firsrtname+RandomString(6);
            Driver.WaitForDocumentReady();
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            PageExtension.WaitForElementPresentAndVisible(this, PersonalAddrList, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(ShippingTab));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(PersonalAddrList));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(AddAddressBtn));
            //Add address
           // PageExtension.ScrollIntoView(this, AddAddressBtn);
            PageExtension.WaitForTimeSpan(1000);
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, FirstNameTextBox);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameTextBox));
            //Shop.Automation.Framework.Address add = CreateObject();
            FirstNameTextBox.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastNameTextBox.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetTextBox.SendKeys(add.Street);
            PageExtension.ScrollElementIntoMiddle(this, State);
            PageExtension.WaitForTimeSpan(2000);            
            StateSelection(add.State);
            PageExtension.WaitForTimeSpan(2000);
            CitySelection(add.City);
            //SelectOption(add.State,add.City);
            PageExtension.WaitForTimeSpan(2000);
            PhoneTextBox.SendKeys(add.PhoneNumber);
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


        public void CreateDuplicateAddress(Framework.Address add)
        {
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, FirstNameTextBox);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameTextBox));
            FirstNameTextBox.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastNameTextBox.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetTextBox.SendKeys(add.Street);
            PageExtension.ScrollElementIntoMiddle(this, State);
            PageExtension.WaitForTimeSpan(2000);
            StateSelection(add.State);
            PageExtension.WaitForTimeSpan(2000);
            CitySelection(add.City);
            //SelectOption(add.State,add.City);
            PageExtension.WaitForTimeSpan(2000);
            PhoneTextBox.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            WaitSpinToFalse();
            
        }

        public void DuplicateAddress_Name_Phone(Framework.Address add)
        {
            AddAddressBtn.Click();
            PageExtension.WaitForTimeSpan(2000);
            PageExtension.WaitForElementPresentAndVisible(this, FirstNameTextBox);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(FirstNameTextBox));
            FirstNameTextBox.SendKeys(add.FirstName);
            PageExtension.WaitForTimeSpan(2000);
            LastNameTextBox.SendKeys(add.LastName);
            PageExtension.WaitForTimeSpan(1000);
            StreetTextBox.SendKeys("street name");
            PageExtension.ScrollElementIntoMiddle(this, State);
            PageExtension.WaitForTimeSpan(2000);
            StateSelection("CORTES");
            PageExtension.WaitForTimeSpan(2000);
            CitySelection("OMOA");
            //SelectOption(add.State,add.City);
            PageExtension.WaitForTimeSpan(2000);
            PhoneTextBox.SendKeys(add.PhoneNumber);
            PageExtension.WaitForTimeSpan(1000);
            ShippingAddrSave.Click();
            PageExtension.WaitForTimeSpan(3000);
            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
            WaitSpinToFalse();

        }



        public void SearchAddress(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, SearchFieldPersonal);
            SearchFieldPersonal.SendKeys(add.FirstName);
            WaitSpinToFalse();
            WaitForAddressList();
            ValidateAttributeContains(add);
        }

        
        public Framework.Address EditAddress(Framework.Address add, bool IsCustomer = false, bool IsCancelled = false)
        {
            
            WaitForAddressList();
            PersonalAddrList.Click();
            //add.ClearAddress();
            //add.FillAddressForEMEA("DJHN", "Akash", "Street", "", "OMOA", "", "1234577678", "", "CORTES");
            if (CommonMethods.IsElementDisplayed(EditInformation))
            {
                PageExtension.WaitForTimeSpan(1000);
                PageExtension.WaitForElementPresentAndVisible(this, EditInformation);
                EditInformation.Click();
                PageExtension.WaitForElementPresentAndVisible(this, ShippingAddrSave);
                FirstNameTextBox.Clear();
                string firsrtname = "DJ";
                add.FirstName = firsrtname + RandomString(6);
                FirstNameTextBox.SendKeys(add.FirstName);
                PageExtension.WaitForTimeSpan(1000);
                LastNameTextBox.Clear();
                LastNameTextBox.SendKeys(add.LastName);
                PageExtension.WaitForTimeSpan(1000);
                StreetTextBox.Clear();
                StreetTextBox.SendKeys(add.Street);
                PageExtension.WaitForTimeSpan(1000);
                StateSelection(add.State);
                WaitSpinToFalse();
                CitySelection(add.City);
                PageExtension.WaitForTimeSpan(2000);
                PhoneTextBox.Clear();
                PhoneTextBox.SendKeys(add.PhoneNumber);
                PageExtension.WaitForTimeSpan(1000);
                if (IsCustomer)
                    CustomerRdoBtn.Click();
                PageExtension.WaitForTimeSpan(2000);
                WaitSpinToFalse();
                if (IsCancelled)
                    ShippingAddrCancel.Click();
                else
                    ShippingAddrSave.Click();
                //ShippingAddrSave.Click();
                PageExtension.WaitForTimeSpan(3000);
                PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator, 30);
                WaitForAddressList();
                Assert.IsTrue(true, "Address successfully Edited");
            }
            else
                Assert.IsFalse(true, "No address found");
            return add;
        }


        public void ValidateAttributeContains(Framework.Address add)
        {
            GetAddressList.Click();
            WaitSpinToFalse();
            string value = GetAddAddress.Text;
            if (value.Contains(add.FirstName) && value.Contains(add.LastName) && value.Contains(add.Street) && value.Contains(add.City) && value.Contains(add.PhoneNumber))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        //Shopper Profile Validation for Shipping
        public void Validateshopperprofile(Framework.Address add)
        {
            string ShopperProfileText = ShoppersAddr.Text;
            Assert.IsTrue(ShopperProfileText.Contains(add.FirstName + " ") && ShopperProfileText.Contains(add.LastName));
            Assert.IsTrue(ShopperProfileText.Contains(add.Street));
            Assert.IsTrue(ShopperProfileText.Contains(add.State));
        }

        public void ValidateshopperprofilePickUP(string Streetvalue, string CityValue)
        {
            string value = ShoppersAddr.GetAttribute("innerHTML");
            if (value.Contains(Streetvalue) && value.Contains(CityValue))
                Assert.IsTrue(true, "The Value displayed Correctly");
            else
                Assert.IsTrue(false, "The Value not set Correctly");
        }

        public void VerifyDuplicatePopUp(Framework.Address add)
        {
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Cancel.Click();
            PageExtension.WaitForTimeSpan(2000);
            WaitSpinToFalse();
            ShippingAddrSave.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Duplicatelist, 5);
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Duplicatelist));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Overwrite));
            Assert.IsTrue(CommonMethods.IsElementDisplayed(Cancel));
            Duplicatelist.Click();
            PageExtension.WaitForElementPresentAndVisible(this, Overwrite, 5);
            Assert.IsTrue(CommonMethods.IsElementEnabled(Overwrite));
            Overwrite.Click();
            WaitSpinToFalse();
            PageExtension.WaitForTimeSpan(2000);
            //ManageAddressBtn.Click();
            //WaitSpinToFalse();
            //PageExtension.WaitForTimeSpan(2000);
            //SearchFieldPersonal.SendKeys(add.FirstName);
            //WaitSpinToFalse();
            //PageExtension.WaitForTimeSpan(2000);
            //var count = InitializeReadOnlyCollection("//*[@id='savedAddressesList']/li");
            //if (count.Count > 0)
            //{

            //    foreach (var item in count)
            //    {

            //        if (CommonMethods.IsElementDisplayed(Delete))
            //        {
            //            PageExtension.WaitForElementPresentAndVisible(this, Delete);
            //            Delete.Click();
            //            PageExtension.WaitForTimeSpan(3000);
            //            PageExtension.WaitForElementPresentAndVisible(this, DeleteConfirm);
            //            DeleteConfirm.Click();
            //            PageExtension.WaitForTimeSpan(2000);
            //            PageExtension.WaitForElementGone(this, CommonFindBy.LoadIndicator);
            //            Driver.WaitForDocumentReady();
            //            PageExtension.WaitForElementPresentAndVisible(this, SavedAddressList);
            //            Assert.IsTrue(true);
            //            break;
            //        }
            //        Assert.IsFalse(false, "No address found");
            //    }
            //}
            //else
            //    Assert.IsFalse(true, "No Customer address found");
        }
        public void WaitSpinToFalse()
        {
            var Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            while (Iweb.Count > 0)
            {
                Iweb = InitializeReadOnlyCollection("//*[@class='k-loading-mask']").ToList();
            }
        }

        public void SelectAddress()
        {
            PageExtension.WaitForElementClicklable(this, pickuplist);
            var val = MandatryFieldCount("//*[@id='MyHerbalifelocationList']/div[@class='address-item']");
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
        public void StateSelection(string StateName)
        {
            State.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Statelist = InitializeReadOnlyCollection("//*[@id='State-list']//*[@id='State_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Statelist.FirstOrDefault(i => i.Text.Contains(StateName)).Click();
        }
        public void CitySelection(string CityName)
        {
            City.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Citylist = InitializeReadOnlyCollection("//*[@id='City-list']//*[@id='City_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Citylist.FirstOrDefault(i => i.Text.Contains(CityName)).Click();
        }

        public void CountySelection(string CountyName)
        {
            County.Click();
            PageExtension.WaitForTimeSpan(2000);
            var Countylist = InitializeReadOnlyCollection("//*[@id='County-list']//*[@id='County_listbox']/li").ToList();
            PageExtension.WaitForTimeSpan(2000);
            Countylist.FirstOrDefault(i => i.Text.Contains(CountyName)).Click();
        }

        /*public void CitySelection(string CityName)
        {
            City.SelectDropDownOption(CityName);

        }

        public void StateSelection(string StateName)
        {
            State.SelectDropDownOption(StateName);

        }*/

        public ReadOnlyCollection<IWebElement> InitializeReadOnlyCollection(string xPath)
        {
            webelementsColl = Driver.FindElements(By.XPath(xPath));
            return webelementsColl;
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


    }
    public class DeliveryAddressPersonalPageTestHNMB : DeliveryAddressPersonalPage_HN_MB { }
}
