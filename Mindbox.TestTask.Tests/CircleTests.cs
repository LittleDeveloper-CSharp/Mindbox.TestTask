using Mindbox.TestTask.Domain;
using Mindbox.TestTask.Domain.Exceptions;

namespace Mindbox.TestTask.Tests
{
    public class CircleTests
    {
        [Test]
        public void CircleNotExists()
        {
            var exception = Assert.Throws<ShapeNotExists>(() => new Circle(0));
         
            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        public void CircleExists()
        {
            Assert.DoesNotThrow(() => new Circle(1));
        }

        [Test] 
        public void CircleAreaDeltaCompute()
        {
            var circle = new Circle(4);
            var expected = 50.24;

            var actual = Math.Round(circle.Square, circle.Eps);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}