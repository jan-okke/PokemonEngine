using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Herdier : Pokemon
	{
		public override string Name => "Herdier";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Sandrush() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Scrappy() };
		public override Stats BaseStats => new Stats(65, 80, 65, 35, 65, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer(), new Workup(), new Bite() },
			[12] = new List<Move>() { new Retaliate() },
			[19] = new List<Move>() { new Babydolleyes() },
			[24] = new List<Move>() { new Playrough() },
			[30] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Takedown() },
			[42] = new List<Move>() { new Helpinghand() },
			[48] = new List<Move>() { new Reversal() },
			[54] = new List<Move>() { new Roar() },
			[60] = new List<Move>() { new Lastresort() },
			[66] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Charm(), new Crunch(), new Dig(), new Endure(), new Facade(), new Firefang(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icefang(), new Payback(), new Playrough(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Retaliate(), new Reversal(), new Rocktomb(), new Round(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Surf(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Uproar(), new Wildcharge(), new Workup() };
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
}