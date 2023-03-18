using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Electivire : Pokemon
	{
		public override string Name => "Electivire";
		public override List<Ability> AvailableAbilities => new() {new Motordrive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(75, 123, 67, 95, 85, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wildcharge(), new Quickattack(), new Leer(), new Thundershock(), new Charge() },
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
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Chargebeam(), new Darkestlariat(), new Dig(), new Doubleteam(), new Earthquake(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Firepunch(), new Flamethrower(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irontail(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Risingvoltage(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Screech(), new Shockwave(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Uproar(), new Voltswitch(), new Weatherball(), new Wildcharge() };
		public override int Weight => 1386;
		public override int ExpYield => 270;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}