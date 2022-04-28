using System.Collections.Generic;

namespace Roleplay
{
    public class Libro
    {
        public List<Hechizo> Hechizos { get; }

        public void Agregar(Hechizo h)
        {
            Hechizos.Add(h);
        }

        public void Quitar(Hechizo h)
        {
            Hechizos.Remove(h);
        }
    }
}