using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Customer.data;

namespace CustomerDB.test
{
    [TestClass]
    public class customertest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomerDBImpl test = new CustomerDBImpl();
            test.InsertCustomer("Shahrukh", "Khan", "abc@gmail.com", "9877548789");
        }
    }
}
