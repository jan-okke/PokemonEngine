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
		public override List<Ability> AvailableAbilities => new() {new Cheekpouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(70, 55, 55, 35, 35, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip() },
			[5] = new List<Move>() { new Bite() },
			[10] = new List<Move>() { new Stuffcheeks() },
			[15] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[20] = new List<Move>() { new Bodyslam() },
			[25] = new List<Move>() { new Rest() },
			[30] = new List<Move>() { new Counter() },
			[35] = new List<Move>() { new Bulletseed() },
			[40] = new List<Move>() { new Superfang() },
			[45] = new List<Move>() { new Belch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Assurance(), new Attract(), new Bodyslam(), new Brutalswing(), new Bulletseed(), new Crunch(), new Dig(), new Endure(), new Facade(), new Fling(), new Gyroball(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Mudshot(), new Payback(), new Protect(), new Rest(), new Round(), new Seedbomb(), new Sleeptalk(), new Snore(), new Substitute(), new Tailslap(), new Thief(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Bellydrum(), new Defensecurl(), new Lastresort(), new Rollout() };
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