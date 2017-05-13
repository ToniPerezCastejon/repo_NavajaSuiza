using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicación_2_ValidarFecha;

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


        [TestClass]
        public class UnitTestValidarFecha
        {
            [TestMethod]
            public void TestValidarFecha_MesEnero_Dia31()
            {
                FechaLógica oFecha = new FechaLógica();

                //escenario
                oFecha.Dia = 31;
                oFecha.Mes = 1;
                oFecha.Anyo = 2000;
                bool sResultEsperado = true;
                bool sResultObtenido;

                //acción
                sResultObtenido = oFecha.ValidarFecha();

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestValidarFecha_MesAbril_Dia30()
            {
                FechaLógica oFecha = new FechaLógica();

                //escenario
                oFecha.Dia = 30;
                oFecha.Mes = 4;
                oFecha.Anyo = 2000;
                bool sResultEsperado = true;
                bool sResultObtenido;

                //acción
                sResultObtenido = oFecha.ValidarFecha();

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestValidarFecha_MesAbril_Dia31()
            {
                FechaLógica oFecha = new FechaLógica();

                //escenario
                oFecha.Dia = 31;
                oFecha.Mes = 4;
                oFecha.Anyo = 2000;
                bool sResultEsperado = false;
                bool sResultObtenido;

                //acción
                sResultObtenido = oFecha.ValidarFecha();

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }


            [TestMethod]
            public void TestValidarFecha_MesFebrero_Dia28_AnyoNoBisiesto()
            {
                FechaLógica oFecha = new FechaLógica();

                //escenario
                oFecha.Dia = 28;
                oFecha.Mes = 2;
                oFecha.Anyo = 1999;
                bool sResultEsperado = true;
                bool sResultObtenido;

                //acción
                sResultObtenido = oFecha.ValidarFecha();

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestValidarFecha_MesFebrero_Dia29_AnyoNoBisiesto()
            {
                FechaLógica oFecha = new FechaLógica();

                //escenario
                oFecha.Dia = 29;
                oFecha.Mes = 2;
                oFecha.Anyo = 1999;
                bool sResultEsperado = false;
                bool sResultObtenido;

                //acción
                sResultObtenido = oFecha.ValidarFecha();

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestValidarFecha_MesFebrero_Dia29_AnyoBisiesto()
            {
                FechaLógica oFecha = new FechaLógica();

                //escenario
                oFecha.Dia = 29;
                oFecha.Mes = 2;
                oFecha.Anyo = 2000;
                bool bResultEsperado = true;
                bool bResultObtenido;

                //acción
                bResultObtenido = oFecha.ValidarFecha();

                //afirmación
                Assert.AreEqual(bResultEsperado, bResultObtenido);
            }
        }

    }
}
