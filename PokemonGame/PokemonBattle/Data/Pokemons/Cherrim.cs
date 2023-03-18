using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cherrim : Pokemon
	{
		public override string Name => "Cherrim";
		public override List<Ability> AvailableAbilities => new() {new Flowergift() };
		public override Stats BaseStats => new Stats(70, 60, 70, 87, 78, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Sunnyday() },
			[1] = new List<Move>() { new Sunnyday(), new Flowershield(), new Morningsun(), new Tackle(), new Leafage(), new Growth() },
			[15] = new List<Move>() { new Helpinghand() },
			[20] = new List<Move>() { new Magicalleaf() },
			[28] = new List<Move>() { new Leechseed() },
			[34] = new List<Move>() { new Takedown() },
			[41] = new List<Move>() { new Petalblizzard() },
			[48] = new List<Move>() { new Worryseed() },
			[55] = new List<Move>() { new Solarbeam() },
			[62] = new List<Move>() { new Petaldance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Dazzlinggleam(), new Doubleteam(), new Drainingkiss(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Magicalleaf(), new Playrough(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Weatherball() };
		public override int Weight => 93;
		public override int ExpYield => 158;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}