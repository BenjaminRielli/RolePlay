namespace Roleplay
{
    /*
    Para los objetos, aunque son todos extremadamente similares, decidimos hacerlo de 
    esta manera dada la falta de herencia, cada personaje tiene un conjunto predeterminado 
    de objetos que se pueden equipar, dado que sin la capacidad de hacer que todos compartan 
    una clase padre es imposible añadir nuevos tipos de objetos a clases que no lo tienen codeado.
    */
    public class Túnica
    {
        public int Defensa { get; } = 4;
    }
}