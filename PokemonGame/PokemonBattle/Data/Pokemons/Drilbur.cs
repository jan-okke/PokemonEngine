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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sandrush(), new Abilities.Sandforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moldbreaker() };
		public override Stats BaseStats => new Stats(60, 85, 40, 30, 45, 68);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Rapidspin() },
			[4] = new List<Move>() { new Moves.Scratch() },
			[8] = new List<Move>() { new Moves.Honeclaws() },
			[12] = new List<Move>() { new Moves.Furyswipes() },
			[16] = new List<Move>() { new Moves.Metalclaw() },
			[20] = new List<Move>() { new Moves.Sandstorm() },
			[24] = new List<Move>() { new Moves.Crushclaw() },
			[28] = new List<Move>() { new Moves.Rockslide() },
			[32] = new List<Move>() { new Moves.Dig() },
			[36] = new List<Move>() { new Moves.Swordsdance() },
			[40] = new List<Move>() { new Moves.Drillrun() },
			[44] = new List<Move>() { new Moves.Earthquake() },
			[48] = new List<Move>() { new Moves.Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Irondefense(), new Moves.Mudshot(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Metalsound(), new Moves.Slash(), new Moves.Submission() };
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