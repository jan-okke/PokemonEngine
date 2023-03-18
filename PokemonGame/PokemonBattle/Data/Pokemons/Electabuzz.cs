using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Electabuzz : Pokemon
	{
		public override string Name => "Electabuzz";
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(65, 83, 57, 95, 85, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Leer(), new Thundershock(), new Charge() },
			[12] = new List<Move>() { new Swift() },
			[16] = new List<Move>() { new Shockwave() },
			[20] = new List<Move>() { new Thunderwave() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Thunderpunch() },
			[34] = new List<Move>() { new Discharge() },
			[40] = new List<Move>() { new Lowkick() },
			[46] = new List<Move>() { new Thunderbolt() },
			[52] = new List<Move>() { new Lightscreen() },
			[58] = new List<Move>() { new Thunder() },
			[64] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Chargebeam(), new Doubleteam(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irontail(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Risingvoltage(), new Rockclimb(), new Rocksmash(), new Round(), new Screech(), new Shockwave(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 300;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
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