using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Raboot : Pokemon
	{
		public override string Name => "Raboot";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Libero() };
		public override Stats BaseStats => new Stats(65, 86, 60, 55, 60, 94);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl(), new Ember(), new Quickattack() },
			[12] = new List<Move>() { new Doublekick() },
			[19] = new List<Move>() { new Flamecharge() },
			[24] = new List<Move>() { new Agility() },
			[30] = new List<Move>() { new Headbutt() },
			[36] = new List<Move>() { new Counter() },
			[42] = new List<Move>() { new Bounce() },
			[48] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Allyswitch(), new Assurance(), new Attract(), new Batonpass(), new Blazekick(), new Bounce(), new Bulkup(), new Electroball(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firepledge(), new Flamethrower(), new Flareblitz(), new Focusenergy(), new Gunkshot(), new Heatwave(), new Hiddenpower(), new Lowkick(), new Lowsweep(), new Megakick(), new Mudshot(), new Overheat(), new Protect(), new Rest(), new Reversal(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Uturn(), new Workup() };
		public override int Weight => 90;
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