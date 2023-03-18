using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ferroseed : Pokemon
	{
		public override string Name => "Ferroseed";
		public override List<Ability> AvailableAbilities => new() {new Ironbarbs() };
		public override Stats BaseStats => new Stats(44, 50, 91, 10, 24, 86);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden() },
			[5] = new List<Move>() { new Metalclaw() },
			[10] = new List<Move>() { new Pinmissile() },
			[15] = new List<Move>() { new Ingrain() },
			[20] = new List<Move>() { new Flashcannon() },
			[25] = new List<Move>() { new Ironhead() },
			[30] = new List<Move>() { new Selfdestruct() },
			[35] = new List<Move>() { new Irondefense() },
			[41] = new List<Move>() { new Curse() },
			[45] = new List<Move>() { new Gyroball() },
			[50] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bulletseed(), new Endure(), new Energyball(), new Facade(), new Flashcannon(), new Gigadrain(), new Gyroball(), new Hiddenpower(), new Irondefense(), new Ironhead(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Rest(), new Revenge(), new Round(), new Seedbomb(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Solarbeam(), new Spikes(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Substitute(), new Sunnyday(), new Thunderbolt(), new Thunderwave() };
		public override List<Move> EggMoves => new List<Move>() { new Acidspray(), new Gravity(), new Knockoff(), new Leechseed(), new Toxic() };
		public override int Weight => 188;
		public override int ExpYield => 61;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}