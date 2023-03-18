using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eldegoss : Pokemon
	{
		public override string Name => "Eldegoss";
		public override List<Ability> AvailableAbilities => new() {new Cottondown(), new Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Effectspore() };
		public override Stats BaseStats => new Stats(60, 50, 90, 80, 120, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Cottonspore() },
			[1] = new List<Move>() { new Cottonspore(), new Leafage(), new Sing(), new Rapidspin(), new Sweetscent() },
			[12] = new List<Move>() { new Razorleaf() },
			[16] = new List<Move>() { new Round() },
			[23] = new List<Move>() { new Leaftornado() },
			[28] = new List<Move>() { new Synthesis() },
			[34] = new List<Move>() { new Hypervoice() },
			[40] = new List<Move>() { new Aromatherapy() },
			[46] = new List<Move>() { new Leafstorm() },
			[52] = new List<Move>() { new Cottonguard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Charm(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Leafstorm(), new Lightscreen(), new Magicalleaf(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Weatherball() };
		public override int Weight => 25;
		public override int ExpYield => 161;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}