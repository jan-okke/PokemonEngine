using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sandshrew : Pokemon
	{
		public override string Name => "Sandshrew";
		public override List<Ability> AvailableAbilities => new() {new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandrush() };
		public override Stats BaseStats => new Stats(50, 75, 85, 20, 30, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Defensecurl() },
			[3] = new List<Move>() { new Poisonsting() },
			[6] = new List<Move>() { new Sandattack() },
			[9] = new List<Move>() { new Rollout() },
			[12] = new List<Move>() { new Furycutter() },
			[15] = new List<Move>() { new Rapidspin() },
			[18] = new List<Move>() { new Bulldoze() },
			[21] = new List<Move>() { new Swift() },
			[24] = new List<Move>() { new Furyswipes() },
			[27] = new List<Move>() { new Agility() },
			[30] = new List<Move>() { new Slash() },
			[33] = new List<Move>() { new Dig() },
			[36] = new List<Move>() { new Gyroball() },
			[39] = new List<Move>() { new Swordsdance() },
			[42] = new List<Move>() { new Sandstorm() },
			[45] = new List<Move>() { new Earthquake() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Amnesia(), new Attract(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focuspunch(), new Gyroball(), new Hiddenpower(), new Irontail(), new Leechlife(), new Mudshot(), new Poisonjab(), new Protect(), new Rest(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelroller(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Throatchop(), new Workup(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Crushclaw(), new Flail(), new Honeclaws(), new Metalclaw(), new Mudshot(), new Mudslap(), new Nightslash(), new Rapidspin() };
		public override int Weight => 120;
		public override int ExpYield => 60;
		public override int CatchRate => 255;
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