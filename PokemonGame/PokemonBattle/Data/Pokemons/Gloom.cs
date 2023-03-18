using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gloom : Pokemon
	{
		public override string Name => "Gloom";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stench() };
		public override Stats BaseStats => new Stats(60, 65, 70, 40, 85, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Growth(), new Acid(), new Sweetscent() },
			[12] = new List<Move>() { new Megadrain() },
			[14] = new List<Move>() { new Poisonpowder() },
			[16] = new List<Move>() { new Stunspore() },
			[18] = new List<Move>() { new Sleeppowder() },
			[20] = new List<Move>() { new Gigadrain() },
			[26] = new List<Move>() { new Toxic() },
			[32] = new List<Move>() { new Moonblast() },
			[38] = new List<Move>() { new Grassyterrain() },
			[44] = new List<Move>() { new Moonlight() },
			[50] = new List<Move>() { new Petaldance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Charm(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Protect(), new Rest(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Toxic(), new Venoshock() };
		public override int Weight => 86;
		public override int ExpYield => 138;
		public override int CatchRate => 120;
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