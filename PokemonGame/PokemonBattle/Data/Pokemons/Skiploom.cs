using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Skiploom : Pokemon
	{
		public override string Name => "Skiploom";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(55, 45, 50, 45, 65, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash(), new Absorb(), new Synthesis(), new Tailwhip() },
			[4] = new List<Move>() { new Synthesis() },
			[6] = new List<Move>() { new Tailwhip() },
			[8] = new List<Move>() { new Tackle() },
			[10] = new List<Move>() { new Fairywind() },
			[12] = new List<Move>() { new Poisonpowder() },
			[14] = new List<Move>() { new Stunspore() },
			[16] = new List<Move>() { new Sleeppowder() },
			[20] = new List<Move>() { new Bulletseed() },
			[24] = new List<Move>() { new Leechseed() },
			[28] = new List<Move>() { new Megadrain() },
			[32] = new List<Move>() { new Acrobatics() },
			[36] = new List<Move>() { new Ragepowder() },
			[40] = new List<Move>() { new Cottonspore() },
			[44] = new List<Move>() { new Uturn() },
			[48] = new List<Move>() { new Worryseed() },
			[52] = new List<Move>() { new Gigadrain() },
			[56] = new List<Move>() { new Bounce() },
			[60] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Bounce(), new Bulletseed(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Infestation(), new Protect(), new Psychup(), new Reflect(), new Rest(), new Return(), new Round(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Uturn(), new Worryseed() };
		public override int Weight => 10;
		public override int ExpYield => 119;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}