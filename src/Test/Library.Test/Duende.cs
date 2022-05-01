using NUnit.Framework;

using Roleplay;

namespace Test.Library
{


    public class DuendeTests
    {
        [Test]
        public void Valores()
        {
            var duende = new Duende("duende", 100, 5, 10);

            Assert.AreEqual(duende.Defensa, 10);
            Assert.AreEqual(duende.Ataque, 5);

            duende.Calzoncillo = new Calzoncillo();

            Assert.AreEqual(duende.Defensa, 11);

            duende.Daga = new Daga();

            Assert.AreEqual(duende.Ataque, 11);
        }

        [Test]
        public void Atacar()
        {
            var duende = new Duende("duende", 100, 5, 10);

            duende.Atacar(20);

            Assert.AreEqual(90, duende.Vida);
        }

        [Test]
        public void Curar()
        {
            var duende = new Duende("duende", 100, 5, 10);

            duende.Curar(20);

            Assert.AreEqual(120, duende.Vida);
        }
    }


}