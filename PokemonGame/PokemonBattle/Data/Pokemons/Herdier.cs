using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Herdier : Pokemon
{
	public override string Name => "Herdier";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Sandrush() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Scrappy() };
	public override Stats BaseStats => new Stats(65, 80, 65, 35, 65, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer(), new Moves.Workup(), new Moves.Bite() },
		[12] = new List<Move>() { new Moves.Retaliate() },
		[19] = new List<Move>() { new Moves.Babydolleyes() },
		[24] = new List<Move>() { new Moves.Playrough() },
		[30] = new List<Move>() { new Moves.Crunch() },
		[36] = new List<Move>() { new Moves.Takedown() },
		[42] = new List<Move>() { new Moves.Helpinghand() },
		[48] = new List<Move>() { new Moves.Reversal() },
		[54] = new List<Move>() { new Moves.Roar() },
		[60] = new List<Move>() { new Moves.Lastresort() },
		[66] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Charm(), new Moves.Crunch(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Payback(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Wildcharge(), new Moves.Workup() };
	public override int Weight => 147;
	public override int ExpYield => 130;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}