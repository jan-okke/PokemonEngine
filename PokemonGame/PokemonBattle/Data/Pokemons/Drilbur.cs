using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drilbur : Pokemon
	{
		public override string Name => "Drilbur";
		public override List<Ability> AvailableAbilities => new() {new Sandrush(), new Sandforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moldbreaker() };
		public override Stats BaseStats => new Stats(60, 85, 40, 30, 45, 68);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Rapidspin() },
			[4] = new List<Move>() { new Scratch() },
			[8] = new List<Move>() { new Honeclaws() },
			[12] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Metalclaw() },
			[20] = new List<Move>() { new Sandstorm() },
			[24] = new List<Move>() { new Crushclaw() },
			[28] = new List<Move>() { new Rockslide() },
			[32] = new List<Move>() { new Dig() },
			[36] = new List<Move>() { new Swordsdance() },
			[40] = new List<Move>() { new Drillrun() },
			[44] = new List<Move>() { new Earthquake() },
			[48] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulldoze(), new Dig(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Hiddenpower(), new Highhorsepower(), new Irondefense(), new Mudshot(), new Poisonjab(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Stealthrock(), new Substitute(), new Swordsdance(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Metalsound(), new Slash(), new Submission() };
		public override int Weight => 85;
		public override int ExpYield => 66;
		public override int CatchRate => 120;
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