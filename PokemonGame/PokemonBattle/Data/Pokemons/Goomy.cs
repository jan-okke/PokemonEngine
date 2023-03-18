using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Goomy : Pokemon
	{
		public override string Name => "Goomy";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gooey() };
		public override Stats BaseStats => new Stats(45, 50, 35, 40, 55, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Tackle() },
			[5] = new List<Move>() { new Watergun() },
			[10] = new List<Move>() { new Dragonbreath() },
			[15] = new List<Move>() { new Protect() },
			[20] = new List<Move>() { new Flail() },
			[25] = new List<Move>() { new Waterpulse() },
			[30] = new List<Move>() { new Raindance() },
			[35] = new List<Move>() { new Dragonpulse() },
			[41] = new List<Move>() { new Curse() },
			[45] = new List<Move>() { new Bodyslam() },
			[50] = new List<Move>() { new Muddywater() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Dracometeor(), new Dragonpulse(), new Endure(), new Facade(), new Hiddenpower(), new Irontail(), new Muddywater(), new Mudshot(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Sunnyday(), new Thunderbolt() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Lifedew() };
		public override int Weight => 28;
		public override int ExpYield => 60;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}