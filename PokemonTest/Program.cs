

/*
static void AssertEqual<T>(T actual, T expected) 
{
    var result = actual != null && expected != null && actual.Equals(expected);
    if (!result) 
    {
        DebugConsole.WriteLine($"Assertion failed! Expected: {expected}. Actual: {actual} ", ConsoleColor.Red);
    }
}
*/
//new ConsoleTest();

//Pokemon p = new Pokemon("Bulbasaur", 10, new Stats() {HP = 45, Attack = 49, Defense = 49, SpecialAttack = 65, SpecialDefense = 65, Speed = 45});
//AssertEqual(p.Stats.HP, 29);
//AssertEqual(p.Stats.Attack, 14);

//Ability SnowWarning = new Ability("Snow Warning", "---");

/*

Pokemon Abomasnow1 = new Abomasnow(level: 50); //new Pokemon("Abomasnow", 100, new Stats(90, 92, 75, 92, 85, 60), SnowWarning, new List<PokemonType>() { PokemonType.Ice, PokemonType.Grass} );
Pokemon Abomasnow2 = new Abomasnow(level: 50); // new Pokemon("Abomasnow", 100, new Stats(90, 92, 75, 92, 85, 60), SnowWarning, new List<PokemonType>() { PokemonType.Ice, PokemonType.Grass} );


Abomasnow1.MaxIVS();
Abomasnow2.MaxIVS();
Abomasnow1.EVs.HP = 248;
Abomasnow1.EVs.SpecialAttack = 252;
Abomasnow1.EVs.SpecialDefense = 8;
Abomasnow2.EVs.HP = 248;
Abomasnow2.EVs.SpecialAttack = 252;
Abomasnow2.EVs.SpecialDefense = 8;

Abomasnow1.CalculateStats();
Abomasnow2.CalculateStats();

Abomasnow1.HealHP();
Abomasnow2.HealHP();


//Move Blizzard = new Move("Blizzard", 110, 5, PokemonType.Normal, MoveCategory.Special);
Move GigaDrain = new Move("Giga Drain", "Drains your ass", 75, 10, PokemonType.Grass, MoveCategory.Special);
Move LeechSeed = new Move("Leech Seed", "Seeds your ass", 0, 10, PokemonType.Grass, MoveCategory.Status);
Move AuroraVeil = new Move("Aurora Veil", "Requires hail lol", 0, 10, PokemonType.Ice, MoveCategory.Status);

Abomasnow2.LearnMove(Move.GetMove("Blizzard"));
Abomasnow2.LearnMove(GigaDrain);
Abomasnow2.LearnMove(LeechSeed);
Abomasnow2.LearnMove(AuroraVeil);

Abomasnow1.LearnMove(new Blizzard());

PokemonParty playerParty = new(new List<Pokemon>() { Abomasnow1 });
PokemonParty enemyParty = new(new List<Pokemon>() { Abomasnow2 });

var battle = BattleActions.StartWildBattle(playerParty, Abomasnow2);

while (battle.IsOngoing)
{
    battle.ActiveBattlers.ForEach(p => DebugConsole.WriteLine($"{p.Name} {p.CurrentHP} ({p.GetHPPercentage()}%)"));
    battle.UseMove(Abomasnow1, Abomasnow2, Abomasnow1.FindMove("Blizzard"));
}

foreach (var d in battle.Log.Data) {
    DebugConsole.WriteLine("=====");
    foreach (var key in d.Data.Keys) {
        DebugConsole.WriteLine($"{key}: {d.Data[key]}");
    }
}
AssertEqual(battle.IsOngoing, false);
//AssertEqual(battle.CalculateDamage(true, Blizzard).Value, 160);

*/

namespace PokemonTest;

// TODO => Make a Console Program for testing it where you can move around maps etc

public abstract class Program
{
    public static void Main(string[] args)
    {
        //TestCase1();
        var consoleTest = new ConsoleTest();
    }

}