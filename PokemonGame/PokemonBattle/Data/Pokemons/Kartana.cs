using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kartana : Pokemon
	{
		public override string Name => "Kartana";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(59, 181, 131, 59, 31, 109);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Furycutter(), new Vacuumwave() },
			[5] = new List<Move>() { new Razorleaf() },
			[10] = new List<Move>() { new Falseswipe() },
			[15] = new List<Move>() { new Cut() },
			[20] = new List<Move>() { new Aircutter() },
			[25] = new List<Move>() { new Aerialace() },
			[30] = new List<Move>() { new Detect() },
			[35] = new List<Move>() { new Nightslash() },
			[40] = new List<Move>() { new Synthesis() },
			[45] = new List<Move>() { new Laserfocus() },
			[50] = new List<Move>() { new Defog() },
			[55] = new List<Move>() { new Leafblade() },
			[60] = new List<Move>() { new Sacredsword() },
			[65] = new List<Move>() { new Swordsdance() },
			[70] = new List<Move>() { new Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Brickbreak(), new Calmmind(), new Endure(), new Falseswipe(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Irondefense(), new Leafblade(), new Protect(), new Psychocut(), new Rest(), new Round(), new Screech(), new Sleeptalk(), new Smartstrike(), new Snore(), new Solarblade(), new Steelbeam(), new Substitute(), new Swordsdance(), new Xscissor() };
		public override int Weight => 1;
		public override int ExpYield => 285;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}