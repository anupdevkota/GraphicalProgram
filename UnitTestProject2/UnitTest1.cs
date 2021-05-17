using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphicalProgram;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {


        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            var r = new GraphicalProgram.Rectangle();
            int x = 200, y = 200, size = 100, size1 = 100;
            r.set(texturestyle, bb, c1, x, y, size, size1);
            Assert.AreEqual(200, r.x);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var t = new GraphicalProgram.Triangle();
            int xi1 = 100, yi1 = 200, xi2 = 200, yi2 = 200, xii1 = 200, yii1 = 200, xii2 = 200,
                yii2 = 200, xiii1 = 200, yiii1 = 200, xiii2 = 200, yiii2 = 200;
            t.set(texturestyle, bb, c1, xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2);
            Assert.AreEqual(100, t.xi1);
        }
    }
}
