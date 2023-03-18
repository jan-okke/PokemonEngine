using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mightyena : Pokemon
	{
		public override string Name => "Mightyena";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Quickfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moxie() };
		public override Stats BaseStats => new Stats(70, 90, 70, 60, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Snarl() },
			[1] = new List<Move>() { new Snarl(), new Firefang(), new Thunderfang(), new Icefang(), new Crunch(), new Thief(), new Tackle(), new Howl(), new Sandattack(), new Bite() },
			[4] = new List<Move>() { new Howl() },
			[7] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Bite() },
			[13] = new List<Move>() { new Mudslap() },
			[16] = new List<Move>() { new Roar() },
			[20] = new List<Move>() { new Swagger() },
			[24] = new List<Move>() { new Assurance() },
			[28] = new List<Move>() { new Scaryface() },
			[32] = new List<Move>() { new Headbutt() },
			[36] = new List<Move>() { new Taunt() },
			[40] = new List<Move>() { new Crunch() },
			[44] = new List<Move>() { new Yawn() },
			[48] = new List<Move>() { new Takedown() },
			[52] = new List<Move>() { new Suckerpunch() },
			[56] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Confide(), new Covet(), new Darkpulse(), new Dig(), new Doubleteam(), new Embargo(), new Endure(), new Facade(), new Foulplay(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Laserfocus(), new Nastyplot(), new Payback(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Round(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snatch(), new Snore(), new Spite(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Uproar() };
		public override int Weight => 370;
		public override int ExpYield => 147;
		public override int CatchRate => 127;
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