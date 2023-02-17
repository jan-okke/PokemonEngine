using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame;
using PokemonGame.PokemonBattle.Enums;

static void AssertEqual<T>(T actual, T expected) 
{
    var result = actual != null && expected != null && actual.Equals(expected);
    if (!result) 
    {
        DebugConsole.WriteLine($"Assertion failed! Expected: {expected}. Actual: {actual} ", ConsoleColor.Red);
    }
}

//Pokemon p = new Pokemon("Bulbasaur", 10, new Stats() {HP = 45, Attack = 49, Defense = 49, SpecialAttack = 65, SpecialDefense = 65, Speed = 45});
//AssertEqual(p.Stats.HP, 29);
//AssertEqual(p.Stats.Attack, 14);

Ability SnowWarning = new Ability("Snow Warning", "---");

Pokemon Abomasnow = new Pokemon("Abomasnow", 100, new Stats(90, 92, 75, 92, 85, 60), SnowWarning, new List<PokemonType>() { PokemonType.Ice, PokemonType.Grass} );
Pokemon Abomasnow2 = new Pokemon("Abomasnow", 100, new Stats(90, 92, 75, 92, 85, 60), SnowWarning, new List<PokemonType>() { PokemonType.Ice, PokemonType.Grass} );

Abomasnow.MaxIVS();
Abomasnow2.MaxIVS();
Abomasnow.EVs.HP = 248;
Abomasnow.EVs.SpecialAttack = 252;
Abomasnow.EVs.SpecialDefense = 8;
Abomasnow2.EVs.HP = 248;
Abomasnow2.EVs.SpecialAttack = 252;
Abomasnow2.EVs.SpecialDefense = 8;

Abomasnow.CalculateStats();
Abomasnow2.CalculateStats();

Abomasnow.HealHP();
Abomasnow2.HealHP();

Move Blizzard = new Move("Spit Up", 110, 5, PokemonType.Normal, MoveCategory.Special);
Move GigaDrain = new Move("Giga Drain", 75, 10, PokemonType.Grass, MoveCategory.Special);
Move LeechSeed = new Move("Leech Seed", 0, 10, PokemonType.Grass, MoveCategory.Status);
Move AuroraVeil = new Move("Aurora Veil", 0, 10, PokemonType.Ice, MoveCategory.Status);

PokemonParty playerParty = new(new List<Pokemon>() { Abomasnow });
PokemonParty enemyParty = new(new List<Pokemon>() { Abomasnow2 });

Battle battle = new Battle(playerParty, enemyParty);
AssertEqual(battle.CalculateDamage(true, Blizzard).Value, 160);