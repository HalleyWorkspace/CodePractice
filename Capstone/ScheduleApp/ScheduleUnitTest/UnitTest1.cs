using NUnit.Framework;
using ScheduleApp.dataControl;
using System;
using System.Collections.Generic;


namespace ScheduleUnitTest
{
    public class Tests
    {
        private DatabaseAccess database;
        private consultantObject consultant;
        private string testName = "test";
        private string testPassword = "test";
        private Exception exception;
        List<consultantObject> testList;
        

        [SetUp]
        public void Setup()
        {
            consultant = new consultantObject() { consultantName = testName, password = testPassword, consultantId = 1 };
            testList = new List<consultantObject>();
            testList.Add(consultant);
            database = new DatabaseAccess(testList);
            try { 
            consultant = DatabaseAccess.login(testName, testPassword);
            }
            catch(Exception e)
            {
                exception = e;
            }
        }

        [Test]
        public void userExists()
        {
            Assert.IsNotNull(consultant);
        }
        [Test]
        public void correctUser()
        {
            Assert.That(consultant.consultantId == 1);
            Assert.That(consultant.consultantName == testName);
        }
        [Test]
        public void noExceptions()
        {
            Assert.IsNull(exception);
        }
    }
}