
namespace ShapeAreaCalculator
{
    public class Triangle : IShapeArea
    {
        private float _sideA, _sideB, _sideC;

        public float SideA => _sideA;
        public float SideB => _sideB;
        public float SideC => _sideC;

        private float _maxSide;
        private float _leg1;
        private float _leg2;

        public bool IsValid { get; private set; }

        public Triangle(float sideA, float sideB, float sideC) 
        { 
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            ValidateTriangleVariant();
        }

        private void ValidateTriangleVariant()
        {
            _maxSide = _sideA;
            _leg1 = _sideB;
            _leg2 = _sideC;
            if(_maxSide < _sideB)
            {
                _maxSide = _sideB;
                _leg1 = _sideA;
            }
            if (_maxSide < _sideC)
            {
                _maxSide = _sideC;
                _leg1 = _sideA;
                _leg2 = _sideB;
            }
            IsValid = (_leg1 + _leg2) > _maxSide;
        }

        public bool IsRightTriangle()
        {
            if (IsValid)
            {
                return (_leg1 * _leg1 + _leg2 * _leg2 - _maxSide * _maxSide) < 0.0001f;
            }
            return false;
        }



        #region IShapeArea
        public float Area()
        {
            if (IsValid)
            {
                //calculate semiperimeter
                var sP = (_sideA + _sideB + _sideC) / 2;

                //Geron expression
                return MathF.Sqrt(sP * (sP - _sideA) * (sP - _sideB) * (sP - _sideC));
            }

            return 0;
        }
        #endregion
    }
}
