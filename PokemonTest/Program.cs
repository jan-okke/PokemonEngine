using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame;

void AssertEqual<T>(T actual, T expected) {
    var result = actual == null || expected == null ? false : actual.Equals(expected);
    if (!result) {
        DebugConsole.WriteLine($"Assertion failed! Expected: {expected}. Actual: {actual} ", ConsoleColor.Red);
    }
}

Pokemon p = new Pokemon("Bulbasaur", 10, new Stats() {HP = 45, Attack = 49, Defense = 49, SpecialAttack = 65, SpecialDefense = 65, Speed = 45});
AssertEqual(p.Stats.HP, 29);
AssertEqual(p.Stats.Attack, 14);
