// open chrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch turnup portal
driver.Navigate().GoToUrl(" http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);

// identify username textbox amd enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// check if the user has login sucessfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully, test passed.");
}
else
{
    Console.WriteLine("login failed, test failed");

}

// ----->> Create a new material record------>>>>


// Click on administration tab
Thread.Sleep(1500);
IWebElement administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationtab.Click();


// Select time and material from drop down list
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();
Thread.Sleep(1500);


// Click on create new
IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createnewbutton.Click();
Thread.Sleep(1500);

// Input code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("Verma");

// Input Description

IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("harry");
Thread.Sleep(1000);

// making price tag interactable
IWebElement pricetag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
pricetag.Click();


// Input price 

IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("15");
Thread.Sleep(1000);

// Click on save button
IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
savebutton.Click();


// Click to load last page 
Thread.Sleep(5000);
IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
gotolastpage.Click();
Thread.Sleep(3000);

// Check if material record created sucessfully

IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
if (newCode.Text == "Verma")
{
    Console.WriteLine("New material record created successfully");
}
else
{ 
    Console.WriteLine("New materil record hasn't been created");
}
