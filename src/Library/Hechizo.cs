namespace Roleplay
{
    public class Hechizo
    {
        public string Nombre { get; }

        public int Ataque { get; }

        public int Defensa { get; }
        
        Hechizo(string nombre, int ataque, int defensa)
        {
            Nombre = nombre;
            Ataque = ataque;
            Defensa = defensa;
        }
    }
}