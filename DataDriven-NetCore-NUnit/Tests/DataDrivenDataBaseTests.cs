using DataDriven_NetCore_NUnit.Helpers;
using NUnit.Framework;

namespace DataDriven_NetCore_NUnit
{
    public class DataDrivenDataBaseTests
    {

        [TestCaseSource(typeof(DataDrivenHelpers),"ReturnDataUsingDataBase")]
        public void UsingDataBaseSource(string name, string email)
        {
            //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            string nome = string.Empty;
            Assert.Pass();
        }


    }
}