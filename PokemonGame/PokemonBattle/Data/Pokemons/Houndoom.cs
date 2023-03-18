using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Houndoom : Pokemon
	{
		public override string Name => "Houndoom";
		public override List<Ability> AvailableAbilities => new() {new Earlybird(), new Flashfire() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(75, 90, 50, 110, 80, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Inferno(), new Nastyplot(), new Thunderfang(), new Leer(), new Ember() },
			[4] = new List<Move>() { new Howl() },
			[8] = new List<Move>() { new Smog() },
			[13] = new List<Move>() { new Roar() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Taunt() },
			[26] = new List<Move>() { new Beatup() },
			[30] = new List<Move>() { new Firefang() },
			[35] = new List<Move>() { new Payback() },
			[41] = new List<Move>() { new Flamecharge() },
			[45] = new List<Move>() { new Foulplay() },
			[50] = new List<Move>() { new Flamethrower() },
			[56] = new List<Move>() { new Crunch() },
			[60] = new List<Move>() { new Nastyplot() },
			[65] = new List<Move>() { new Inferno() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Confide(), new Darkpulse(), new Doubleteam(), new Dreameater(), new Embargo(), new Endure(), new Facade(), new Fireblast(), new Flamecharge(), new Flamethrower(), new Foulplay(), new Frustration(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Laserfocus(), new Nastyplot(), new Overheat(), new Payback(), new Protect(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Roleplay(), new Round(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snatch(), new Snore(), new Solarbeam(), new Spite(), new Strength(), new Substitute(), new Sunnyday(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Uproar(), new Willowisp() };
		public override int Weight => 350;
		public override int ExpYield => 175;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}