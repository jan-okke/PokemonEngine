using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Foongus : Pokemon
	{
		public override string Name => "Foongus";
		public override List<Ability> AvailableAbilities => new() {new Effectspore() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(69, 55, 45, 55, 55, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Astonish() },
			[4] = new List<Move>() { new Growth() },
			[8] = new List<Move>() { new Stunspore() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Synthesis() },
			[20] = new List<Move>() { new Clearsmog() },
			[24] = new List<Move>() { new Sweetscent() },
			[28] = new List<Move>() { new Gigadrain() },
			[32] = new List<Move>() { new Ingrain() },
			[36] = new List<Move>() { new Toxic() },
			[40] = new List<Move>() { new Ragepowder() },
			[44] = new List<Move>() { new Solarbeam() },
			[48] = new List<Move>() { new Spore() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Endure(), new Energyball(), new Facade(), new Foulplay(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Payback(), new Pollenpuff(), new Protect(), new Raindance(), new Rest(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Defensecurl(), new Poisonpowder(), new Rollout(), new Worryseed() };
		public override int Weight => 10;
		public override int ExpYield => 59;
		public override int CatchRate => 190;
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