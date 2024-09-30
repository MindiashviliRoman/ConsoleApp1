using ShapeAreaCalculator;
namespace BankTests
{
    [TestClass]
    public class ShapeAreaTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var expectedArea = 6;

            //Act
            var triangle = new Triangle(sideA, sideB, sideC);
            var triangleArea = (triangle as IShapeArea).Area();

            //Assert
            Assert.AreEqual(expectedArea, triangleArea, 0.0001f, "Area was not calculated correctly");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var expectedAreaNegativeValue = false;

            //Act
            var triangle = new Triangle(sideA, sideB, sideC);
            var triangleArea = (triangle as IShapeArea).Area();
            var value = float.IsNegative(triangleArea);

            //Assert
            Assert.AreEqual(expectedAreaNegativeValue, value, "Area is negative value");
        }
    }
}