using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Litten : Pokemon
	{
		public override string Name => "Litten";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Intimidate() };
		public override Stats BaseStats => new Stats(45, 65, 40, 70, 60, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Growl() },
			[3] = new List<Move>() { new Ember() },
			[6] = new List<Move>() { new Lick() },
			[9] = new List<Move>() { new Roar() },
			[12] = new List<Move>() { new Furyswipes() },
			[15] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Doublekick() },
			[21] = new List<Move>() { new Firefang() },
			[24] = new List<Move>() { new Scaryface() },
			[27] = new List<Move>() { new Swagger() },
			[30] = new List<Move>() { new Flamethrower() },
			[33] = new List<Move>() { new Thrash() },
			[36] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Bodyslam(), new Bulkup(), new Crunch(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firepledge(), new Firespin(), new Flamethrower(), new Flareblitz(), new Heatwave(), new Hiddenpower(), new Leechlife(), new Nastyplot(), new Outrage(), new Overheat(), new Payday(), new Protect(), new Rest(), new Revenge(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swordsdance(), new Taunt(), new Uturn(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Fakeout(), new Partingshot(), new Powertrip() };
		public override int Weight => 43;
		public override int ExpYield => 64;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}