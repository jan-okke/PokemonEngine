using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Snubbull : Pokemon
	{
		public override string Name => "Snubbull";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Runaway() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(60, 80, 50, 40, 40, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Icefang(), new Firefang(), new Thunderfang(), new Tackle(), new Scaryface(), new Tailwhip(), new Charm() },
			[7] = new List<Move>() { new Bite() },
			[13] = new List<Move>() { new Lick() },
			[19] = new List<Move>() { new Headbutt() },
			[25] = new List<Move>() { new Roar() },
			[31] = new List<Move>() { new Taunt() },
			[37] = new List<Move>() { new Playrough() },
			[43] = new List<Move>() { new Payback() },
			[49] = new List<Move>() { new Crunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Covet(), new Dazzlinggleam(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focuspunch(), new Frustration(), new Healbell(), new Hiddenpower(), new Hypervoice(), new Icepunch(), new Lastresort(), new Lowkick(), new Overheat(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Superpower(), new Swagger(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Waterpulse(), new Wildcharge(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Closecombat(), new Crunch(), new Doubleedge(), new Faketears(), new Firefang(), new Healbell(), new Icefang(), new Metronome(), new Mimic(), new Present(), new Snore(), new Thunderfang() };
		public override int Weight => 78;
		public override int ExpYield => 60;
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