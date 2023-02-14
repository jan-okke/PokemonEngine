namespace PokemonGame.PokemonBattle.Entities 
{
    public class Stats
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }

        public Stats() {
            HP = 0; Attack = 0; Defense = 0; SpecialAttack = 0; SpecialDefense = 0; Speed = 0;
        }
    }
}