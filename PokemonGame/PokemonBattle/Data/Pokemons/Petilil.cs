using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Petilil : Pokemon
	{
		public override string Name => "Petilil";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(45, 35, 50, 30, 70, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Growth() },
			[3] = new List<Move>() { new Helpinghand() },
			[6] = new List<Move>() { new Stunspore() },
			[9] = new List<Move>() { new Megadrain() },
			[12] = new List<Move>() { new Aromatherapy() },
			[15] = new List<Move>() { new Magicalleaf() },
			[18] = new List<Move>() { new Sleeppowder() },
			[21] = new List<Move>() { new Gigadrain() },
			[24] = new List<Move>() { new Leechseed() },
			[27] = new List<Move>() { new Afteryou() },
			[30] = new List<Move>() { new Energyball() },
			[33] = new List<Move>() { new Synthesis() },
			[36] = new List<Move>() { new Sunnyday() },
			[39] = new List<Move>() { new Entrainment() },
			[42] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Charm(), new Encore(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Helpinghand(), new Hiddenpower(), new Leafstorm(), new Magicalleaf(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday() };
		public override List<Move> EggMoves => new List<Move>() { new Healingwish(), new Ingrain(), new Sweetscent(), new Worryseed() };
		public override int Weight => 66;
		public override int ExpYield => 56;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}