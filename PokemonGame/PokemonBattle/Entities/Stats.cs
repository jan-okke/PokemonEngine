namespace PokemonGame.PokemonBattle.Entities;

public class Stats
{
    public int HP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpecialAttack { get; set; }
    public int SpecialDefense { get; set; }
    public int Speed { get; set; }


    public int Evasion { get; set; }
    public int Accuracy { get; set; }

    public Stats() {
        HP = 0; Attack = 0; Defense = 0; SpecialAttack = 0; SpecialDefense = 0; Speed = 0;
        Evasion = 0; Accuracy = 0;
    }
    public Stats(int hp, int attack, int defense, int specialAttack, int specialDefense, int speed)
    {
        HP = hp;
        Attack = attack;
        Defense = defense;
        SpecialAttack = specialAttack;
        SpecialDefense = specialDefense;
        Speed = speed;

        Evasion= 0; Accuracy = 0;
    }
}