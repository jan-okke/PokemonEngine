using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rampardos : Pokemon
	{
		public override string Name => "Rampardos";
		public override List<Ability> AvailableAbilities => new() {new Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(97, 165, 60, 58, 65, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Endeavor() },
			[1] = new List<Move>() { new Endeavor(), new Headbutt(), new Leer(), new Focusenergy() },
			[6] = new List<Move>() { new Focusenergy() },
			[10] = new List<Move>() { new Rockpolish() },
			[15] = new List<Move>() { new Takedown() },
			[19] = new List<Move>() { new Scaryface() },
			[24] = new List<Move>() { new Assurance() },
			[28] = new List<Move>() { new Swordsdance() },
			[36] = new List<Move>() { new Ancientpower() },
			[43] = new List<Move>() { new Zenheadbutt() },
			[51] = new List<Move>() { new Screech() },
			[58] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Brickbreak(), new Bulldoze(), new Confide(), new Cut(), new Dig(), new Doubleteam(), new Dragonpulse(), new Dragontail(), new Earthpower(), new Earthquake(), new Endeavor(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Ironhead(), new Irontail(), new Laserfocus(), new Outrage(), new Painsplit(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Smackdown(), new Snore(), new Spite(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Uproar(), new Zenheadbutt() };
		public override int Weight => 1025;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
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