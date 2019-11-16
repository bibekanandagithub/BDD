using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD.Calculator
{
    [Binding]
    public sealed class Def_calculator
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            Console.WriteLine("value is {0}",number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            //TODO: implement act (action) logic

            Console.WriteLine("Pressed Add button");
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            Console.WriteLine("Result is {0}",result);
        }

        [When(@"i fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            var result = table.CreateDynamicSet();
            Console.WriteLine("---------");
            foreach (var a in result)
            {
                Console.WriteLine(a.Name);
                Console.WriteLine(a.Age);
                Console.WriteLine(a.Phone);
                Console.WriteLine(a.Email);

            }

        }

    }
}
