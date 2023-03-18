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
		public override List<Ability> AvailableAbilities => new() {new Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Contrary() };
		public override Stats BaseStats => new Stats(70, 105, 90, 45, 80, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Petalblizzard() },
			[1] = new List<Move>() { new Petalblizzard(), new Nightslash(), new Solarbeam(), new Dualchop(), new Leafage(), new Furycutter(), new Growth(), new Ingrain() },
			[15] = new List<Move>() { new Razorleaf() },
			[20] = new List<Move>() { new Sweetscent() },
			[25] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Xscissor() },
			[37] = new List<Move>() { new Synthesis() },
			[44] = new List<Move>() { new Leafblade() },
			[51] = new List<Move>() { new Sunnyday() },
			[63] = new List<Move>() { new Solarblade() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulletseed(), new Crosspoison(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Fling(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Leafblade(), new Leafstorm(), new Leechlife(), new Lowsweep(), new Magicalleaf(), new Payback(), new Poisonjab(), new Protect(), new Psychocut(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Substitute(), new Sunnyday(), new Superpower(), new Swordsdance(), new Weatherball(), new Xscissor() };
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