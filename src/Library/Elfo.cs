namespace Roleplay
{
    public class Elfo
    {
        public Elfo(string name, int life, int attack, int defensa){
            this.Name = name;
            this.Life = life;
            this.Attack = attack;
            this.Defensa = defensa;
        }
        public string Name{ get; }
        public int Life{ get; private set; }
        public int Attack{ get; }
        public int Defensa{ get; }
        public void AttackEnemy(int n)
        {
            this.Life = Life - n;
        }
        public void Curar(int n)
        {
            this.Life = Life + n;
        }        
    }
}
