using System;

namespace Roleplay
{
    public class Mago
    {
        public string Nombre { get; }

        public int Vida { get; private set; }

        public int Ataque
        {
            get => (BastónMágico?.Ataque ?? 0)
                 + _ataqueBase;
        }

        public int Defensa
        {
            get => (Túnica?.Defensa ?? 0)
                 + _defensaBase;
        }

        public BastónMágico BastónMágico { get; set; }

        public Túnica Túnica { get; set; } = null;

        public Libro Libro { get; }

        private readonly int _defensaBase;

        private readonly int _ataqueBase;

        public Mago(string nombre, int vida, int ataque, int defensa)
        {
            Nombre = nombre;
            Vida = Math.Max(0, vida);
            Libro = new Libro();
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