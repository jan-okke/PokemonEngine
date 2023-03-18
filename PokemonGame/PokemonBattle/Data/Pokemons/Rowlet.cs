using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rowlet : Pokemon
	{
		public override string Name => "Rowlet";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Longreach() };
		public override Stats BaseStats => new Stats(68, 55, 55, 42, 50, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[3] = new List<Move>() { new Leafage() },
			[6] = new List<Move>() { new Astonish() },
			[9] = new List<Move>() { new Peck() },
			[12] = new List<Move>() { new Shadowsneak() },
			[15] = new List<Move>() { new Razorleaf() },
			[18] = new List<Move>() { new Synthesis() },
			[21] = new List<Move>() { new Pluck() },
			[24] = new List<Move>() { new Nastyplot() },
			[27] = new List<Move>() { new Suckerpunch() },
			[30] = new List<Move>() { new Leafblade() },
			[33] = new List<Move>() { new Featherdance() },
			[36] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bravebird(), new Dualwingbeat(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Hiddenpower(), new Leafblade(), new Lightscreen(), new Nastyplot(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swift(), new Swordsdance(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Confuseray(), new Defog(), new Doubleteam(), new Knockoff() };
		public override int Weight => 15;
		public override int ExpYield => 64;
		public override int CatchRate => 45;
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