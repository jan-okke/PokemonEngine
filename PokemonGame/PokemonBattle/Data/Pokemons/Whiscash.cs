using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Whiscash : Pokemon
	{
		public override string Name => "Whiscash";
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Anticipation() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(110, 78, 73, 76, 71, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Thrash() },
			[1] = new List<Move>() { new Thrash(), new Belch(), new Zenheadbutt(), new Tickle(), new Mudslap(), new Watergun(), new Rest(), new Snore() },
			[12] = new List<Move>() { new Waterpulse() },
			[18] = new List<Move>() { new Amnesia() },
			[24] = new List<Move>() { new Aquatail() },
			[33] = new List<Move>() { new Muddywater() },
			[40] = new List<Move>() { new Earthquake() },
			[48] = new List<Move>() { new Futuresight() },
			[56] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bounce(), new Bulldoze(), new Dive(), new Doubleteam(), new Dragondance(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Futuresight(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Liquidation(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scald(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Uproar(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Zenheadbutt() };
		public override int Weight => 236;
		public override int ExpYield => 164;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}