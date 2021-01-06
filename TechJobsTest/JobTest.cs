using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTest
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            //Arrange
            int result1;
            int result2;
            int expected1 = 1;
            int expected2 = 2;
            Job job1 = new Job();
            Job job2 = new Job();
            //Act
            result1 = job1.Id;
            result2 = job2.Id;
            //Assert
            Assert.AreEqual(result1, expected1);
            Assert.AreEqual(result2, expected2);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //Arrange & Act
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //Assert
            Assert.IsTrue(job1.Name == "Product tester");
            Assert.IsTrue(true, "ACME");
            Assert.IsTrue(true, "Desert");
            Assert.IsTrue(true, "Quality control");
            Assert.IsTrue(true, "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            //Arrange & Act

            Job jobExpected = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job jobActual = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //Assert
            Assert.IsFalse(jobExpected.Equals(jobActual));
        }
    }
}
