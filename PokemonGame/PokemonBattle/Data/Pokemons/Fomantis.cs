using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Fomantis : Pokemon
	{
		public override string Name => "Fomantis";
		public override List<Ability> AvailableAbilities => new() {new Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Contrary() };
		public override Stats BaseStats => new Stats(40, 55, 35, 35, 50, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leafage(), new Furycutter() },
			[5] = new List<Move>() { new Growth() },
			[10] = new List<Move>() { new Ingrain() },
			[15] = new List<Move>() { new Razorleaf() },
			[20] = new List<Move>() { new Sweetscent() },
			[25] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Xscissor() },
			[35] = new List<Move>() { new Synthesis() },
			[40] = new List<Move>() { new Leafblade() },
			[45] = new List<Move>() { new Sunnyday() },
			[50] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Fling(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Hiddenpower(), new Leafblade(), new Leafstorm(), new Leechlife(), new Magicalleaf(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swordsdance(), new Weatherball(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Aromatherapy(), new Defog(), new Worryseed() };
		public override int Weight => 15;
		public override int ExpYield => 50;
		public override int CatchRate => 190;
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