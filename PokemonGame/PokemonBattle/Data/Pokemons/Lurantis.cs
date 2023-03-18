using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lurantis : Pokemon
	{
		public override string Name => "Lurantis";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Contrary() };
		public override Stats BaseStats => new Stats(70, 105, 90, 80, 90, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Petalblizzard() },
			[1] = new List<Move>() { new Moves.Petalblizzard(), new Moves.Nightslash(), new Moves.Solarbeam(), new Moves.Dualchop(), new Moves.Leafage(), new Moves.Furycutter(), new Moves.Growth(), new Moves.Ingrain() },
			[15] = new List<Move>() { new Moves.Razorleaf() },
			[20] = new List<Move>() { new Moves.Sweetscent() },
			[25] = new List<Move>() { new Moves.Slash() },
			[30] = new List<Move>() { new Moves.Xscissor() },
			[37] = new List<Move>() { new Moves.Synthesis() },
			[44] = new List<Move>() { new Moves.Leafblade() },
			[51] = new List<Move>() { new Moves.Sunnyday() },
			[63] = new List<Move>() { new Moves.Solarblade() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulletseed(), new Moves.Crosspoison(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Leechlife(), new Moves.Lowsweep(), new Moves.Magicalleaf(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Weatherball(), new Moves.Xscissor() };
		public override int Weight => 185;
		public override int ExpYield => 168;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}