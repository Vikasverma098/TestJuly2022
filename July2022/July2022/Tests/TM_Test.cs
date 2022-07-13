

// open chrome browser
IWebDriver driver = new ChromeDriver();

// Login page object initilization and definition
LoginPage loginpageObj = new LoginPage();
loginpageObj.LoginActions(driver);

// Home page object initilization and definition 
HomePage homepageObj = new HomePage();
homepageObj.GoToTMPage(driver);

// TM page object initilization and definition
TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);

// Edit TM
tmPageObj.EditTM(driver);

// Delete TM
tmPageObj.DeleteTM(driver);