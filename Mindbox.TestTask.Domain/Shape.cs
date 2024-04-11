using Mindbox.TestTask.Domain.Exceptions;
using System;

namespace Mindbox.TestTask.Domain
{
    public abstract class Shape
    {
        public double Square => SquareFunc();

        protected abstract Func<double> SquareFunc { get; }
    }
}
