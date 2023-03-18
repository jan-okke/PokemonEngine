using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Houndour : Pokemon
	{
		public override string Name => "Houndour";
		public override List<Ability> AvailableAbilities => new() {new Earlybird(), new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(45, 60, 30, 80, 50, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leer(), new Ember() },
			[4] = new List<Move>() { new Howl() },
			[8] = new List<Move>() { new Smog() },
			[13] = new List<Move>() { new Roar() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Taunt() },
			[25] = new List<Move>() { new Beatup() },
			[28] = new List<Move>() { new Firefang() },
			[32] = new List<Move>() { new Payback() },
			[37] = new List<Move>() { new Flamecharge() },
			[40] = new List<Move>() { new Foulplay() },
			[44] = new List<Move>() { new Flamethrower() },
			[49] = new List<Move>() { new Crunch() },
			[52] = new List<Move>() { new Nastyplot() },
			[56] = new List<Move>() { new Inferno() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Confide(), new Darkpulse(), new Doubleteam(), new Dreameater(), new Embargo(), new Endure(), new Facade(), new Fireblast(), new Flamecharge(), new Flamethrower(), new Foulplay(), new Frustration(), new Heatwave(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Nastyplot(), new Overheat(), new Payback(), new Protect(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Roleplay(), new Round(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snatch(), new Snore(), new Solarbeam(), new Spite(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Torment(), new Uproar(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Beatup(), new Counter(), new Destinybond(), new Feint(), new Firefang(), new Firespin(), new Reversal(), new Spite(), new Suckerpunch(), new Thunderfang() };
		public override int Weight => 108;
		public override int ExpYield => 66;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}