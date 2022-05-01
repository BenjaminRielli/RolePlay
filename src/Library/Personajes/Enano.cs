using System;

namespace Roleplay
{
    public class Enano
    {
        public string Nombre { get; }

        public int Vida { get; private set; }

        public int Ataque
        {
            get => (Hacha?.Ataque ?? 0)
                 + (Daga?.Ataque ?? 0)
                 + _ataqueBase;
        }

        public int Defensa
        {
            get => (Pantalón?.Defensa ?? 0)
                 + (Calzoncillo?.Defensa ?? 0)
                 + (Chaleco?.Defensa ?? 0)
                 + _defensaBase;
        }

        public Hacha Hacha { get; set; } = null;

        public Daga Daga { get; set; } = null;

        public Chaleco Chaleco { get; set; } = null;

        public Pantalón Pantalón { get; set; } = null;

        public Calzoncillo Calzoncillo { get; set; } = null;

        private readonly int _defensaBase;

        private readonly int _ataqueBase;

        public Enano(string nombre, int vida, int ataque, int defensa)
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