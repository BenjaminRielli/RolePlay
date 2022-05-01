using System;

namespace Roleplay
{
    public class Espía
    {
        public string Nombre { get; }

        public int Vida { get; private set; }

        public int Ataque { get; }

        public int Defensa { get; }

        public Espía(string nombre, int vida, int ataque, int defensa)
        {
            Nombre = nombre;
            Vida = Math.Max(0, vida);
            Ataque = Math.Max(0, ataque);
            Defensa = Math.Max(0, defensa);
        }

        void Atacar(int ataque)
        {
            var ataqueNeto = Math.Max(0, ataque - Defensa);

            Vida = Math.Max(0, Vida - ataqueNeto);
        }

        void Curar(int vida)
        {
            Vida += vida;
        }

        void Suicidar()
        {
            Vida = 0;
        }
    }
}