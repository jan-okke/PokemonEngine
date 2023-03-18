using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Amoonguss : Pokemon
	{
		public override string Name => "Amoonguss";
		public override List<Ability> AvailableAbilities => new() {new Effectspore() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(114, 85, 70, 30, 85, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Astonish(), new Growth(), new Stunspore() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Synthesis() },
			[20] = new List<Move>() { new Clearsmog() },
			[24] = new List<Move>() { new Sweetscent() },
			[28] = new List<Move>() { new Gigadrain() },
			[32] = new List<Move>() { new Ingrain() },
			[36] = new List<Move>() { new Toxic() },
			[42] = new List<Move>() { new Ragepowder() },
			[48] = new List<Move>() { new Solarbeam() },
			[54] = new List<Move>() { new Spore() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Endure(), new Energyball(), new Facade(), new Foulplay(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyterrain(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Payback(), new Pollenpuff(), new Protect(), new Raindance(), new Rest(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Venoshock() };
		public override int Weight => 105;
		public override int ExpYield => 162;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}