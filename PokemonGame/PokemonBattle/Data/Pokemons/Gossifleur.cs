using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gossifleur : Pokemon
	{
		public override string Name => "Gossifleur";
		public override List<Ability> AvailableAbilities => new() {new Cottondown(), new Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Effectspore() };
		public override Stats BaseStats => new Stats(40, 40, 60, 10, 40, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leafage(), new Sing() },
			[4] = new List<Move>() { new Rapidspin() },
			[8] = new List<Move>() { new Sweetscent() },
			[12] = new List<Move>() { new Razorleaf() },
			[16] = new List<Move>() { new Round() },
			[21] = new List<Move>() { new Leaftornado() },
			[24] = new List<Move>() { new Synthesis() },
			[28] = new List<Move>() { new Hypervoice() },
			[32] = new List<Move>() { new Aromatherapy() },
			[36] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Charm(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Leafstorm(), new Lightscreen(), new Magicalleaf(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday() };
		public override List<Move> EggMoves => new List<Move>() { new Growth(), new Leechseed(), new Poisonpowder(), new Sleeppowder(), new Stunspore(), new Worryseed() };
		public override int Weight => 22;
		public override int ExpYield => 50;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}