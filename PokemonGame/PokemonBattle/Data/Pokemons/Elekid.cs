using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Elekid : Pokemon
	{
		public override string Name => "Elekid";
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(45, 63, 37, 95, 65, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Leer() },
			[4] = new List<Move>() { new Thundershock() },
			[8] = new List<Move>() { new Charge() },
			[12] = new List<Move>() { new Swift() },
			[16] = new List<Move>() { new Shockwave() },
			[20] = new List<Move>() { new Thunderwave() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Thunderpunch() },
			[32] = new List<Move>() { new Discharge() },
			[36] = new List<Move>() { new Lowkick() },
			[40] = new List<Move>() { new Thunderbolt() },
			[44] = new List<Move>() { new Lightscreen() },
			[48] = new List<Move>() { new Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Chargebeam(), new Doubleteam(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focuspunch(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Lightscreen(), new Lowkick(), new Megakick(), new Megapunch(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Screech(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Crosschop(), new Dynamicpunch(), new Feint(), new Firepunch(), new Hammerarm(), new Icepunch() };
		public override int Weight => 235;
		public override int ExpYield => 72;
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