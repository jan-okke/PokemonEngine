using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Torracat : Pokemon
	{
		public override string Name => "Torracat";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Intimidate() };
		public override Stats BaseStats => new Stats(65, 85, 50, 80, 50, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Growl(), new Ember(), new Lick() },
			[9] = new List<Move>() { new Roar() },
			[12] = new List<Move>() { new Furyswipes() },
			[15] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Doublekick() },
			[25] = new List<Move>() { new Firefang() },
			[30] = new List<Move>() { new Scaryface() },
			[35] = new List<Move>() { new Swagger() },
			[40] = new List<Move>() { new Flamethrower() },
			[45] = new List<Move>() { new Thrash() },
			[50] = new List<Move>() { new Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Bodyslam(), new Bulkup(), new Crunch(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firepledge(), new Firespin(), new Flamethrower(), new Flareblitz(), new Heatwave(), new Hiddenpower(), new Leechlife(), new Nastyplot(), new Outrage(), new Overheat(), new Payday(), new Protect(), new Rest(), new Revenge(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swordsdance(), new Taunt(), new Uturn(), new Willowisp(), new Workup() };
		public override int Weight => 250;
		public override int ExpYield => 147;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}