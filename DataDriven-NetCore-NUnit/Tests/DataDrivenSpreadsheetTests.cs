using DataDriven_NetCore_NUnit.Helpers;
using NUnit.Framework;

namespace DataDriven_NetCore_NUnit
{
    public class DataDrivenSpreadsheetTests
    {
      
        [TestCaseSource(typeof(DataDrivenHelpers),"ReturnNameTelephone_CSV")]
        public void UsingCSVSource(string name, string telephoneNumber)
        {
             //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }


        [TestCaseSource(typeof(DataDrivenHelpers),"ReturnNameTelephone_XLSX")]
        public void UsingXLSXSource(string name, string telephoneNumber)
        {
            //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }

    }
}