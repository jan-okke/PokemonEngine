using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Litleo : Pokemon
	{
		public override string Name => "Litleo";
		public override List<Ability> AvailableAbilities => new() {new Rivalry(), new Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moxie() };
		public override Stats BaseStats => new Stats(62, 50, 58, 72, 73, 54);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[5] = new List<Move>() { new Ember() },
			[8] = new List<Move>() { new Workup() },
			[11] = new List<Move>() { new Headbutt() },
			[15] = new List<Move>() { new Nobleroar() },
			[20] = new List<Move>() { new Takedown() },
			[23] = new List<Move>() { new Firefang() },
			[28] = new List<Move>() { new Endeavor() },
			[33] = new List<Move>() { new Echoedvoice() },
			[36] = new List<Move>() { new Flamethrower() },
			[39] = new List<Move>() { new Crunch() },
			[43] = new List<Move>() { new Hypervoice() },
			[46] = new List<Move>() { new Incinerate() },
			[50] = new List<Move>() { new Overheat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulldoze(), new Confide(), new Darkpulse(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Facade(), new Fireblast(), new Flamecharge(), new Flamethrower(), new Frustration(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Overheat(), new Payback(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Round(), new Sleeptalk(), new Snarl(), new Snatch(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Toxic(), new Wildcharge(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Entrainment(), new Firespin(), new Flareblitz(), new Snatch(), new Yawn() };
		public override int Weight => 135;
		public override int ExpYield => 74;
		public override int CatchRate => 220;
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