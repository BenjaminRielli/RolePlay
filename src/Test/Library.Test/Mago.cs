using NUnit.Framework;

using Roleplay;

namespace Test.Library
{


    public class MagoTests
    {
        [Test]
        public void Valores()
        {
            var mago = new Mago("mago", 100, 5, 10);

            Assert.AreEqual(mago.Defensa, 10);
            Assert.AreEqual(mago.Ataque, 5);

            mago.Túnica = new Túnica();

            Assert.AreEqual(mago.Defensa, 14);

            mago.BastónMágico = new BastónMágico();

            Assert.AreEqual(mago.Ataque, 6);
        }

        [Test]
        public void Atacar()
        {
            var mago = new Mago("mago", 100, 5, 10);

            mago.Atacar(20);

            Assert.AreEqual(90, mago.Vida);
        }

        [Test]
        public void Curar()
        {
            var mago = new Mago("mago", 100, 5, 10);

            mago.Curar(20);

            Assert.AreEqual(120, mago.Vida);
        }
    }


}