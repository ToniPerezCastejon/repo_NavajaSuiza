using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNavajaSuiza
{
    [TestClass]
    public class UnitTestNavajaSuiza
    {

        [TestClass]
        public class UnitTestNumerosPrimos
        {

            [TestMethod]
            public void TestComprobarPrimo_Numero_1()
            {
                //escenario
                int iNumero = 1;
                bool sResultEsperado = true;
                bool sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_1_NumerosPrimos.PrimosLógica.ComprobarPrimo(iNumero);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestComprobarPrimo_Numero_2()
            {
                //escenario
                int iNumero = 2;
                bool sResultEsperado = true;
                bool sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_1_NumerosPrimos.PrimosLógica.ComprobarPrimo(iNumero);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestComprobarPrimo_Numero_3()
            {
                //escenario
                int iNumero = 3;
                bool sResultEsperado = true;
                bool sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_1_NumerosPrimos.PrimosLógica.ComprobarPrimo(iNumero);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestComprobar_Primo_Numero_4()
            {
                //escenario
                int iNumero = 4;
                bool sResultEsperado = false;
                bool sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_1_NumerosPrimos.PrimosLógica.ComprobarPrimo(iNumero);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestComprobarPrimo_Numero_MaxValueMenos1()
            {
                //escenario
                int iNumero = Int32.MaxValue - 1;
                bool sResultEsperado = false;
                bool sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_1_NumerosPrimos.PrimosLógica.ComprobarPrimo(iNumero);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestComprobarPrimo_Numero_MaxValue()
            {
                //escenario
                int iNumero = Int32.MaxValue;
                bool sResultEsperado = true;
                bool sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_1_NumerosPrimos.PrimosLógica.ComprobarPrimo(iNumero);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }
        }

    }
}
