using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Quagsire : Pokemon
	{
		public override string Name => "Quagsire";
		public override List<Ability> AvailableAbilities => new() {new Damp(), new Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unaware() };
		public override Stats BaseStats => new Stats(95, 85, 85, 35, 65, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Tailwhip(), new Raindance(), new Mudshot() },
			[12] = new List<Move>() { new Mist(), new Haze() },
			[16] = new List<Move>() { new Slam() },
			[23] = new List<Move>() { new Yawn() },
			[28] = new List<Move>() { new Aquatail() },
			[34] = new List<Move>() { new Muddywater() },
			[40] = new List<Move>() { new Amnesia() },
			[46] = new List<Move>() { new Toxic() },
			[52] = new List<Move>() { new Earthquake() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Earthquake(), new Eerieimpulse(), new Encore(), new Endure(), new Facade(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Guardswap(), new Hail(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Liquidation(), new Megakick(), new Megapunch(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scald(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Toxic(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 750;
		public override int ExpYield => 151;
		public override int CatchRate => 90;
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