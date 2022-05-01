using System;

namespace Roleplay
{
    /*
    Para los personajes decidimos mantenerlo simple, cada personaje es asignado un valor de ataque y 
    defensa cuando es creado y cada uno tiene la responsabilidad de curarse y atacarse a si mismo, 
    para el ataque recibiendo el valor de ataque del personaje del cual lo recibe, y la curación 
    llenando su vida según el valor recibido, esta decisión fue tomada para evitar tener que añadir nuevos 
    métodos a cada clase cada vez que se añadiera un nuevo tipo de personajes.
    */
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