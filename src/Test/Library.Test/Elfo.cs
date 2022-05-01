using NUnit.Framework;

using Roleplay;

namespace Test.Library
{


    public class ElfoTests
    {
        [Test]
        public void Valores()
        {
            var elfo = new Elfo("elfo", 100, 5, 10);

            Assert.AreEqual(elfo.Defensa, 10);
            Assert.AreEqual(elfo.Ataque, 5);

            elfo.Calzoncillo = new Calzoncillo();

            Assert.AreEqual(elfo.Defensa, 11);

            elfo.Espada = new Espada();

            Assert.AreEqual(elfo.Ataque, 15);
        }

        [Test]
        public void Atacar()
        {
            var elfo = new Elfo("elfo", 100, 5, 10);

            elfo.Atacar(20);

            Assert.AreEqual(90, elfo.Vida);

            elfo.Pantalón = new Pantalón();

            elfo.Atacar(20);

            Assert.AreEqual(83, elfo.Vida);
        }

        [Test]
        public void Curar()
        {
            var elfo = new Elfo("elfo", 100, 5, 10);

            elfo.Curar(20);

            Assert.AreEqual(120, elfo.Vida);
        }
    }


}