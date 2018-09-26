using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadOnly;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var emp = new Employee("manish", 100 );
          //  Assert.AreEqual("manish", emp.Name);
            Assert.AreEqual(100, emp.ID);
        }
    }
}
