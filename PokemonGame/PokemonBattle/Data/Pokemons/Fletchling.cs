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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Bigpecks() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Galewings() };
		public override Stats BaseStats => new Stats(45, 50, 43, 40, 38, 62);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Peck(), new Moves.Growl() },
			[5] = new List<Move>() { new Moves.Quickattack() },
			[10] = new List<Move>() { new Moves.Ember() },
			[15] = new List<Move>() { new Moves.Flail() },
			[20] = new List<Move>() { new Moves.Acrobatics() },
			[25] = new List<Move>() { new Moves.Agility() },
			[30] = new List<Move>() { new Moves.Aerialace() },
			[35] = new List<Move>() { new Moves.Tailwind() },
			[40] = new List<Move>() { new Moves.Steelwing() },
			[45] = new List<Move>() { new Moves.Roost() },
			[50] = new List<Move>() { new Moves.Fly() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Attract(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uturn(), new Moves.Willowisp(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Defog(), new Moves.Flamecharge(), new Moves.Quickguard() };
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