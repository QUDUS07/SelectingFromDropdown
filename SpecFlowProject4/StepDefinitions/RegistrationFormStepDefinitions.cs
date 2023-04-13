using SpecFlowProject4.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject4.StepDefinitions
{
    [Binding]
    public class RegistrationFormStepDefinitions
    {

        RegistrationFormPage registrationFormPage;
        public RegistrationFormStepDefinitions() 
        {
            registrationFormPage= new RegistrationFormPage();
        }







        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            registrationFormPage.NavigateToWebsite();
        }

        [Given(@"I enter First name")]
        public void GivenIEnterFirstName()
        {
            registrationFormPage.EnterFirstName();
        }

        [Given(@"I enter Last name")]
        public void GivenIEnterLastName()
        {
            registrationFormPage.EnterLastName();
        }

        [Given(@"I enter address")]
        public void GivenIEnterAddress()
        {
            registrationFormPage.EnterAdress();
        }

        [Given(@"I enter Email address")]
        public void GivenIEnterEmailAddress()
        {
            registrationFormPage.EnterEmaillAddress();
        }

        [Given(@"I choose file to upload photo")]
        public void GivenIChooseFileToUploadPhoto()
        {
            throw new PendingStepException();
        }

        [Given(@"I enter Phone number")]
        public void GivenIEnterPhoneNumber()
        {
            registrationFormPage.EnterPhone();
        }

        [Given(@"I select my Gender")]
        public void GivenISelectMyGender()
        {
            registrationFormPage.ClickGender();
        }

        [Given(@"I select my Hobbie")]
        public void GivenISelectMyHobbie()
        {
            registrationFormPage.ClickHobbies();
        }

        [Given(@"I select my Language")]
        public void GivenISelectMyLanguage()
        {
            registrationFormPage.ClickLanguage();
            Thread.Sleep(5000);
        }
        [Given(@"I select English")]
        public void GivenISelectEnglish()
        {
            registrationFormPage.ClickEnglish();
            Thread.Sleep(5000);
        }


        [Given(@"I select my Skills")]
        public void GivenISelectMySkills()
        {
            registrationFormPage.SelectFromDropDown();
        }

        [Given(@"I select my Country")]
        public void GivenISelectMyCountry()
        {
            registrationFormPage.EnterCountry();
        }

        [Given(@"I select my Day of birth")]
        public void GivenISelectMyDayOfBirth()
        {
            registrationFormPage.SelectFromSDay();
        }

        [Given(@"I select my Month of birth")]
        public void GivenISelectMyMonthOfBirth()
        {
            registrationFormPage.SelectFromMonth();
        }

        [Given(@"I select my yeat of birth")]
        public void GivenISelectMyYeatOfBirth()
        {
            registrationFormPage.SelectFromYear();
        }


        [Given(@"I enter Password")]
        public void GivenIEnterPassword()
        {
            registrationFormPage.EnterPassword();
        }

        [Given(@"I confirm Password")]
        public void GivenIConfirmPassword()
        {
            registrationFormPage.EnterConfirmPassword();
        }

        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            registrationFormPage.ClickSubmitButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
