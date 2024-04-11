using Mindbox.TestTask.Domain.Exceptions;
using System;

namespace Mindbox.TestTask.Domain
{
    public class Triangle : Shape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        private readonly double _p;

        public Triangle(double a, double b, double c)
        {
            var leftSide = a + b;
            var rightSide = b + c;
            var bottomSide = a + c;

            if (leftSide <= c || rightSide <= a || bottomSide <= b)
                throw new ShapeNotExists(GetType());

            _a = a;
            _b = b;
            _c = c;

            _p = (a + b + c) / 2;
        }

        public bool IsRight => _a * _a + _b * _b == _c * _c;

        protected override Func<double> SquareFunc =>
            () => Math.Sqrt(_p * GetPMinPartial(_a) * GetPMinPartial(_b) * GetPMinPartial(_c));

        private double GetPMinPartial(double partial) => _p - partial;
    }
}
