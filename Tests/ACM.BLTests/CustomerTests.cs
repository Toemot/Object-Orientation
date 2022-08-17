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

        [Test]
        public void ValidateValid()
        {
            Customer customer = new()
            {
                LastName = "Otoks",
                Email = "otoks@otoks.com"
            };
            var expected = true;

            var actual = customer.Validate();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateMissingLastNameIsInValid()
        {
            Customer customer = new()
            {
                Email = "otoks@otoks.com"
            };
            var expected = false;

            var actual = customer.Validate();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ValidateMissingEmailIsInValid()
        {
            Customer customer = new()
            {
                LastName = "Otoks"
            };
            var expected = false;

            var actual = customer.Validate();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}