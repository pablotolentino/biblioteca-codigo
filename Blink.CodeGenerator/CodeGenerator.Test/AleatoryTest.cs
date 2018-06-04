using CodeGenerator.CodeAleatory;
using CodeGenerator.CodeConfiguration;

using CodeGenerator.Interfaces;
using Moq;
using System;
using Xunit;

namespace CodeGenerator.Test
{
    public class AleatoryTest
    {
        [Fact]
        public void Aleatorio_ConLongitudDefinida()
        {

            Configuration cg = new Configuration();
            cg.SetLength(8);
            Aleatory aleatory = new Aleatory();
            string c = aleatory.Generate(cg);
            Assert.False(string.IsNullOrEmpty(c), "No genera código");
        }

        [Fact]
        public void Aleatorio_SinLongitudDefinida()
        {

            Configuration cg = new Configuration();          
            Aleatory aleatory = new Aleatory();
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
    }

}
