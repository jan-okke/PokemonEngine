using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cranidos : Pokemon
	{
		public override string Name => "Cranidos";
		public override List<Ability> AvailableAbilities => new() {new Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(67, 125, 40, 30, 30, 58);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Headbutt(), new Leer() },
			[6] = new List<Move>() { new Focusenergy() },
			[10] = new List<Move>() { new Rockpolish() },
			[15] = new List<Move>() { new Takedown() },
			[19] = new List<Move>() { new Scaryface() },
			[24] = new List<Move>() { new Assurance() },
			[28] = new List<Move>() { new Swordsdance() },
			[33] = new List<Move>() { new Ancientpower() },
			[37] = new List<Move>() { new Zenheadbutt() },
			[42] = new List<Move>() { new Screech() },
			[46] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endeavor(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Frustration(), new Hiddenpower(), new Icebeam(), new Ironhead(), new Irontail(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Smackdown(), new Snore(), new Spite(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Uproar(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Crunch(), new Curse(), new Doubleedge(), new Hammerarm(), new Ironhead(), new Leer(), new Slam(), new Stomp(), new Thrash(), new Whirlwind() };
		public override int Weight => 315;
		public override int ExpYield => 70;
		public override int CatchRate => 45;
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