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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Flowergift() };
		public override Stats BaseStats => new Stats(70, 60, 70, 87, 78, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Sunnyday() },
			[1] = new List<Move>() { new Moves.Sunnyday(), new Moves.Flowershield(), new Moves.Morningsun(), new Moves.Tackle(), new Moves.Leafage(), new Moves.Growth() },
			[15] = new List<Move>() { new Moves.Helpinghand() },
			[20] = new List<Move>() { new Moves.Magicalleaf() },
			[28] = new List<Move>() { new Moves.Leechseed() },
			[34] = new List<Move>() { new Moves.Takedown() },
			[41] = new List<Move>() { new Moves.Petalblizzard() },
			[48] = new List<Move>() { new Moves.Worryseed() },
			[55] = new List<Move>() { new Moves.Solarbeam() },
			[62] = new List<Move>() { new Moves.Petaldance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Magicalleaf(), new Moves.Playrough(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Weatherball() };
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