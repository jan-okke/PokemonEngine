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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
		public override Stats BaseStats => new Stats(59, 181, 131, 59, 31, 109);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Furycutter(), new Moves.Vacuumwave() },
			[5] = new List<Move>() { new Moves.Razorleaf() },
			[10] = new List<Move>() { new Moves.Falseswipe() },
			[15] = new List<Move>() { new Moves.Cut() },
			[20] = new List<Move>() { new Moves.Aircutter() },
			[25] = new List<Move>() { new Moves.Aerialace() },
			[30] = new List<Move>() { new Moves.Detect() },
			[35] = new List<Move>() { new Moves.Nightslash() },
			[40] = new List<Move>() { new Moves.Synthesis() },
			[45] = new List<Move>() { new Moves.Laserfocus() },
			[50] = new List<Move>() { new Moves.Defog() },
			[55] = new List<Move>() { new Moves.Leafblade() },
			[60] = new List<Move>() { new Moves.Sacredsword() },
			[65] = new List<Move>() { new Moves.Swordsdance() },
			[70] = new List<Move>() { new Moves.Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Endure(), new Moves.Falseswipe(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Leafblade(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Solarblade(), new Moves.Steelbeam(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Xscissor() };
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