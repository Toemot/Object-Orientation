namespace Acme.Common.Tests
{
    public class StringHandlerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertSpaces()
        {
            var source = "OlaOtoks";
            var result = "Ola Otoks";

            var expected = source.InsertSpaces();
            
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void InsertSpacesFailsWithMultipleSpaces()
        {
            var source = "Ola Otoks";
            var result = "Ola Otoks";

            var expected = source.InsertSpaces();

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}