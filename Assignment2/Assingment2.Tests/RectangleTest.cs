using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Assingment2_Tests
{
    public class RectangleTest
    {
        [TestFixture]

        public class RectangleTest1
        {
            [Test]
            public static void GetLength_RectangleLength()
            {
                //arrange
                int expected = 128;
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(expected);

                //act
                int actual = rect.GetLength();

                //assert
                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest2
        {
            [Test]
            public static void GetLength_RectangleLength()
            {
                //arrange
                int expected = 0;
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(expected);

                //act
                int actual = rect.GetLength();

                //assert
                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest3
        {
            [Test]
            public static void GetLength_RectangleLength()
            {
                //arrange
                int expected = -1;
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(expected);

                //act
                int actual = rect.GetLength();

                //assert
                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest4
        {
            [Test]
            public static void GetWidth_RectangleWidth()
            {
                int expected = 0;
                Assignment2.Rectangle rect = new Assignment2.Rectangle();

                rect.setWidth(expected);

                int actual = rect.GetWidth();

                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest5
        {
            [Test]

            public static void GetWidth_RectWidth()
            {
                int expected = 256; 
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setWidth(expected);

                int actual = rect.GetWidth();

                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest6
        {
            [Test]

            public static void GetWidth_RectWidth()
            {
                int expected = 512;
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setWidth(expected);

                int actual = rect.GetWidth();

                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest7
        {
            [Test]

            public static void SetLength_RectLength() {
            
                int expected = 0;
            
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(expected);
                int actual = rect.GetLength();
            
                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest8
        {
            [Test]

            public static void SetLength_RectLength()
            {

                int expected = 1024;

                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(expected);
                int actual = rect.GetLength();

                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest9
        {
            [Test]

            public static void SetLength_RectLength()
            {

                int expected = 2048;

                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(expected);
                int actual = rect.GetLength();

                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest10
        {
            [Test]

            public static void SetWidth_RectWidth()
            {
                int expected = 0;
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setWidth(expected);

                int actual = rect.GetWidth();

                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest11
        {
            [Test]

            public static void SetWidth_RectWidth()
            {
                int expected = 32;
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setWidth(expected);

                int actual = rect.GetWidth();

                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest12
        {
            [Test]

            public static void SetWidth_RectWidth()
            {
                int expected = 64;
                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setWidth(expected);

                int actual = rect.GetWidth();

                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class RectangleTest13
        {
            [Test]
            
            public static void GetPerimeter_RectPerimeter()
            {
                int length = 32;
                int width = 64;

                int expected = (length * 2) + (width * 2);

                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(length);
                rect.setWidth(width);

                int actual = rect.getPerimeter();

                ClassicAssert.AreEqual(actual, expected);
            }
        }

        public class RectangleTest14
        {
            [Test]

            public static void GetPerimeter_RectPerimeter()
            {
                int length = 128;
                int width = 64;

                int expected = (length * 2) + (width * 2);

                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(length);
                rect.setWidth(width);

                int actual = rect.getPerimeter();

                ClassicAssert.AreEqual(actual, expected);
            }
        }

        public class RectangleTest15
        {
            [Test]

            public static void GetPerimeter_RectPerimeter()
            {
                int length = 2048;
                int width = 1024;

                int expected = (length * 2) + (width * 2);

                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(length);
                rect.setWidth(width);

                int actual = rect.getPerimeter();

                ClassicAssert.AreEqual(actual, expected);
            }
        }

        public class RectangleTest16
        {
            [Test]

            public static void GetArea_RectArea()
            {
                int length = 32;
                int width = 64;

                int expected = length * width;

                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(length);
                rect.setWidth(width);

                int actual = rect.getArea();

                ClassicAssert.AreEqual(actual, expected);
            }
        }

        public class RectangleTest17
        {
            [Test]

            public static void GetArea_RectArea()
            {
                int length = 128;
                int width = 256;

                int expected = length * width;

                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(length);
                rect.setWidth(width);

                int actual = rect.getArea();

                ClassicAssert.AreEqual(actual, expected);
            }
        }

        public class RectangleTest18
        {
            [Test]

            public static void GetArea_RectArea()
            {
                int length = 4096;
                int width = 8192;

                int expected = length * width;

                Assignment2.Rectangle rect = new Assignment2.Rectangle();
                rect.setLength(length);
                rect.setWidth(width);

                int actual = rect.getArea();

                ClassicAssert.AreEqual(actual, expected);
            }
        }
    }
}
