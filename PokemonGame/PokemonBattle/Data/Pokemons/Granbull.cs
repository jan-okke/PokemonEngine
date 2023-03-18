using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Granbull : Pokemon
	{
		public override string Name => "Granbull";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Quickfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(90, 120, 75, 60, 60, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Outrage(), new Icefang(), new Firefang(), new Thunderfang(), new Tackle(), new Scaryface(), new Tailwhip(), new Charm() },
			[7] = new List<Move>() { new Bite() },
			[13] = new List<Move>() { new Lick() },
			[19] = new List<Move>() { new Headbutt() },
			[27] = new List<Move>() { new Roar() },
			[35] = new List<Move>() { new Taunt() },
			[43] = new List<Move>() { new Playrough() },
			[51] = new List<Move>() { new Payback() },
			[59] = new List<Move>() { new Crunch() },
			[67] = new List<Move>() { new Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Covet(), new Dazzlinggleam(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Healbell(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icepunch(), new Irontail(), new Lastresort(), new Lowkick(), new Outrage(), new Overheat(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Superpower(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Waterpulse(), new Wildcharge(), new Workup() };
		public override int Weight => 487;
		public override int ExpYield => 158;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}