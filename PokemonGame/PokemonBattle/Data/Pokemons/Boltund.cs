using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Boltund : Pokemon
{
	public override string Name => "Boltund";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Strongjaw() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Competitive() };
	public override Stats BaseStats => new Stats(69, 90, 60, 90, 60, 121);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Electrify(), new Moves.Tackle(), new Moves.Tailwhip(), new Moves.Nuzzle(), new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Roar() },
		[20] = new List<Move>() { new Moves.Spark() },
		[28] = new List<Move>() { new Moves.Charm() },
		[34] = new List<Move>() { new Moves.Crunch() },
		[41] = new List<Move>() { new Moves.Charge() },
		[48] = new List<Move>() { new Moves.Wildcharge() },
		[55] = new List<Move>() { new Moves.Playrough() },
		[62] = new List<Move>() { new Moves.Electricterrain() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bulkup(), new Moves.Charm(), new Moves.Crunch(), new Moves.Dig(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 340;
	public override int ExpYield => 172;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}