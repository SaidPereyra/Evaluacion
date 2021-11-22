using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestClassOp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void opsuma_SumTwoNumbers_GetNumberTen() //Syntax: NombreClase_Scenario_ResultadoEsperado
        {
            //Arrange
            var op = new ClassOp(5, 5);

            //Act
            var result = op.opsuma();

            //Assert
            Assert.AreEqual("10", result.ToString());
        }
        [TestMethod]
        public void opresta_SubtractionTwoNumbers_GetNumberFive() //Syntax: NombreClase_Scenario_ResultadoEsperado
        {
            //Arrange
            var op = new ClassOp(10, 5);

            //Act
            var result = op.opresta();

            //Assert
            Assert.AreEqual("5", result.ToString());
        }
        [TestMethod]
        public void opmultiplicar_MultiplyTwoNumbers_GetNumberTwenty() //Syntax: NombreClase_Scenario_ResultadoEsperado
        {
            //Arrange
            var op = new ClassOp(10, 2);

            //Act
            var result = op.opmultiplicar();

            //Assert
            Assert.AreEqual("20", result.ToString());
        }
        [TestMethod]
        public void opdividir_DivideTwoNumbers_GetNumberTwenty() //Syntax: NombreClase_Scenario_ResultadoEsperado
        {
            //Arrange
            var op = new ClassOp(100, 5);

            //Act
            var result = op.opdividir();

            //Assert
            Assert.AreEqual("20", result.ToString());
        }
        [TestMethod]
        public void mayorque_XGreaterThanY_GetTrue() //Syntax: NombreClase_Scenario_ResultadoEsperado
        {
            //Arrange
            var op = new ClassOp(10, 2);

            //Act
            var result = op.mayorque();

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void menorque_XSmallerThanY_GetFalse() //Syntax: NombreClase_Scenario_ResultadoEsperado
        {
            //Arrange
            var op = new ClassOp(100, 5);

            //Act
            var result = op.menorque();

            //Assert
            Assert.IsFalse(result);
        }
    }
}
