using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pyroar : Pokemon
	{
		public override string Name => "Pyroar";
		public override List<Ability> AvailableAbilities => new() {new Rivalry(), new Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moxie() };
		public override Stats BaseStats => new Stats(86, 68, 72, 109, 66, 106);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Hyperbeam(), new Tackle(), new Leer(), new Ember(), new Workup() },
			[5] = new List<Move>() { new Ember() },
			[8] = new List<Move>() { new Workup() },
			[11] = new List<Move>() { new Headbutt() },
			[15] = new List<Move>() { new Nobleroar() },
			[20] = new List<Move>() { new Takedown() },
			[23] = new List<Move>() { new Firefang() },
			[28] = new List<Move>() { new Endeavor() },
			[33] = new List<Move>() { new Echoedvoice() },
			[38] = new List<Move>() { new Flamethrower() },
			[42] = new List<Move>() { new Crunch() },
			[48] = new List<Move>() { new Hypervoice() },
			[51] = new List<Move>() { new Incinerate() },
			[57] = new List<Move>() { new Overheat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Bulldoze(), new Confide(), new Darkpulse(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Facade(), new Fireblast(), new Flamecharge(), new Flamethrower(), new Frustration(), new Gigaimpact(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Overheat(), new Payback(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Round(), new Sleeptalk(), new Snarl(), new Snatch(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Toxic(), new Wildcharge(), new Willowisp(), new Workup() };
		public override int Weight => 815;
		public override int ExpYield => 177;
		public override int CatchRate => 65;
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