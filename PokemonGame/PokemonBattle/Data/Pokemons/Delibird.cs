using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Delibird : Pokemon
	{
		public override string Name => "Delibird";
		public override List<Ability> AvailableAbilities => new() {new Vitalspirit(), new Hustle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Insomnia() };
		public override Stats BaseStats => new Stats(45, 55, 45, 75, 65, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Present() },
			[25] = new List<Move>() { new Drillpeck() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Assurance(), new Attract(), new Avalanche(), new Batonpass(), new Blizzard(), new Bodyslam(), new Bounce(), new Bravebird(), new Brickbreak(), new Brutalswing(), new Defog(), new Doubleteam(), new Drillrun(), new Dualwingbeat(), new Endure(), new Facade(), new Fling(), new Fly(), new Focuspunch(), new Futuresight(), new Gunkshot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Iciclespear(), new Icywind(), new Megakick(), new Megapunch(), new Pluck(), new Protect(), new Raindance(), new Recycle(), new Rest(), new Round(), new Seedbomb(), new Sleeptalk(), new Snore(), new Spikes(), new Steelwing(), new Substitute(), new Swagger(), new Swift(), new Thief(), new Tripleaxel(), new Waterpulse(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Aurorabeam(), new Auroraveil(), new Counter(), new Destinybond(), new Fakeout(), new Freezedry(), new Futuresight(), new Icepunch(), new Iceshard(), new Icywind(), new Memento(), new Quickattack(), new Rapidspin(), new Spikes(), new Splash() };
		public override int Weight => 160;
		public override int ExpYield => 116;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}