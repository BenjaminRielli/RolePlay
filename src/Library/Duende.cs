using System;

namespace Program
{
    public class Duende
    {
        public Duende(string name, int life, int attack, int defensa){
            this.Name = name;
            this.Life = life;
            this.Attack = attack;
            this.Defensa = defensa;
        }
        public string Name{ get; }
        public int Life{ get; private set; }
        public int Attack{ get; }
        public int Defensa{ get; }
        public void Curar(int n)
        {
            this.Life = Life + n;
        }
    }
}