using ShapeAreaCalculator;
namespace BankTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        //Existense triangle with sides
        public void TestMethod1()
        {
            //Arrange
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var expectedIsValid = true;

            //Act
            var triangle = new Triangle(sideA, sideB, sideC);
            var trinagleIsValid = triangle.IsValid;

            //Assert
            Assert.AreEqual(expectedIsValid, trinagleIsValid, "Incorrect IsRightTriangle definition");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var sideA = 1;
            var sideB = 2;
            var sideC = 6;
            var expectedIsValid = false;

            //Act
            var triangle = new Triangle(sideA, sideB, sideC);
            var trinagleIsValid = triangle.IsValid;

            //Assert
            Assert.AreEqual(expectedIsValid, trinagleIsValid, "Incorrect IsRightTriangle definition");
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var sideA = 3;
            var sideB = 4;
            var sideC = 5;
            var expectedIsRight = true;

            //Act
            var triangle = new Triangle(sideA, sideB, sideC);
            var triangleValueIsRight = triangle.IsRightTriangle();

            //Assert
            Assert.AreEqual(expectedIsRight, triangleValueIsRight, "Incorrect IsRightTriangle definition");
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var sideA = 1;
            var sideB = 2;
            var sideC = 4;
            var expectedIsRight = false;

            //Act
            var triangle = new Triangle(sideA, sideB, sideC);
            var triangleValueIsRight = triangle.IsRightTriangle();

            //Assert
            Assert.AreEqual(expectedIsRight, triangleValueIsRight, "Incorrect IsRightTriangle definition");
        }
    }
}
