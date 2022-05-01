using System;

namespace Roleplay
{
    public class Duende
    {
        public string Nombre { get; }

        public int Vida { get; private set; }

        public int Ataque
        {
            get => (Daga?.Ataque ?? 0)
                 + _ataqueBase;
        }

        public int Defensa
        {
            get => (Calzoncillo?.Defensa ?? 0)
                 + _defensaBase;
        }

        public Daga Daga { get; set; } = null;

        public Calzoncillo Calzoncillo { get; set; } = null;

        private readonly int _defensaBase;

        private readonly int _ataqueBase;

        public Duende(string nombre, int vida, int ataque, int defensa)
        {
            Nombre = nombre;
            Vida = Math.Max(0, vida);
            _ataqueBase = Math.Max(0, ataque);
            _defensaBase = Math.Max(0, defensa);
        }

        public void Atacar(int ataque)
        {
            var ataqueNeto = Math.Max(0, ataque - Defensa);

            Vida = Math.Max(0, Vida - ataqueNeto);
        }

        public void Curar(int vida)
        {
            Vida += vida;
        }
    }
}
