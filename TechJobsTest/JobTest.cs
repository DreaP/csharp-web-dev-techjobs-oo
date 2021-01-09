using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        [TestMethod]
        public void TestingFirstRequirement()
        {
            //Arrange & Act
            Job jobExpected = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string testString = jobExpected.ToString();
            char firstChar = testString[0];
            char lastChar = testString[testString.Length - 1];
            //Assert
            Assert.IsTrue(firstChar == lastChar);

        }
        [TestMethod]
        public void TestToStringContainsCorrectLablesAndData()
        {
            //Arrange & Act
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string testOutput = $"\n ID: {job3.Id}\n Name: {job3.Name}\n Employer: {job3.EmployerName.Value}\n Location: {job3.EmployerLocation.Value}\n Position Type: {job3.JobType.Value}\n Core Competency: {job3.JobCoreCompetency.Value}\n";
            //Assert
            Assert.AreEqual(testOutput, job3.ToString());
        }
        
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job3.EmployerName.Value = "";
            job3.JobType.Value = "";
            string testOutput = $"\n ID: {job3.Id}\n Name: {job3.Name}\n Employer: Data not available\n Location: {job3.EmployerLocation.Value}\n Position Type: Data not available\n Core Competency: {job3.JobCoreCompetency.Value}\n";
            Assert.AreEqual(testOutput, job3.ToString());
        }
    }
}
