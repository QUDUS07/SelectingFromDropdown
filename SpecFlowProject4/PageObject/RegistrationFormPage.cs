using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject4.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject4.PageObject
{
    class RegistrationFormPage
    {

        public RegistrationFormPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement FirstName => driver.FindElement(By.XPath("(//input[@type='text'])[1]"));
        IWebElement LastName => driver.FindElement(By.XPath("(//input[@type='text'])[2]"));
        IWebElement Address => driver.FindElement(By.XPath("//*[@ng-model='Adress']"));
        IWebElement Phone => driver.FindElement(By.XPath("//*[@ng-model=\"Phone\"]"));
        IWebElement Gender => driver.FindElement(By.XPath("(//*[@type=\"radio\"])[1]"));
        IWebElement Hobbies => driver.FindElement(By.XPath("(//*[@type=\"checkbox\"])[2]"));
        IWebElement EmaillAddress => driver.FindElement(By.XPath("//*[@ng-model=\"EmailAdress\"]"));
        IWebElement Language => driver.FindElement(By.XPath("//*[@id=\"msdd\"]"));
       
        IWebElement English => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[7]/div/multi-select/div[2]/ul/li[8]"));
        IWebElement Skill => driver.FindElement(By.CssSelector("#Skills"));
        IWebElement Country => driver.FindElement(By.XPath("//*[@aria-expanded=\"false\"]"));
        IWebElement Year => driver.FindElement(By.XPath("(//select[@type='text'])[3]"));
        IWebElement Month => driver.FindElement(By.XPath("(//select[@type='text'])[4]"));
        IWebElement Day => driver.FindElement(By.XPath("(//select[@type='text'])[5]"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@id=\"firstpassword\"]"));
        IWebElement ConfirmPassword => driver.FindElement(By.XPath("//input[@id=\"secondpassword\"]"));
        IWebElement SubmitButton => driver.FindElement(By.XPath("//button[@id=\"submitbtn\"]"));




        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");

        }
        public void EnterFirstName()
        {
            FirstName.SendKeys("Adebayo");
        }
        public void EnterLastName()
        {
            LastName.SendKeys("Hassan");
        }
        public void EnterAdress()
        {
            Address.SendKeys("13 olalubi street mafoluku oshodi lagos, Nigeria");
        }
        public void ClickGender()
        {
            Gender.Click();
        }
        public void EnterPhone()
        {
            Phone.SendKeys("+2347086711700");
        }
        public void ClickHobbies()
        {
            Hobbies.Click();
        }
        public void EnterEmaillAddress()
        {
            EmaillAddress.SendKeys("akindetula123@jmail.com");
        }
        public void ClickLanguage()
        {
            Language.Click();
        }
        public void ClickEnglish()
        {
           English.Click();
        }
        public void SelectFromDropDown()
        {
            SelectElement select = new SelectElement(Skill);
            select.SelectByText("C");
        }
        public void EnterCountry()
        {
            Country.SendKeys("Denmark");
        }
        public void SelectFromYear()
        {
            SelectElement select = new SelectElement(Year);
            select.SelectByText("1994");
        }
        public void SelectFromMonth()
        {
            SelectElement select = new SelectElement(Month);
            select.SelectByText("April");
        }
        public void SelectFromSDay()
        {
            SelectElement select = new SelectElement(Day);
            select.SelectByText("21");
        }
        public void EnterPassword()
        {
            Password.SendKeys("olatunde1234");
        }

        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("olatunde1234");
        }
        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }



    }
}
