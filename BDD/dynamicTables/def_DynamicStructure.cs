using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD.dynamicTables
{
    [Binding]
    public sealed class def_DynamicStructure
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [When(@"i have new data i used  dynamic structure in order print")]
        public void WhenIHaveNewDataIUsedDynamicStructureInOrderPrint(Table table)
        {
            var Details = table.CreateDynamicSet();
            foreach(var emp in Details)
            {
                Console.WriteLine("Name is {0}",emp.Name);
                Console.WriteLine("Name is {0}", emp.Age);
                Console.WriteLine("Name is {0}", emp.Phone);
                Console.WriteLine("Name is {0}", emp.Email);

            }

        }

    }
}
