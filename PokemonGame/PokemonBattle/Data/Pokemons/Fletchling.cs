using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Fletchling : Pokemon
	{
		public override string Name => "Fletchling";
		public override List<Ability> AvailableAbilities => new() {new Bigpecks() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Galewings() };
		public override Stats BaseStats => new Stats(45, 50, 43, 62, 40, 38);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Growl() },
			[5] = new List<Move>() { new Quickattack() },
			[10] = new List<Move>() { new Ember() },
			[15] = new List<Move>() { new Flail() },
			[20] = new List<Move>() { new Acrobatics() },
			[25] = new List<Move>() { new Agility() },
			[30] = new List<Move>() { new Aerialace() },
			[35] = new List<Move>() { new Tailwind() },
			[40] = new List<Move>() { new Steelwing() },
			[45] = new List<Move>() { new Roost() },
			[50] = new List<Move>() { new Fly() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Attract(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Heatwave(), new Hiddenpower(), new Overheat(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Uturn(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Defog(), new Flamecharge(), new Quickguard() };
		public override int Weight => 17;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
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