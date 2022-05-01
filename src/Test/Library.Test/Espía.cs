using NUnit.Framework;

using Roleplay;

namespace Test.Library
{


    public class EspíaTests
    {
        [Test]
        public void Valores()
        {
            var espía = new Espía("espía", 100, 5, 10);

            Assert.AreEqual(espía.Defensa, 10);
            Assert.AreEqual(espía.Ataque, 5);
        }

        [Test]
        public void Atacar()
        {
            var espía = new Espía("espía", 100, 5, 10);

            espía.Atacar(20);

            Assert.AreEqual(90, espía.Vida);
        }

        [Test]
        public void Curar()
        {
            var espía = new Espía("espía", 100, 5, 10);

            espía.Curar(20);

            Assert.AreEqual(120, espía.Vida);
        }
    }


}