using System;

namespace Mindbox.TestTask.Domain.Exceptions
{
    public class ShapeNotExists : Exception
    {
        public ShapeNotExists(Type shape) : base($"Don't exists {shape.Name} by input parameters") { }
    }
}
