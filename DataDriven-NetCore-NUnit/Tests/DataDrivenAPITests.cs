using DataDriven_NetCore_NUnit.Helpers;
using NUnit.Framework;

namespace DataDriven_NetCore_NUnit
{
    public class DataDrivenAPITests
    {
    

        [TestCaseSource(typeof(DataDrivenHelpers),"ReturnDataUsingAPI")]
        public void UsingAPISource(string name, string email)
        {
            //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }

    }
}