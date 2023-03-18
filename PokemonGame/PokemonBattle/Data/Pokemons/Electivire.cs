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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Motordrive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Vitalspirit() };
		public override Stats BaseStats => new Stats(75, 123, 67, 95, 85, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Wildcharge(), new Moves.Quickattack(), new Moves.Leer(), new Moves.Thundershock(), new Moves.Charge() },
			[12] = new List<Move>() { new Moves.Swift() },
			[16] = new List<Move>() { new Moves.Shockwave() },
			[20] = new List<Move>() { new Moves.Thunderwave() },
			[24] = new List<Move>() { new Moves.Screech() },
			[28] = new List<Move>() { new Moves.Thunderpunch() },
			[34] = new List<Move>() { new Moves.Discharge() },
			[40] = new List<Move>() { new Moves.Lowkick() },
			[46] = new List<Move>() { new Moves.Thunderbolt() },
			[52] = new List<Move>() { new Moves.Lightscreen() },
			[58] = new List<Move>() { new Moves.Thunder() },
			[64] = new List<Move>() { new Moves.Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Chargebeam(), new Moves.Darkestlariat(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Weatherball(), new Moves.Wildcharge() };
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