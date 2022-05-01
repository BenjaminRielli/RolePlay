using System;

namespace Roleplay
{
    public class Duende
    {
        public string Nombre { get; }

        public int Vida { get; private set; }

        public int Ataque { get; }

        public int Defensa { get; }

        public Duende(string nombre, int vida, int ataque, int defensa)
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
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
    }
}
