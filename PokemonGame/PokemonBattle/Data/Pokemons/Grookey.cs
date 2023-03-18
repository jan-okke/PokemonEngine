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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Grassysurge() };
		public override Stats BaseStats => new Stats(50, 65, 50, 40, 40, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Growl() },
			[6] = new List<Move>() { new Moves.Branchpoke() },
			[8] = new List<Move>() { new Moves.Taunt() },
			[12] = new List<Move>() { new Moves.Razorleaf() },
			[17] = new List<Move>() { new Moves.Screech() },
			[20] = new List<Move>() { new Moves.Knockoff() },
			[24] = new List<Move>() { new Moves.Slam() },
			[28] = new List<Move>() { new Moves.Uproar() },
			[32] = new List<Move>() { new Moves.Woodhammer() },
			[36] = new List<Move>() { new Moves.Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Assurance(), new Moves.Attract(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusenergy(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Grassyglide(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Fakeout(), new Moves.Growth(), new Moves.Hammerarm(), new Moves.Leechseed(), new Moves.Naturepower(), new Moves.Strength(), new Moves.Worryseed() };
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