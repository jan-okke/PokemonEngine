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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Vitalspirit() };
		public override Stats BaseStats => new Stats(45, 63, 37, 65, 55, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Thundershock() },
			[8] = new List<Move>() { new Moves.Charge() },
			[12] = new List<Move>() { new Moves.Swift() },
			[16] = new List<Move>() { new Moves.Shockwave() },
			[20] = new List<Move>() { new Moves.Thunderwave() },
			[24] = new List<Move>() { new Moves.Screech() },
			[28] = new List<Move>() { new Moves.Thunderpunch() },
			[32] = new List<Move>() { new Moves.Discharge() },
			[36] = new List<Move>() { new Moves.Lowkick() },
			[40] = new List<Move>() { new Moves.Thunderbolt() },
			[44] = new List<Move>() { new Moves.Lightscreen() },
			[48] = new List<Move>() { new Moves.Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Chargebeam(), new Moves.Doubleteam(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Screech(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Crosschop(), new Moves.Dynamicpunch(), new Moves.Feint(), new Moves.Firepunch(), new Moves.Hammerarm(), new Moves.Icepunch() };
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