using NUnit.Framework;

namespace Customer
{
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange.
            Customer customer = new Customer();
            customer.FirstName = "Osa";
            customer.LastName = "Meji";

            string expected = "Meji, Osa";

            // Act.
            string actual = customer.FullName;

            // Assert.
            Assert.AreEqual(expected, actual) ;
        }
    }
}
