using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Skwovet : Pokemon
	{
		public override string Name => "Skwovet";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Cheekpouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
		public override Stats BaseStats => new Stats(70, 55, 55, 35, 35, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
			[5] = new List<Move>() { new Moves.Bite() },
			[10] = new List<Move>() { new Moves.Stuffcheeks() },
			[15] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
			[20] = new List<Move>() { new Moves.Bodyslam() },
			[25] = new List<Move>() { new Moves.Rest() },
			[30] = new List<Move>() { new Moves.Counter() },
			[35] = new List<Move>() { new Moves.Bulletseed() },
			[40] = new List<Move>() { new Moves.Superfang() },
			[45] = new List<Move>() { new Moves.Belch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Bulletseed(), new Moves.Crunch(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Tailslap(), new Moves.Thief(), new Moves.Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Bellydrum(), new Moves.Defensecurl(), new Moves.Lastresort(), new Moves.Rollout() };
		public override int Weight => 25;
		public override int ExpYield => 55;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}