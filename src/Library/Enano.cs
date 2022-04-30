using System;
namespace Roleplay
{
    public class Enano
    {
        public Enano(string nombre, int vida, int ataque, int defensa)
        {
            //List<Elemento> ElementosAdquiridos = new List<Elemento>();

            this.Nombre = nombre;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
        //private List<Elemento> ElementosAdquiridos {get; set; } 
        public string Nombre { get; }
        public int Vida { get; set; }
        public int Ataque { get; }
        public int Defensa { get; }

        /* public void Equipar(Elemento elemento){
            // agregar elemento a lista de elementos
            ElementosAdquiridos.Add(elemento);
            
        }
        public void Desequipar(Elemento elemento){
            // desequipar elemento de lista
            ElementosAdquiridos.Remove(elemento);
        }
        public void Atacar(){
            // atacar           
        }
        public void Hechizar(){
            // hechizar
        } */
    }

}