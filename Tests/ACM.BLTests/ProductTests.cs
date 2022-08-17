using ACM.BL;

namespace ACM.BLTests
{
    public class ProductTests
    {
        [Test]
        public void ValidateProductWithPropertiesReturnsTrue()
        {
            Product product = new()
            {
                ProductName = "Pencil",
                CurrentPrice = 6.5m
            };
            var expected = product.Validate();

            Assert.That(expected, Is.True);
        }

        [Test]
        public void ValidateProductWithNoProductNameReturnsFalse()
        {
            Product product = new()
            {
                CurrentPrice = 6.5m
            };
            var expected = product.Validate();

            Assert.That(expected, Is.False);
        }

        [Test]
        public void ValidateProductWithNoCurrentPriceReturnsFalse()
        {
            Product product = new()
            {
                ProductName = "Pencil",
            };
            var expected = product.Validate();

            Assert.That(expected, Is.False);
        }
    }
}
