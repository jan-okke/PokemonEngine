using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame;
using PokemonGame.PokemonBattle.Enums;
using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Data.Pokemons;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Handles;
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

namespace Test
{
    public class Program {
        public static void Main(string[] args) {
            TestCase1();
        }

        static void TestCase1() {
            var attacker = new TestPokemon();
            var defender = new TestPokemon();

            attacker.OnLevelUp(attacker.Level, 50);
            defender.OnLevelUp(attacker.Level, 50);

            attacker.CalculateStats();
            defender.CalculateStats();
            attacker.HealHP();
            defender.HealHP();

            attacker.LearnMove(new TestMove());
            defender.LearnMove(new TestMove());

            attacker.Moves[0].RestorePowerPoints();
            defender.Moves[0].RestorePowerPoints();

            var playerParty = new PokemonParty(attacker);

            var battle = BattleActions.StartWildBattle(playerParty, defender);

            DebugConsole.WriteLine(attacker.CurrentHP);
            DebugConsole.WriteLine(defender.CurrentHP, ConsoleColor.Yellow);
            for (int i = 0; i < 5; i++) {
            battle.UseMove(attacker, defender, attacker.FindMove("Test"));

            DebugConsole.WriteLine("After", ConsoleColor.Green);

            DebugConsole.WriteLine(attacker.CurrentHP);
            DebugConsole.WriteLine(defender.CurrentHP, ConsoleColor.Yellow);
            }

            foreach (BattleData d in battle.Log.Data) {
                DebugConsole.WriteLine("{");
                foreach (var key in d.Data.Keys) {
                    DebugConsole.WriteLine($"  {key}: {d.Data[key]}");
                }
                DebugConsole.WriteLine("}");
            }
        }
    }
    
    public class TestPokemon : Pokemon
    {
        public override Stats BaseStats => new Stats(70, 70, 70, 70, 70, 70);
        public override Ability Ability => new TestAbility();
        public override string Name => "Test";
        public override ExperienceGroup ExperienceGroup => ExperienceGroup.Normal;
        public override List<PokemonType> Types => new List<PokemonType> { PokemonType.Fire, PokemonType.Flying };
    }

    public class TestAbility : Ability
    {
        public override string Name => "Test";
        public override string Description => "Test";
    }

    public class TestMove : Move
    {
        public override int BasePower => 50;
        public override MoveCategory Category => MoveCategory.Phsyical;
        public override string Description => "Test";
        public override bool HasAdditionalEffect => false;
        public override string Name => "Test";
        public override int PowerPoints => 15;
        public override int Priority => 0;
        public override PokemonType Type => PokemonType.Fire;
    }
}