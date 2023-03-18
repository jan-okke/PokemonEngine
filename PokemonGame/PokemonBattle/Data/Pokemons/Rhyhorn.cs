using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rhyhorn : Pokemon
	{
		public override string Name => "Rhyhorn";
		public override List<Ability> AvailableAbilities => new() {new Lightningrod(), new Rockhead() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Reckless() };
		public override Stats BaseStats => new Stats(80, 85, 95, 30, 30, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip() },
			[5] = new List<Move>() { new Smackdown() },
			[10] = new List<Move>() { new Bulldoze() },
			[15] = new List<Move>() { new Hornattack() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Stomp() },
			[30] = new List<Move>() { new Rockblast() },
			[35] = new List<Move>() { new Drillrun() },
			[40] = new List<Move>() { new Takedown() },
			[45] = new List<Move>() { new Earthquake() },
			[50] = new List<Move>() { new Stoneedge() },
			[55] = new List<Move>() { new Megahorn() },
			[60] = new List<Move>() { new Horndrill() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Crunch(), new Dig(), new Doubleteam(), new Dragonpulse(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Flamethrower(), new Hiddenpower(), new Highhorsepower(), new Icebeam(), new Icefang(), new Icywind(), new Irontail(), new Megahorn(), new Mudshot(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Roar(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scaryface(), new Scorchingsands(), new Shockwave(), new Sleeptalk(), new Smartstrike(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Crunch(), new Crushclaw(), new Curse(), new Dragonrush(), new Firefang(), new Guardsplit(), new Icefang(), new Metalburst(), new Reversal(), new Skullbash(), new Thunderfang() };
		public override int Weight => 1150;
		public override int ExpYield => 69;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}