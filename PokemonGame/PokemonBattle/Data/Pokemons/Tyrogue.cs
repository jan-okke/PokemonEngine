using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tyrogue : Pokemon
{
	public override string Name => "Tyrogue";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Guts(), new Abilities.Steadfast() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Vitalspirit() };
	public override Stats BaseStats => new Stats(35, 35, 35, 35, 35, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Helpinghand(), new Moves.Fakeout(), new Moves.Focusenergy() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Uproar(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bulletpunch(), new Moves.Counter(), new Moves.Feint(), new Moves.Helpinghand(), new Moves.Highjumpkick(), new Moves.Machpunch(), new Moves.Mindreader(), new Moves.Rapidspin(), new Moves.Vacuumwave() };
	public override int Weight => 210;
	public override int ExpYield => 42;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}