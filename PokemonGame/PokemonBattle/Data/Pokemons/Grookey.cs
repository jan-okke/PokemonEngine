using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grookey : Pokemon
	{
		public override string Name => "Grookey";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Grassysurge() };
		public override Stats BaseStats => new Stats(50, 65, 50, 40, 40, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Growl() },
			[6] = new List<Move>() { new Branchpoke() },
			[8] = new List<Move>() { new Taunt() },
			[12] = new List<Move>() { new Razorleaf() },
			[17] = new List<Move>() { new Screech() },
			[20] = new List<Move>() { new Knockoff() },
			[24] = new List<Move>() { new Slam() },
			[28] = new List<Move>() { new Uproar() },
			[32] = new List<Move>() { new Woodhammer() },
			[36] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Assurance(), new Attract(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Fling(), new Focusenergy(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Hiddenpower(), new Lowkick(), new Magicalleaf(), new Megakick(), new Megapunch(), new Protect(), new Rest(), new Round(), new Screech(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Taunt(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Fakeout(), new Growth(), new Hammerarm(), new Leechseed(), new Naturepower(), new Strength(), new Worryseed() };
		public override int Weight => 50;
		public override int ExpYield => 62;
		public override int CatchRate => 45;
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