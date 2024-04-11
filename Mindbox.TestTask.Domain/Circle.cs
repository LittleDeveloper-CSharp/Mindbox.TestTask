using Mindbox.TestTask.Domain.Exceptions;
using System;

namespace Mindbox.TestTask.Domain
{
    public class Circle : Shape
    {
        private readonly double _radius;


        private int _eps = 2;

        public int Eps
        {
            get => _eps; 
            
            set
            {
                _eps = value;
            }
        }

        public Circle(double radius) 
        {
            if (radius <= 0)
                throw new ShapeNotExists(GetType());

            _radius = radius;
        }

        private double PI => Math.Round(Math.PI, _eps);

        protected override Func<double> SquareFunc => 
            () => PI * Math.Pow(_radius, 2);
    }
}
