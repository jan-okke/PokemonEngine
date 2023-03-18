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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Quickfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moxie() };
		public override Stats BaseStats => new Stats(70, 90, 70, 60, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Snarl() },
			[1] = new List<Move>() { new Moves.Snarl(), new Moves.Firefang(), new Moves.Thunderfang(), new Moves.Icefang(), new Moves.Crunch(), new Moves.Thief(), new Moves.Tackle(), new Moves.Howl(), new Moves.Sandattack(), new Moves.Bite() },
			[4] = new List<Move>() { new Moves.Howl() },
			[7] = new List<Move>() { new Moves.Sandattack() },
			[10] = new List<Move>() { new Moves.Bite() },
			[13] = new List<Move>() { new Moves.Mudslap() },
			[16] = new List<Move>() { new Moves.Roar() },
			[20] = new List<Move>() { new Moves.Swagger() },
			[24] = new List<Move>() { new Moves.Assurance() },
			[28] = new List<Move>() { new Moves.Scaryface() },
			[32] = new List<Move>() { new Moves.Headbutt() },
			[36] = new List<Move>() { new Moves.Taunt() },
			[40] = new List<Move>() { new Moves.Crunch() },
			[44] = new List<Move>() { new Moves.Yawn() },
			[48] = new List<Move>() { new Moves.Takedown() },
			[52] = new List<Move>() { new Moves.Suckerpunch() },
			[56] = new List<Move>() { new Moves.Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Uproar() };
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