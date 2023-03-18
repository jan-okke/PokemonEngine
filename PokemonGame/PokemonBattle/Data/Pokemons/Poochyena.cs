using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Poochyena : Pokemon
	{
		public override string Name => "Poochyena";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Quickfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(35, 55, 35, 35, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[4] = new List<Move>() { new Howl() },
			[7] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Bite() },
			[13] = new List<Move>() { new Mudslap() },
			[16] = new List<Move>() { new Roar() },
			[19] = new List<Move>() { new Swagger() },
			[22] = new List<Move>() { new Assurance() },
			[25] = new List<Move>() { new Scaryface() },
			[28] = new List<Move>() { new Headbutt() },
			[31] = new List<Move>() { new Taunt() },
			[34] = new List<Move>() { new Crunch() },
			[37] = new List<Move>() { new Yawn() },
			[40] = new List<Move>() { new Takedown() },
			[43] = new List<Move>() { new Suckerpunch() },
			[46] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Confide(), new Covet(), new Darkpulse(), new Dig(), new Doubleteam(), new Embargo(), new Endure(), new Facade(), new Foulplay(), new Frustration(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Nastyplot(), new Payback(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Round(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snatch(), new Snore(), new Spite(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Torment(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Covet(), new Firefang(), new Icefang(), new Leer(), new Playrough(), new Poisonfang(), new Suckerpunch(), new Thunderfang(), new Yawn() };
		public override int Weight => 136;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
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