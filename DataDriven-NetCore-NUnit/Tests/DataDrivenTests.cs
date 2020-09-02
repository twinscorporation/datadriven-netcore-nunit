using NUnit.Framework;

namespace DataDriven_NetCore_NUnit
{
    public class DataDrivenTests
    {

        [TestCase("Irene J. Hunt","3022694414")]
        [TestCase("Michael D. Young","8056736694")]
        [TestCase("Andrew G. Jordan","3018291606")]
        [TestCase("Bryan J. Gabriel","2547151195")]
        [TestCase("Deborah J. Norman","3257436174")]
        [TestCase("Paul K. Boyd","6316959735")]
        public void UsingTestCase1(string name, string telephoneNumber)
        {
            //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }


        [TestCase(5, 6, 11)]
        [TestCase(12, 1, 13)]
        [TestCase(14, 5, 19)]
        [TestCase(12, 12, 24)]
        public void UsingTestCase2(int param1, int param2, int expectedResult)
        {
            int sumNumbers = param1 + param2;
            
            Assert.AreEqual(expectedResult, sumNumbers);
        }

        [Test]
        public void UsingCombinatorial(
            [Values("Irene J. Hunt", "Michael D. Young", "Andrew G. Jordan")] string names, 
            [Values("3022694414", "8056736694","3018291606")] string telephoneNumber)
        {
            //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }


        static string[] telephoneNumberList = {"3022694414", "8056736694","3018291606"};

        [TestCaseSource("telephoneNumberList")]
        public void UsingTestCaseSourceListString(string telephoneNumber)
        {
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }



        static object[] PersonData =
        {
            new object[] { "Irene J. Hunt", "1156736694" },  //TestCase1
            new object[] { "Michael D. Young", "8056736694"} //TestCase2
        };

        [TestCaseSource("PersonData")]
        public void UsingTestCaseSourceMultipleObj(string name, string telephoneNumber)
        {
            //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }


        //There is a Class named "TestDataDrivenHelpers" which has a method named "PersonData" 
        [TestCaseSource(typeof(DataDrivenHelpers), "PersonData")]
        public void UsingListObjectOutOfTestClass(string name, string telephoneNumber)
        {
             //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }


        
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


        [Test]
        public void UsingDataBaseSource()
        {
            Assert.Pass();
        }


        [TestCaseSource(typeof(DataDrivenHelpers),"ReturnDataUsingAPI")]
        public void UsingAPISource(string name, string email)
        {
            //some acts in website using "name" variable
            //some acts in website using "telephoneNumber" variable
            Assert.Pass();
        }



    }
}