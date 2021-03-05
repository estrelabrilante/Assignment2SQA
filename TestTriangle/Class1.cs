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
        public void AnalyzeTest1()
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
        public void AnalyzeTest2()
        {
            int a = -2;//Arrange
            int b = -2;
            int c = -2;
            string output = TriangleSolver.Analyze(a, b, c);//Act
            Assert.AreNotEqual("Equilateral", output);//Assert


        }

        [Test]
        public void AnalyzeTest3()
        {
            int a = 1;//Arrange
            int b = 0;
            int c = 0;
            string output = TriangleSolver.Analyze(a, b, c); //Act
            Assert.AreNotEqual("Isosceles", output);//Assert

        }
        [Test]
        public void AnalyzeTest4()
        {
            int a = 1;
            int b = 1;//Arrange
            int c = 3;
            string output = TriangleSolver.Analyze(a, b, c); //Act
            Assert.AreEqual("Isosceles", output);//Assert


        }
        [Test]
        public void AnalyzeTest5()
        {
            int a = 1;
            int b = 2;//Arrange
            int c = 3;
            string output = TriangleSolver.Analyze(a, b, c); //Act
            Assert.AreEqual("Scalene", output);//Assert


        }
        [Test]
        public void AnalyzeTest6()
        {
            int a = -1; //Arrange
            int b = -2;
            int c = -3;
            string output = TriangleSolver.Analyze(a, b, c); //Act
            Assert.AreNotEqual("Scalene", output);//Assert


        }
        [Test]
        public void AnalyzeTest7()
        {
            int a = -50;//Arrange
            int b = 150;
            int c = 3;
            string output = TriangleSolver.Analyze(a, b, c); //Act
            Assert.AreNotEqual("Scalene", output);//Assert


        }

        [Test]
        public void AnalyzeTest8()
        {
            int a = 50;//Arrange
            int b = -50;
            int c = -50;
            string output = TriangleSolver.Analyze(a, b, c); //Act
            Assert.AreNotEqual("Isosceles", output);//Assert


        }





    }
}
