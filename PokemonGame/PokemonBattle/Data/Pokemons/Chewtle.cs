using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chewtle : Pokemon
	{
		public override string Name => "Chewtle";
		public override List<Ability> AvailableAbilities => new() {new Strongjaw(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(50, 64, 50, 44, 38, 38);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Watergun() },
			[7] = new List<Move>() { new Bite() },
			[14] = new List<Move>() { new Protect() },
			[21] = new List<Move>() { new Headbutt() },
			[28] = new List<Move>() { new Counter() },
			[35] = new List<Move>() { new Jawlock() },
			[42] = new List<Move>() { new Liquidation() },
			[49] = new List<Move>() { new Bodyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodyslam(), new Dive(), new Endure(), new Facade(), new Hiddenpower(), new Hydropump(), new Icefang(), new Liquidation(), new Mudshot(), new Payback(), new Protect(), new Raindance(), new Rest(), new Revenge(), new Round(), new Scaleshot(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Dragontail(), new Gastroacid(), new Skullbash() };
		public override int Weight => 85;
		public override int ExpYield => 57;
		public override int CatchRate => 255;
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