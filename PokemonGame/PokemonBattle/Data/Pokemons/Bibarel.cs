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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Simple(), new Abilities.Unaware() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moody() };
		public override Stats BaseStats => new Stats(79, 85, 60, 55, 60, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Watergun() },
			[1] = new List<Move>() { new Moves.Watergun(), new Moves.Aquajet(), new Moves.Tackle(), new Moves.Growl() },
			[5] = new List<Move>() { new Moves.Defensecurl() },
			[9] = new List<Move>() { new Moves.Rollout() },
			[13] = new List<Move>() { new Moves.Headbutt() },
			[18] = new List<Move>() { new Moves.Taunt() },
			[23] = new List<Move>() { new Moves.Yawn() },
			[28] = new List<Move>() { new Moves.Crunch() },
			[33] = new List<Move>() { new Moves.Takedown() },
			[38] = new List<Move>() { new Moves.Superfang() },
			[43] = new List<Move>() { new Moves.Swordsdance() },
			[48] = new List<Move>() { new Moves.Amnesia() },
			[53] = new List<Move>() { new Moves.Superpower() },
			[58] = new List<Move>() { new Moves.Curse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bulldoze(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Liquidation(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Workup() };
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