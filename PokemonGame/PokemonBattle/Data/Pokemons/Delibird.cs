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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Vitalspirit(), new Abilities.Hustle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Insomnia() };
		public override Stats BaseStats => new Stats(45, 55, 45, 65, 45, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Present() },
			[25] = new List<Move>() { new Moves.Drillpeck() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Bravebird(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Fly(), new Moves.Focuspunch(), new Moves.Futuresight(), new Moves.Gunkshot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Tripleaxel(), new Moves.Waterpulse(), new Moves.Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Aurorabeam(), new Moves.Auroraveil(), new Moves.Counter(), new Moves.Destinybond(), new Moves.Fakeout(), new Moves.Freezedry(), new Moves.Futuresight(), new Moves.Icepunch(), new Moves.Iceshard(), new Moves.Icywind(), new Moves.Memento(), new Moves.Quickattack(), new Moves.Rapidspin(), new Moves.Spikes(), new Moves.Splash() };
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