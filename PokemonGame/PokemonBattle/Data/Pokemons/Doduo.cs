using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Doduo : Pokemon
	{
		public override string Name => "Doduo";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tangledfeet() };
		public override Stats BaseStats => new Stats(35, 85, 45, 35, 35, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Growl() },
			[5] = new List<Move>() { new Quickattack() },
			[8] = new List<Move>() { new Leer() },
			[12] = new List<Move>() { new Furyattack() },
			[15] = new List<Move>() { new Wingattack() },
			[19] = new List<Move>() { new Pluck() },
			[22] = new List<Move>() { new Doublehit() },
			[26] = new List<Move>() { new Agility() },
			[29] = new List<Move>() { new Uproar() },
			[33] = new List<Move>() { new Acupressure() },
			[36] = new List<Move>() { new Swordsdance() },
			[40] = new List<Move>() { new Lunge() },
			[43] = new List<Move>() { new Drillpeck() },
			[47] = new List<Move>() { new Endeavor() },
			[50] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Fly(), new Frustration(), new Hiddenpower(), new Knockoff(), new Pluck(), new Protect(), new Rest(), new Return(), new Roost(), new Round(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Thief(), new Uproar(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Assurance(), new Bravebird(), new Endeavor(), new Flail(), new Haze(), new Quickattack(), new Supersonic() };
		public override int Weight => 392;
		public override int ExpYield => 62;
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