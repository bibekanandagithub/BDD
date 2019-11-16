using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD.Outline
{
    [Binding]
    public sealed class ExampleOutlineDef
    {
        [When(@"i even important  details in of  (.*), (.*) and (.*)")]
        public void WhenIEvenImportantDetailsInOfAnd(string p0, string p1, string p2)
        {
            Console.WriteLine($"{p0} and another is {p1} and other is {p2}");
        }
    }
}
