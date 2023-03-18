using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stoutland : Pokemon
	{
		public override string Name => "Stoutland";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Sandrush() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Scrappy() };
		public override Stats BaseStats => new Stats(85, 110, 90, 45, 90, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Icefang(), new Moves.Firefang(), new Moves.Thunderfang(), new Moves.Tackle(), new Moves.Leer(), new Moves.Workup(), new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Retaliate() },
			[19] = new List<Move>() { new Moves.Babydolleyes() },
			[24] = new List<Move>() { new Moves.Playrough() },
			[30] = new List<Move>() { new Moves.Crunch() },
			[38] = new List<Move>() { new Moves.Takedown() },
			[46] = new List<Move>() { new Moves.Helpinghand() },
			[54] = new List<Move>() { new Moves.Reversal() },
			[62] = new List<Move>() { new Moves.Roar() },
			[70] = new List<Move>() { new Moves.Lastresort() },
			[78] = new List<Move>() { new Moves.Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Charm(), new Moves.Crunch(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Ironhead(), new Moves.Payback(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Wildcharge(), new Moves.Workup() };
		public override int Weight => 610;
		public override int ExpYield => 250;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}