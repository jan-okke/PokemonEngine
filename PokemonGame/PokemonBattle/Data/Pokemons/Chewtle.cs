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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Strongjaw(), new Abilities.Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
		public override Stats BaseStats => new Stats(50, 64, 50, 38, 38, 44);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Watergun() },
			[7] = new List<Move>() { new Moves.Bite() },
			[14] = new List<Move>() { new Moves.Protect() },
			[21] = new List<Move>() { new Moves.Headbutt() },
			[28] = new List<Move>() { new Moves.Counter() },
			[35] = new List<Move>() { new Moves.Jawlock() },
			[42] = new List<Move>() { new Moves.Liquidation() },
			[49] = new List<Move>() { new Moves.Bodyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Dive(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icefang(), new Moves.Liquidation(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Dragontail(), new Moves.Gastroacid(), new Moves.Skullbash() };
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