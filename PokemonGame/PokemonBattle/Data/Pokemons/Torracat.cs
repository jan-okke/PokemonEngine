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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Intimidate() };
		public override Stats BaseStats => new Stats(65, 85, 50, 80, 50, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Growl(), new Moves.Ember(), new Moves.Lick() },
			[9] = new List<Move>() { new Moves.Roar() },
			[12] = new List<Move>() { new Moves.Furyswipes() },
			[15] = new List<Move>() { new Moves.Bite() },
			[20] = new List<Move>() { new Moves.Doublekick() },
			[25] = new List<Move>() { new Moves.Firefang() },
			[30] = new List<Move>() { new Moves.Scaryface() },
			[35] = new List<Move>() { new Moves.Swagger() },
			[40] = new List<Move>() { new Moves.Flamethrower() },
			[45] = new List<Move>() { new Moves.Thrash() },
			[50] = new List<Move>() { new Moves.Flareblitz() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulkup(), new Moves.Crunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepledge(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Leechlife(), new Moves.Nastyplot(), new Moves.Outrage(), new Moves.Overheat(), new Moves.Payday(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup() };
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