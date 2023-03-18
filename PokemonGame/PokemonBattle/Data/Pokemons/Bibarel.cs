using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bibarel : Pokemon
	{
		public override string Name => "Bibarel";
		public override List<Ability> AvailableAbilities => new() {new Simple(), new Unaware() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moody() };
		public override Stats BaseStats => new Stats(79, 85, 60, 55, 60, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Watergun() },
			[1] = new List<Move>() { new Watergun(), new Aquajet(), new Tackle(), new Growl() },
			[5] = new List<Move>() { new Defensecurl() },
			[9] = new List<Move>() { new Rollout() },
			[13] = new List<Move>() { new Headbutt() },
			[18] = new List<Move>() { new Taunt() },
			[23] = new List<Move>() { new Yawn() },
			[28] = new List<Move>() { new Crunch() },
			[33] = new List<Move>() { new Takedown() },
			[38] = new List<Move>() { new Superfang() },
			[43] = new List<Move>() { new Swordsdance() },
			[48] = new List<Move>() { new Amnesia() },
			[53] = new List<Move>() { new Superpower() },
			[58] = new List<Move>() { new Curse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Bulldoze(), new Chargebeam(), new Confide(), new Covet(), new Cut(), new Dig(), new Dive(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Fling(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irontail(), new Lastresort(), new Liquidation(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockclimb(), new Rocksmash(), new Round(), new Scald(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Waterfall(), new Waterpulse(), new Workup() };
		public override int Weight => 315;
		public override int ExpYield => 144;
		public override int CatchRate => 127;
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