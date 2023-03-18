using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cherubi : Pokemon
	{
		public override string Name => "Cherubi";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override Stats BaseStats => new Stats(45, 35, 45, 35, 62, 53);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Morningsun(), new Tackle() },
			[5] = new List<Move>() { new Leafage() },
			[10] = new List<Move>() { new Growth() },
			[15] = new List<Move>() { new Helpinghand() },
			[20] = new List<Move>() { new Magicalleaf() },
			[26] = new List<Move>() { new Leechseed() },
			[30] = new List<Move>() { new Takedown() },
			[35] = new List<Move>() { new Petalblizzard() },
			[40] = new List<Move>() { new Worryseed() },
			[45] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Dazzlinggleam(), new Doubleteam(), new Drainingkiss(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Magicalleaf(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Aromatherapy(), new Defensecurl(), new Flowershield(), new Grassyterrain(), new Healingwish(), new Healpulse(), new Naturepower(), new Razorleaf(), new Rollout(), new Seedbomb(), new Sweetscent(), new Tickle(), new Weatherball() };
		public override int Weight => 33;
		public override int ExpYield => 55;
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