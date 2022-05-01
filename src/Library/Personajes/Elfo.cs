using System;

namespace Roleplay
{
    public class Elfo
    {
        public string Nombre { get; }

        public int Vida { get; private set; }

        public int Ataque
        {
            get => (Espada?.Ataque ?? 0)
                 + _ataqueBase;
        }

        public int Defensa
        {
            get => (Pantalón?.Defensa ?? 0)
                 + (Calzoncillo?.Defensa ?? 0)
                 + (Túnica?.Defensa ?? 0)
                 + _defensaBase;
        }

        public Espada Espada { get; set; } = null;

        public Pantalón Pantalón { get; set; } = null;

        public Calzoncillo Calzoncillo { get; set; } = null;

        public Túnica Túnica { get; set; } = null;

        private readonly int _defensaBase;

        private readonly int _ataqueBase;

        public Elfo(string nombre, int vida, int ataque, int defensa)
        {
            Nombre = nombre;
            Vida = Math.Max(0, vida);
            _ataqueBase = Math.Max(0, ataque);
            _defensaBase = Math.Max(0, defensa);
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