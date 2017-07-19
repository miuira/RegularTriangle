using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularTriangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularTriangle.Tests
{
    [TestClass()]
    public class TriangleTests
    {

        [TestMethod()]
        public void ValidArea()
        {
            Triangle t = new Triangle(1, 2, 3);
            double exp = 1;
            double act = t.Area();
            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void NullArea()
        {
            Triangle t = new Triangle(0, 2, 3);
            double exp = 0;
            double act = t.Area();
            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void MinusArea()
        {
            Triangle t = new Triangle(-1, 2, 3);
            double exp = 0;
            double act = t.Area();
            Assert.AreEqual(exp, act);
        }
    }
}