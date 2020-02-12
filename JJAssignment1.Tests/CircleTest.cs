/* 
 * CircleTest.cs
 * Assignment1
 * 
 *  Revision History
 *      Jeonghwan Ju, 2020.02.12: Created
 */
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JJAssignment1.Tests
{
    /// <summary>
    /// CircleTest class
    /// </summary>
    [TestFixture]
    public class CircleTest
    {
        /// <summary>
        /// GetRadius Test
        /// </summary>
        [Test]
        public void GetRadius_Given5_ResultIs5()
        {
            // Arrange
            int radius = 0;
            Circle circle = new Circle(5);

            // Act
            radius = circle.GetRadius();

            // Assert
            Assert.AreEqual(5, radius);
        }

        /// <summary>
        /// SetRadius Test
        /// </summary>
        [Test]
        public void SetRadius_Given4_ResultIs4()
        {
            // Arrange
            int radius = 0;
            Circle circle = new Circle();

            // Act
            circle.SetRadius(4);
            radius = circle.GetRadius();

            // Assert
            Assert.AreEqual(4, radius);
        }

        /// <summary>
        /// GetCircumference Test
        /// </summary>
        [Test]
        public void GetCircumference_Given3_ResultIs18()
        {
            // Arrange
            double circumference = 0;
            Circle circle = new Circle(3);

            // Act
            circumference = circle.GetCircumference();

            // Assert
            Assert.AreEqual(18.85, circumference);
        }

        /// <summary>
        /// GetArea Test
        /// </summary>
        [Test]
        public void GetArea_Given2_ResultIs12()
        {
            // Arrange
            double area = 0;
            Circle circle = new Circle(2);

            // Act
            area = circle.GetArea();

            // Assert
            Assert.AreEqual(12.57, area);
        }
    }
}
