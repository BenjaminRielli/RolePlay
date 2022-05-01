using NUnit.Framework;

using Roleplay;

namespace Test.Library
{


    public class EnanoTests
    {
        [Test]
        public void ValoresEnano()
        {
            var enano = new Enano("enano", 100, 5, 10);

            Assert.AreEqual(enano.Defensa, 10);
            Assert.AreEqual(enano.Ataque, 5);

            enano.Calzoncillo = new Calzoncillo();

            Assert.AreEqual(enano.Defensa, 11);

            enano.Chaleco = new Chaleco();

            Assert.AreEqual(enano.Defensa, 14);

            enano.Hacha = new Hacha();

            Assert.AreEqual(enano.Ataque, 15);
        }

        [Test]
        public void Atacar()
        {
            var enano = new Enano("enano", 100, 5, 10);

            enano.Atacar(20);

            Assert.AreEqual(90, enano.Vida);

            enano.Chaleco = new Chaleco();
            enano.Pantalón = new Pantalón();

            enano.Atacar(20);

            Assert.AreEqual(86, enano.Vida);
        }

        [Test]
        public void Curar()
        {
            var enano = new Enano("enano", 100, 5, 10);

            enano.Curar(20);

            Assert.AreEqual(120, enano.Vida);
        }
    }


}