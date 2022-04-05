using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Shop.Automation.Framework
{
    public static class CommonFindBy
    {
        //Login commons
        public static readonly By LandPageForward = By.ClassName("btnForward");
        public static readonly By LoginUserName = By.Id("Username");
        public static readonly By LoginPassword = By.Id("Password");
        public static readonly By LoginSubmit = By.Id("submit");
        //Shop commons
        public static readonly By BusyIndicator = By.XPath("//div[contains(@class, 'k-loading-image')]");
        public static readonly By BusyIndicatorPOS = By.XPath("//div[contains(@class, 'h-loading-image loader')]");
        public static readonly By LoadOverlay = By.XPath("//div[contains(@class, 'k-overlay')]");
        public static readonly By AccountIcon = By.Id("icon-account");
        //Set Cookie for Compliance
        public static readonly By OnetrustAcceptbtn = By.Id("onetrust-accept-btn-handler");
        public static readonly By OnetrustRejectAllbtn = By.Id("onetrust-reject-all-handler");
        public static readonly By OnetrustSettingbtn = By.Id("onetrust-pc-btn-handler");

        public static readonly By AllowAllbtn = By.Id("accept-recommended-btn-handler");
        public static readonly By AnalyticsCookiesToggel = By.Id("ot-group-id-C0002");
        public static readonly By TargetingandAdvertisingCookiesToggel = By.Id("ot-group-id-C0004");
        public static readonly By PreferenceCookiesToggel = By.Id("ot-group-id-C0007");
        public static readonly By PerformanceCookiesToggel = By.Id("ot-group-id-C0008");
        public static readonly By ConfrimMyChoiceBtn = By.XPath("//*[@class='save-preference-btn-handler onetrust-close-btn-handler']");


        public static readonly By ForLaterbtn = By.XPath("//a[@data-bind='click: onDismissForLater, text: showMeLater.text, visible: showMeLater']");
        //Favorites
        public static readonly By FavoriteIcon = By.ClassName("icon-heart-fl-2");
        public static readonly By FavoriteSelectedIcon = By.XPath("//a[@class='favorite-toggle active']/i[@class='icon-heart-fl-2']");
        public static readonly By FavoriteGrayIcon = By.XPath(".//a[@class='favorite-toggle']/i[@class='icon-heart-fl-2']");
        //Receipt commons
        public static readonly By ViewPos = By.XPath(".//*[@data-role='view']");
        public static readonly By PendingReceipt = By.XPath("//*[contains(@class,' pending')]");
        //Header banner
        public static readonly By CartIcon = By.ClassName("icon-cart-fl-6");
        public static readonly By CartIconCounter = By.ClassName("badge-counter");
        //Order intention bar
        public static readonly By OrderIntentionButton = By.ClassName("edit-type");
        public static readonly By OrderIntentionText = By.XPath("//*[@data-bind='text: OrderIntentionText']");
        public static readonly By SelectAddressButton = By.ClassName("edit-address");
        public static readonly By SelectedAddressInfo = By.XPath("//*[@data-bind='text: DisplayedInfo']");
        //Address commons
        public static readonly By LoadIndicator = By.XPath("//*[@class='k-loading-mask']");
        public static readonly By POSLoadIndicator = By.XPath("//*[@class='h-loading-mask']");
        public static readonly By Agreecheckbox = By.Id("ctl00_Main_myBox_chkAccept");
        public static readonly By AgreeContinue = By.Id("ctl00_Main_myBox_btnAccept");
        public static readonly By SelectCountry = By.XPath("//*[contains(@id,'ctl00_Main_myBox_ddlLocaleSelector')]");
        public static readonly By CDLoadIndicator = By.XPath("//*[@id='customer-direct-choose-customer-address']//*[@class='h-loading-mask']");
        //Config commons
        public static readonly By ConfigClub = By.XPath("//*[@id='MyClub']/div[1]/div[2]/div/div[7]/h6");
        //Page Structure
        public static readonly By PageFooter = By.Id("main-footer");
        public static readonly By PageBanner = By.XPath("//header[@role='banner']");
        //Accept cookies banner
        public static readonly By AcceptCookiesPopup  = By.Id("center-tile-banner-popup");
        public static readonly By AcceptCookiesBtn = By.XPath("//*[@class='optanon-allow-all accept-cookies-button']");



        //Element for admin URL
        public static readonly By AdminLoginButton = By.XPath("//*[contains(@id,'myBox_doLogIn') and @class='forward btnLarge']");
        public static readonly By AdminDsIdField = By.XPath("//*[contains(@id,'myBox_DistributorID') and contains(@name,'DistributorID')]");
        public static readonly By OnlineLoginLnk = By.XPath("//a[contains(@href,'DistributorRelations/MyHLUtils.aspx')]");
        public static readonly By AdminDsIdComboBox = By.Id("ctl00_Main_myBox_ddlDistributorID");
        public static readonly By PopUpPolicyAcceptance = By.XPath("//div[@id = 'ctl00_Main_myBox_popUpForPolicyAcceptance']");
        public static readonly By AgreeCheckBox = By.XPath("//input[@id = 'ctl00_Main_myBox_chkAccept']");
        public static readonly By ContinueButton = By.XPath("//input[@id = 'ctl00_Main_myBox_btnAccept']");
        public static readonly By SelectAdminLocale = By.Id("ctl00_Main_myBox_ddlLocaleSelector");

        //Error Alert Message With Credit Card Payment
        public static readonly By CloseAlertIssueWithCC = By.XPath("(//a[@class='close-sre']/i)[2]");
        public static readonly By AlertIssueMessage = By.XPath("(//div[@id = 'alert-dismiss'])[2]");

        //Cookies message
        public static readonly By CookiesAccepterButon = By.XPath("//button[@class='optanon-allow-all accept-cookies-button']");

        //Cookies message
        public static readonly By Notnow = By.XPath("//*[@id='back']");
    }
}