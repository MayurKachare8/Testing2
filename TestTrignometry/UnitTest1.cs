using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Trignometry;

namespace TestTrignometry
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaOfSqaure()
        {
            TrignometricOperations to = new TrignometricOperations();
            double res = to.AreaOfSqaure(5);
            Assert.AreEqual(res, 25);
        }
        [TestMethod]
        public void TestAreaOfRectangle()
        {
            TrignometricOperations to = new TrignometricOperations();
            double res = to.AreaOfRectangle(2, 3);
            Assert.AreEqual(res, 6);
        }
        [TestMethod]
        public void TestPerimeterOfSquare()
        { 
            TrignometricOperations to=new TrignometricOperations();
            double res = to.PerimeterOfSquare(6);
            Assert.AreEqual(res, 24);
        }
       
    }
}
