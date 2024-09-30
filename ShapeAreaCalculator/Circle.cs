
namespace ShapeAreaCalculator
{
    public class Circle : IShapeArea
    {
        private float _radius;

        public float Radius => _radius;

        public Circle(float radius) 
        {
            _radius = radius;
        }

        #region IShapeArea
        public float Area()
        {
            return 3.14f * _radius * _radius;
        }
        #endregion
    }
}
