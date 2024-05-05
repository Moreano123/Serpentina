using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Algoritmo3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public void mcd_Dos_Positivos()
        {
            int nro1 = 12;
            int nro2 = 18;
            int esperado = 6;
            int prueba = Algoritmo1.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Un_Positivo_Un_Negativo()
        {
            int nro1 = 24;
            int nro2 = -36;
            int esperado = 12;
            int prueba = Algoritmo1.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Ambos_Negativos()
        {
            int nro1 = -24;
            int nro2 = -36;
            int esperado = 12;
            int prueba = Algoritmo1.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Cero_Positivo()
        {
            int nro1 = 0;
            int nro2 = 23;
            int esperado = 12;
            int prueba = Algoritmo1.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Cero_Negativo()
        {
            int nro1 = 0;
            int nro2 = -12;
            int esperado = 12;
            int prueba = Algoritmo1.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Mismo_Numero()
        {
            int nro1 = 12;
            int nro2 = 12;
            int esperado = 12;
            int prueba = Algoritmo1.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
    }
}
