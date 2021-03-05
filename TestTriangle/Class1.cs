using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;
using NUnit.Framework;

namespace TestTriangle
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Analyze1()
        {
            //Arrange
            int a = 3;
            int b = 3;
            int c = 3;

            //Act
            string output = TriangleSolver.Analyze(a, b, c);

            Assert.AreEqual("Equilateral", output);
        }
        [Test]
        public void Analyze2()
        {
            int a = -2;//1;
            int b = -2;//2;
            int c = -2;//0;
            string output = TriangleSolver.Analyze(a, b, c);
            Assert.AreNotEqual("Equilateral", output);


        }

        [Test]
        public void Analyze3()
        {
            int a = 1;
            int b = 0;
            int c = 0;
            string output = TriangleSolver.Analyze(a, b, c);
            Assert.AreNotEqual("Isosceles", output);//Equilateral


        }
        [Test]
        public void Analyze4()
        {
            int a = 1;
            int b = 1;
            int c = 3;
            string output = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual("Isosceles", output);


        }
        [Test]
        public void Analyze5()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            string output = TriangleSolver.Analyze(a, b, c);
            Assert.AreEqual("Scalene", output);


        }
        [Test]
        public void Analyze6()
        {
            int a = -1; // 10;
            int b = -2; // 10;
            int c = -3;// 3;
            string output = TriangleSolver.Analyze(a, b, c);
            Assert.AreNotEqual("Scalene", output);


        }
        [Test]
        public void Analyze7()
        {
            int a = -50;
            int b = 150;
            int c = 3;
            string output = TriangleSolver.Analyze(a, b, c);
            Assert.AreNotEqual("Scalene", output);


        }

        [Test]
        public void Analyze8()
        {
            int a = 50;
            int b = -50;
            int c = -50;
            string output = TriangleSolver.Analyze(a, b, c);
            Assert.AreNotEqual("Isosceles", output);


        }





    }
}
