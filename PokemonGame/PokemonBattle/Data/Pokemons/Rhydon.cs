using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rhydon : Pokemon
	{
		public override string Name => "Rhydon";
		public override List<Ability> AvailableAbilities => new() {new Lightningrod(), new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Reckless() };
		public override Stats BaseStats => new Stats(105, 130, 120, 40, 45, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Hammerarm() },
			[1] = new List<Move>() { new Hammerarm(), new Tackle(), new Tailwhip(), new Smackdown(), new Bulldoze() },
			[15] = new List<Move>() { new Hornattack() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Stomp() },
			[30] = new List<Move>() { new Rockblast() },
			[35] = new List<Move>() { new Drillrun() },
			[40] = new List<Move>() { new Takedown() },
			[47] = new List<Move>() { new Earthquake() },
			[54] = new List<Move>() { new Stoneedge() },
			[61] = new List<Move>() { new Megahorn() },
			[68] = new List<Move>() { new Horndrill() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Dragonpulse(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Heatcrash(), new Heavyslam(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icefang(), new Icepunch(), new Icywind(), new Irondefense(), new Irontail(), new Megahorn(), new Megakick(), new Megapunch(), new Meteorbeam(), new Mudshot(), new Outrage(), new Payback(), new Payday(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Roar(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scaryface(), new Scorchingsands(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Smartstrike(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderpunch(), new Uproar(), new Whirlpool() };
		public override int Weight => 1200;
		public override int ExpYield => 170;
		public override int CatchRate => 60;
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