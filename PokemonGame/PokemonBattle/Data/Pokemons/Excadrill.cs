using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Excadrill : Pokemon
	{
		public override string Name => "Excadrill";
		public override List<Ability> AvailableAbilities => new() {new Sandrush(), new Sandforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moldbreaker() };
		public override Stats BaseStats => new Stats(110, 135, 60, 88, 50, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Horndrill() },
			[1] = new List<Move>() { new Horndrill(), new Mudslap(), new Rapidspin(), new Scratch(), new Honeclaws() },
			[12] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Metalclaw() },
			[20] = new List<Move>() { new Sandstorm() },
			[24] = new List<Move>() { new Crushclaw() },
			[28] = new List<Move>() { new Rockslide() },
			[34] = new List<Move>() { new Dig() },
			[40] = new List<Move>() { new Swordsdance() },
			[46] = new List<Move>() { new Drillrun() },
			[52] = new List<Move>() { new Earthquake() },
			[58] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Dig(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Gigaimpact(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Mudshot(), new Poisonjab(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Smartstrike(), new Snore(), new Stealthrock(), new Steelbeam(), new Stompingtantrum(), new Substitute(), new Swordsdance(), new Xscissor() };
		public override int Weight => 404;
		public override int ExpYield => 178;
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