using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Thwackey : Pokemon
	{
		public override string Name => "Thwackey";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Grassysurge() };
		public override Stats BaseStats => new Stats(70, 85, 70, 80, 55, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Doublehit() },
			[1] = new List<Move>() { new Doublehit(), new Scratch(), new Growl(), new Branchpoke(), new Taunt() },
			[12] = new List<Move>() { new Razorleaf() },
			[19] = new List<Move>() { new Screech() },
			[24] = new List<Move>() { new Knockoff() },
			[30] = new List<Move>() { new Slam() },
			[36] = new List<Move>() { new Uproar() },
			[42] = new List<Move>() { new Woodhammer() },
			[48] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Assurance(), new Attract(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Fling(), new Focusenergy(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Hiddenpower(), new Lowkick(), new Magicalleaf(), new Megakick(), new Megapunch(), new Protect(), new Rest(), new Round(), new Screech(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Uproar(), new Uturn(), new Workup() };
		public override int Weight => 140;
		public override int ExpYield => 147;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}