using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Malamar : Pokemon
	{
		public override string Name => "Malamar";
		public override List<Ability> AvailableAbilities => new() {new Contrary(), new Suctioncups() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(86, 92, 88, 68, 75, 73);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Reversal(), new Peck(), new Tackle(), new Hypnosis(), new Wrap() },
			[9] = new List<Move>() { new Payback() },
			[12] = new List<Move>() { new Pluck() },
			[15] = new List<Move>() { new Psybeam() },
			[18] = new List<Move>() { new Swagger() },
			[21] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Nightslash() },
			[27] = new List<Move>() { new Psychocut() },
			[33] = new List<Move>() { new Switcheroo() },
			[37] = new List<Move>() { new Foulplay() },
			[42] = new List<Move>() { new Topsyturvy() },
			[47] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Batonpass(), new Brutalswing(), new Calmmind(), new Darkpulse(), new Endure(), new Expandingforce(), new Facade(), new Faketears(), new Flamethrower(), new Fling(), new Foulplay(), new Futuresight(), new Gigaimpact(), new Guardswap(), new Hiddenpower(), new Hyperbeam(), new Lashout(), new Lightscreen(), new Liquidation(), new Nastyplot(), new Payback(), new Protect(), new Psychic(), new Psychocut(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Reversal(), new Rockslide(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thief(), new Throatchop(), new Thunderbolt(), new Trickroom() };
		public override int Weight => 470;
		public override int ExpYield => 169;
		public override int CatchRate => 80;
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