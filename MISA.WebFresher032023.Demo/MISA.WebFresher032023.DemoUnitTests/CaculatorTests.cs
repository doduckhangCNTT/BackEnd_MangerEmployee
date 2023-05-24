using MISA.WebFresher032023.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher032023.DemoUnitTests
{
    [TestFixture] // Đánh dấu class đó là class test
    public class CaculatorTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(1, 3, 4)]
        [TestCase(int.MaxValue, 3, ((long)int.MaxValue + 3))]
        public void Add_ValidInput_ReturnsSuccess(int a, int b, long expectedResult)
        {
            // Arrange

            // Act
            var caculator = new Caculator();
            var actualResult = caculator.Add(a, b);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }

        [TestCase(1, 2, -1)]
        [TestCase(2, 3, -1)]
        [TestCase(1, 3, -2)]
        [TestCase(int.MaxValue, int.MinValue, ((long)int.MaxValue * 2) + 1)]
        public void Sub_ValidInput_ReturnsSuccess(int a, int b, long expectedResult)
        {
            // Arrange

            // Act
            var caculator = new Caculator();
            var actualResult = caculator.Sub(a, b);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(1, 2, 2)]
        [TestCase(2, 3, 6)]
        [TestCase(1, 3, 3)]
        [TestCase(int.MaxValue, int.MinValue, ((long)int.MaxValue * int.MinValue))]
        public void Mul_ValidInput_ReturnsSuccess(int a, int b, long expectedResult)
        {
            // Arrange

            // Act
            var caculator = new Caculator();
            var actualResult = caculator.Mul(a, b);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }


        //[TestCase(4, 0, "Khong chia duoc cho 0")]
        [TestCase(18, 3, 6)]
        [TestCase(9, 3, 3)]
        public void Div_ZeroDivide_ReturnsException(int a, int b, int expectedResult)
        {
            // Arrange

            // Act
            var caculator = new Caculator();
            var handle =caculator.Div(a, b);

            // Assert
            //Assert.That(actualResult, Is.EqualTo(expectedResult));

            //var ex = Assert.Throws<Exception>(() => caculator.Div(a, b));
            Assert.That(handle, Is.EqualTo(expectedResult));

            //Assert.That(ex.Message, Is.EqualTo(expectedResult));

        }
    }
}
