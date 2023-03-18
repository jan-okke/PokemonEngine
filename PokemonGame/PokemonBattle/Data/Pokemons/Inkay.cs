using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Inkay : Pokemon
	{
		public override string Name => "Inkay";
		public override List<Ability> AvailableAbilities => new() {new Contrary(), new Suctioncups() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(53, 54, 53, 45, 37, 46);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Tackle() },
			[3] = new List<Move>() { new Hypnosis() },
			[6] = new List<Move>() { new Wrap() },
			[9] = new List<Move>() { new Payback() },
			[12] = new List<Move>() { new Pluck() },
			[15] = new List<Move>() { new Psybeam() },
			[18] = new List<Move>() { new Swagger() },
			[21] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Nightslash() },
			[27] = new List<Move>() { new Psychocut() },
			[31] = new List<Move>() { new Switcheroo() },
			[33] = new List<Move>() { new Foulplay() },
			[36] = new List<Move>() { new Topsyturvy() },
			[39] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Batonpass(), new Calmmind(), new Darkpulse(), new Endure(), new Expandingforce(), new Facade(), new Faketears(), new Flamethrower(), new Fling(), new Foulplay(), new Futuresight(), new Guardswap(), new Hiddenpower(), new Lashout(), new Lightscreen(), new Liquidation(), new Nastyplot(), new Payback(), new Protect(), new Psychic(), new Psychocut(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Rockslide(), new Round(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thief(), new Thunderbolt(), new Trickroom() };
		public override List<Move> EggMoves => new List<Move>() { new Acupressure(), new Destinybond(), new Disable() };
		public override int Weight => 35;
		public override int ExpYield => 58;
		public override int CatchRate => 190;
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
}