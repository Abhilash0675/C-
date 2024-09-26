using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AvesdoTestProject1;

public class Tests
{
  
    public void Setup()
    {
       
    }
 
    [Test]
    public void Login()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://avesdo-qa-contracts.azurewebsites.net/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(1000);
        IWebElement Email = driver.FindElement(By.XPath("//input[@id='Email']"));
        Email.SendKeys("thinkperfect@salesadmin.com");
        IWebElement Password = driver.FindElement(By.XPath("//input[@id='Password']"));
        Password.SendKeys("TP@April14");
        Thread.Sleep(1000);
        IWebElement login = driver.FindElement(By.XPath("//button[@type='submit']"));
        login.Click();
        Thread.Sleep(1000);

        driver.Quit();
    }

   

}