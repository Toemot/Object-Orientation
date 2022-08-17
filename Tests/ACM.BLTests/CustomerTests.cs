using ACM.BL;

namespace ACM.BLTests
{
    public class CustomerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FullNameValidity()
        {
            Customer customer = new()
            {
                FirstName = "Ola",
                LastName = "Otoks"
            };

            var result = "Otoks, Ola";

            string expected = customer.FullName;
            Assert.That(result, Is.EqualTo(expected));
            Assert.Pass();
        }

        [Test]
        public void FullNameValidityLastNameEmpty()
        {
            Customer customer = new()
            {
                FirstName = "Ola"
            };

            var result = "Ola";

            string expected = customer.FullName;
            Assert.That(result, Is.EqualTo(expected));
            Assert.Pass();
        }

        [Test]
        public void FullNameValidityFirstNameEmpty()
        {
            Customer customer = new()
            {
                LastName = "Otoks"
            };

            var result = "Otoks";

            string expected = customer.FullName;
            Assert.That(result, Is.EqualTo(expected));
            Assert.Pass();
        }
    }
}