﻿using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Data.Pokemons;

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

//Ability SnowWarning = new Ability("Snow Warning", "---");

Pokemon Abomasnow1 = new Abomasnow(level: 50); //new Pokemon("Abomasnow", 100, new Stats(90, 92, 75, 92, 85, 60), SnowWarning, new List<PokemonType>() { PokemonType.Ice, PokemonType.Grass} );
Pokemon Abomasnow2 = new Abomasnow(level: 50); // new Pokemon("Abomasnow", 100, new Stats(90, 92, 75, 92, 85, 60), SnowWarning, new List<PokemonType>() { PokemonType.Ice, PokemonType.Grass} );

Console.WriteLine(Abomasnow1.GetType() == typeof(Abomasnow));

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


Move Blizzard = new Move("Blizzard", 110, 5, PokemonType.Normal, MoveCategory.Special);
Move GigaDrain = new Move("Giga Drain", 75, 10, PokemonType.Grass, MoveCategory.Special);
Move LeechSeed = new Move("Leech Seed", 0, 10, PokemonType.Grass, MoveCategory.Status);
Move AuroraVeil = new Move("Aurora Veil", 0, 10, PokemonType.Ice, MoveCategory.Status);

Abomasnow2.LearnMove(Blizzard);
Abomasnow2.LearnMove(GigaDrain);
Abomasnow2.LearnMove(LeechSeed);
Abomasnow2.LearnMove(AuroraVeil);

PokemonParty playerParty = new(new List<Pokemon>() { Abomasnow1 });
PokemonParty enemyParty = new(new List<Pokemon>() { Abomasnow2 });

var battle = BattleActions.StartWildBattle(playerParty, Abomasnow2);

while (battle.IsOngoing)
{
    battle.ActiveBattlers.ForEach(p => DebugConsole.WriteLine($"{p.Name} {p.CurrentHP} {p.GetHPPercentage()}"));
    battle.UseMove(Abomasnow1, Abomasnow2, Blizzard);
}
//AssertEqual(battle.CalculateDamage(true, Blizzard).Value, 160);