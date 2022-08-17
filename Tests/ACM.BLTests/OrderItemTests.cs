using ACM.BL;

namespace ACM.BLTests
{
    public class OrderItemTests
    {
        [Test]
        public void ValidateOrderItemWithPropertiesReturnsTrue()
        {
            OrderItem orderItem = new()
            {
                Quantity = 3,
                ProductId = 1,
                PurchasePrice = 20m
            };

            var result = orderItem.Validate();

            Assert.That(result, Is.True);
        }

        [Test]
        public void ValidateOrderItemWithoutQuantityReturnsFalse()
        {
            OrderItem orderItem = new()
            {
                ProductId = 1,
                PurchasePrice = 20m
            };

            var result = orderItem.Validate();

            Assert.That(result, Is.False);
        }

        [Test]
        public void ValidateOrderItemWithoutProductReturnsFalse()
        {
            OrderItem orderItem = new()
            {
                Quantity = 3,
                PurchasePrice = 20m
            };

            var result = orderItem.Validate();

            Assert.That(result, Is.False);
        }
    }
}
