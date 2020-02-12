/* 
 * Circle.cs
 * Assignment1
 * 
 *  Revision History
 *      Jeonghwan Ju, 2020.02.12: Created
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JJAssignment1
{
    /// <summary>
    /// A class for Circle
    /// </summary>
    public class Circle
    {
        // Declaring class variables and constants
        private int radius;

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Circle()
        {
            this.radius = 1;
        }

        /// <summary>
        /// Non-fefault constructor
        /// </summary>
        /// <param name="radius">user input value</param>
        public Circle(int radius)
        {
            this.radius = radius;
        }

        // Four methods

        /// <summary>
        /// Get Radius
        /// </summary>
        /// <returns>Radius of Circle</returns>
        public int GetRadius()
        {
            return this.radius;
        }

        /// <summary>
        /// Set Radius
        /// </summary>
        /// <param name="radius">radius</param>
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Get Circumference Value
        /// </summary>
        /// <returns>Circumference of Circle</returns>
        public double GetCircumference()
        {
            return Math.Round((2 * Math.PI * (double)this.radius), 2);
        }

        /// <summary>
        /// Get Area of Circle
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.Round(Math.PI * (double)(this.radius * this.radius), 2);
        }
    }
}
