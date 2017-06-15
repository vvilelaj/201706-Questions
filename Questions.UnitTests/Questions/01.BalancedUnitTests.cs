using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Questions.Questions;

namespace Questions.Questions.UnitTests
{
    [TestClass]
    public class _01_BalancedUnitTests
    {
        [TestMethod]
        public void EstaBlanceado_CantidadCaracteresEsCero_DevuelveFalso()
        {
            var balanced = new _01_Balanced();

            var result = balanced.EstaBalanceado("");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void EstaBlanceado_CantidadCaracteresEsImpar_DevuelveFalso()
        {
            var balanced = new _01_Balanced();

            var result = balanced.EstaBalanceado("{{{");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void EstaBlanceado_PrimeroCaracterEsAbrirLLaveYUltimoCaracterEsCerrarLlave_DevuelveFalso()
        {
            var balanced = new _01_Balanced();

            var result = balanced.EstaBalanceado("{{}");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void EstaBlanceado_ParentesisBalanceado_DevuelveFalso()
        {
            var balanced = new _01_Balanced();

            var result = balanced.EstaBalanceado("{{{");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void EstaBlanceado_Cadena1_DevuelveTrue()
        {
            var balanced = new _01_Balanced();

            var result = balanced.EstaBalanceado("{[]()}");

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void EstaBlanceado_Cadena2_DevuelveTrue()
        {
            var balanced = new _01_Balanced();

            var result = balanced.EstaBalanceado("{[(])}");

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void EstaBlanceado_Cadena3_DevuelveTrue()
        {
            var balanced = new _01_Balanced();

            var result = balanced.EstaBalanceado("{[}");

            Assert.AreEqual(false, result);
        }
    }
}
