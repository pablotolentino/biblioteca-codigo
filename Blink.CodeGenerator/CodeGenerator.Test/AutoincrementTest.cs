using CodeGenerator.CodeAutoincrement;
using CodeGenerator.CodeConfiguration;
using System;
using Xunit;

namespace CodeGenerator.Test
{
    public class AutoincrementTest
    {
        [Fact]
        public void Autoincremento_LetraNumeros()
        {

            Configuration cg = new Configuration();         
            cg.SetStartingFrom("SOL00001");
            Autoincrement aleatory = new Autoincrement();
            string c = aleatory.Generate(cg);
            Assert.False(string.IsNullOrEmpty(c), "No genera código");
        }
        [Fact]
        public void Autoincremento_Solonumeros()
        {

            Configuration cg = new Configuration();
            cg.SetStartingFrom("00001");
            Autoincrement aleatory = new Autoincrement();
            string c = aleatory.Generate(cg);
            Assert.False(string.IsNullOrEmpty(c), "No genera código");
        }
        [Fact]
        public void Autoincremento_SoloLetras()
        {

            Configuration cg = new Configuration();
            cg.SetStartingFrom("SOLICITUD");
            Autoincrement aleatory = new Autoincrement();
            try
            {
                string c = aleatory.Generate(cg);
                Assert.False(!string.IsNullOrEmpty(c), "No debe generar código");
            }
            catch (Exception ex)
            {
                return;
            }
         
        }

        [Fact]
        public void AutoincrementoAfiliado()
        {

            Configuration cg = new Configuration();         
            cg.SetStartingFrom("AFF00001");
            Autoincrement aleatory = new Autoincrement();
            string c = aleatory.Generate(cg);
            Assert.False(string.IsNullOrEmpty(c), "No genera código");
        }
    }

}
