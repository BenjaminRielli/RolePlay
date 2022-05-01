using NUnit.Framework;

using Roleplay;

namespace Test.Library
{


    public class LadrónTests
    {
        [Test]
        public void Valores()
        {
            var ladrón = new Ladrón("ladrón", 100, 5, 10);

            Assert.AreEqual(ladrón.Defensa, 10);
            Assert.AreEqual(ladrón.Ataque, 5);

            ladrón.Chaleco = new Chaleco();

            Assert.AreEqual(ladrón.Defensa, 13);

            ladrón.Daga = new Daga();

            Assert.AreEqual(ladrón.Ataque, 11);
        }

        [Test]
        public void Atacar()
        {
            var ladrón = new Ladrón("ladrón", 100, 5, 10);

            ladrón.Atacar(20);

            Assert.AreEqual(90, ladrón.Vida);

            ladrón.Chaleco = new Chaleco();

            ladrón.Atacar(20);

            Assert.AreEqual(83, ladrón.Vida);
        }

        [Test]
        public void Curar()
        {
            var ladrón = new Ladrón("ladrón", 100, 5, 10);

            ladrón.Curar(20);

            Assert.AreEqual(120, ladrón.Vida);
        }
    }


}