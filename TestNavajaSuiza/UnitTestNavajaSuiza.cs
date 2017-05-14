﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicación_2_ValidarFecha;
using NavajaSuiza.Aplicación_3_JuegoAdivinarNumero;

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

        [TestClass]
        public class UnitTestAdivinarNúmeroAleatorio
        {
            [TestMethod]
            public void TestJugarRandom_PrimerIntento_NumeroAcertado()
            {
                AdivinarNúmeroLógica oAdivinarNum = new AdivinarNúmeroLógica();

                //escenario
                oAdivinarNum.NumAleatorio = 50;
                oAdivinarNum.IntentosRestantes = 6;
                int iNumero = 50;
                int iCompareNumsEsperado = 0;
                int iCompareNumsObtenido;
                int iIntentosRestantesEsperado = 5;
                int iIntentosRestantesObtenido;

                //acción
                oAdivinarNum.JugarRandom(iNumero, out iCompareNumsObtenido, out iIntentosRestantesObtenido);

                //afirmación
                Assert.AreEqual(iCompareNumsEsperado, iCompareNumsObtenido);
                Assert.AreEqual(iIntentosRestantesEsperado, iIntentosRestantesObtenido);
            }

            [TestMethod]
            public void TestJugarRandom_UltimoIntento_NumeroAcertado()
            {
                AdivinarNúmeroLógica oAdivinarNum = new AdivinarNúmeroLógica();

                //escenario
                oAdivinarNum.NumAleatorio = 50;
                oAdivinarNum.IntentosRestantes = 1;
                int iNumero = 50;
                int iCompareNumsEsperado = 0;
                int iCompareNumsObtenido;
                int iIntentosRestantesEsperado = 0;
                int iIntentosRestantesObtenido;

                //acción
                oAdivinarNum.JugarRandom(iNumero, out iCompareNumsObtenido, out iIntentosRestantesObtenido);

                //afirmación
                Assert.AreEqual(iCompareNumsEsperado, iCompareNumsObtenido);
                Assert.AreEqual(iIntentosRestantesEsperado, iIntentosRestantesObtenido);
            }

            [TestMethod]
            public void TestJugarRandom_PrimerIntento_NumeroMayorQueRandom()
            {
                AdivinarNúmeroLógica oAdivinarNum = new AdivinarNúmeroLógica();

                //escenario
                oAdivinarNum.NumAleatorio = 50;
                oAdivinarNum.IntentosRestantes = 6;
                int iNumero = 75;
                int iCompareNumsEsperado = 1;
                int iCompareNumsObtenido;
                int iIntentosRestantesEsperado = 5;
                int iIntentosRestantesObtenido;

                //acción
                oAdivinarNum.JugarRandom(iNumero, out iCompareNumsObtenido, out iIntentosRestantesObtenido);

                //afirmación
                Assert.AreEqual(iCompareNumsEsperado, iCompareNumsObtenido);
                Assert.AreEqual(iIntentosRestantesEsperado, iIntentosRestantesObtenido);
            }

            [TestMethod]
            public void TestJugarRandom_UltimoIntento_NumeroMayorQueRandom()
            {
                AdivinarNúmeroLógica oAdivinarNum = new AdivinarNúmeroLógica();

                //escenario
                oAdivinarNum.NumAleatorio = 50;
                oAdivinarNum.IntentosRestantes = 1;
                int iNumero = 75;
                int iCompareNumsEsperado = 1;
                int iCompareNumsObtenido;
                int iIntentosRestantesEsperado = 0;
                int iIntentosRestantesObtenido;

                //acción
                oAdivinarNum.JugarRandom(iNumero, out iCompareNumsObtenido, out iIntentosRestantesObtenido);

                //afirmación
                Assert.AreEqual(iCompareNumsEsperado, iCompareNumsObtenido);
                Assert.AreEqual(iIntentosRestantesEsperado, iIntentosRestantesObtenido);
            }

            [TestMethod]
            public void TestJugarRandom_PrimerIntento_NumeroMenorQueRandom()
            {
                AdivinarNúmeroLógica oAdivinarNum = new AdivinarNúmeroLógica();

                //escenario
                oAdivinarNum.NumAleatorio = 50;
                oAdivinarNum.IntentosRestantes = 6;
                int iNumero = 25;
                int iCompareNumsEsperado = -1;
                int iCompareNumsObtenido;
                int iIntentosRestantesEsperado = 5;
                int iIntentosRestantesObtenido;

                //acción
                oAdivinarNum.JugarRandom(iNumero, out iCompareNumsObtenido, out iIntentosRestantesObtenido);

                //afirmación
                Assert.AreEqual(iCompareNumsEsperado, iCompareNumsObtenido);
                Assert.AreEqual(iIntentosRestantesEsperado, iIntentosRestantesObtenido);
            }

            [TestMethod]
            public void TestJugarRandom_UltimoIntento_NumeroMenorQueRandom()
            {
                AdivinarNúmeroLógica oAdivinarNum = new AdivinarNúmeroLógica();

                //escenario
                oAdivinarNum.NumAleatorio = 50;
                oAdivinarNum.IntentosRestantes = 1;
                int iNumero = 25;
                int iCompareNumsEsperado = -1;
                int iCompareNumsObtenido;
                int iIntentosRestantesEsperado = 0;
                int iIntentosRestantesObtenido;

                //acción
                oAdivinarNum.JugarRandom(iNumero, out iCompareNumsObtenido, out iIntentosRestantesObtenido);

                //afirmación
                Assert.AreEqual(iCompareNumsEsperado, iCompareNumsObtenido);
                Assert.AreEqual(iIntentosRestantesEsperado, iIntentosRestantesObtenido);
            }
        }


        [TestClass]
        public class UnitTestPotenciaNúmero
        {
            [TestMethod]
            public void TestCalcularPotencia_BasePosit_ExpPosit()
            {
                //escenario
                int iBase = 2;
                int iExp = 3;
                double sResultEsperado = 8;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BaseMaxValue_Exp9999999()
            {
                //escenario
                int iBase = int.MaxValue;
                int iExp = 9999; //
                double sResultEsperado = double.PositiveInfinity;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BasePosit_ExpNegat()
            {
                //escenario
                int iBase = 2;
                int iExp = -3;
                double sResultEsperado = 0.125;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BaseMaxValue_ExpNegat()
            {
                //escenario
                int iBase = int.MaxValue;
                int iExp = -999;
                double sResultEsperado = 0;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BasePosit_Exp0()
            {
                //escenario
                int iBase = 2;
                int iExp = 0;
                double sResultEsperado = 1;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_Base0_Exp0()
            {
                //escenario
                int iBase = 0;
                int iExp = 0;
                double sResultEsperado = 1;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_Base0_ExpPosit()
            {
                //escenario
                int iBase = 0;
                int iExp = 3;
                double sResultEsperado = 0;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_Base0_ExpNegat()
            {
                //escenario
                int iBase = 0;
                int iExp = -3;
                double sResultEsperado = double.PositiveInfinity;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BaseNegat_ExpPosit()
            {
                //escenario
                int iBase = -2;
                int iExp = 3;
                double sResultEsperado = -8;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BaseMinValue_Exp9999999()
            {
                //escenario
                int iBase = int.MinValue; //-2147483647
                int iExp = 9999; //
                double sResultEsperado = double.NegativeInfinity;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BaseNegat_ExpNegat()
            {
                //escenario
                int iBase = -2;
                int iExp = -3;
                double sResultEsperado = -0.125;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BaseMinValue_ExpNegat()
            {
                //escenario
                int iBase = int.MinValue;
                int iExp = -999;
                double sResultEsperado = 0;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }

            [TestMethod]
            public void TestCalcularPotencia_BaseNegat_Exp0()
            {
                //escenario
                int iBase = -2;
                int iExp = 0;
                double sResultEsperado = 1;
                double sResultObtenido;

                //acción
                sResultObtenido = NavajaSuiza.Aplicación_4_PotenciaNumero.PotenciaLógica.CalcularPotencia(iBase, iExp);

                //afirmación
                Assert.AreEqual(sResultEsperado, sResultObtenido);
            }
        }
    }
}
