using Mindbox.TestTask.Domain;
using Mindbox.TestTask.Domain.Exceptions;

namespace Mindbox.TestTask.Tests
{
    public class TriangleTests
    {
        [Test]
        public void TriangleNotExists()
        {
            var exception = Assert.Throws<ShapeNotExists>(() => new Triangle(0, 0, 1));

            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        public void TriangleExists()
        {
            Assert.DoesNotThrow(() => new Triangle(1, 1, 1));
        }

        [Test]
        public void TriangleAreaDeltaCompute()
        {
            var triangle = new Triangle(1, 1, 1);
            var expected = 0.433013;

            var actual = Math.Round(triangle.Square, 6);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TriangleIsRight()
        {
            var triangle = new Triangle(17, 144, 145);

            Assert.That(triangle.IsRight, Is.True);
        }

        [Test]
        public void TriangleIsNotRight()
        {
            Triangle trg = new(17, 144, 146);
            
            Assert.That(trg.IsRight, Is.False);
        }
    }
}
