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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Contrary() };
		public override Stats BaseStats => new Stats(40, 55, 35, 50, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Leafage(), new Moves.Furycutter() },
			[5] = new List<Move>() { new Moves.Growth() },
			[10] = new List<Move>() { new Moves.Ingrain() },
			[15] = new List<Move>() { new Moves.Razorleaf() },
			[20] = new List<Move>() { new Moves.Sweetscent() },
			[25] = new List<Move>() { new Moves.Slash() },
			[30] = new List<Move>() { new Moves.Xscissor() },
			[35] = new List<Move>() { new Moves.Synthesis() },
			[40] = new List<Move>() { new Moves.Leafblade() },
			[45] = new List<Move>() { new Moves.Sunnyday() },
			[50] = new List<Move>() { new Moves.Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hiddenpower(), new Moves.Leafblade(), new Moves.Leafstorm(), new Moves.Leechlife(), new Moves.Magicalleaf(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swordsdance(), new Moves.Weatherball(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aromatherapy(), new Moves.Defog(), new Moves.Worryseed() };
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