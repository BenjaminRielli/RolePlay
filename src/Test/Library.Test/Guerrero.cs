using NUnit.Framework;

using Roleplay;

namespace Test.Library
{


    public class GuerreroTests
    {
        [Test]
        public void Valores()
        {
            var guerrero = new Guerrero("guerrero", 100, 5, 10);

            Assert.AreEqual(guerrero.Defensa, 10);
            Assert.AreEqual(guerrero.Ataque, 5);

            guerrero.Armadura = new Armadura();

            Assert.AreEqual(23, guerrero.Defensa);

            guerrero.Espada = new Espada();

            Assert.AreEqual(15, guerrero.Ataque);
        }
    }


}