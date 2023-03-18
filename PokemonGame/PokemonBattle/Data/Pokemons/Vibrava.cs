using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vibrava : Pokemon
	{
		public override string Name => "Vibrava";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(50, 70, 50, 70, 50, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Dragonbreath() },
			[1] = new List<Move>() { new Dragonbreath(), new Laserfocus(), new Bulldoze(), new Dig(), new Crunch(), new Superpower(), new Fissure(), new Sandattack(), new Astonish(), new Supersonic(), new Bite() },
			[12] = new List<Move>() { new Mudslap() },
			[16] = new List<Move>() { new Sandtomb() },
			[20] = new List<Move>() { new Dragontail() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Bugbuzz() },
			[32] = new List<Move>() { new Sandstorm() },
			[38] = new List<Move>() { new Earthpower() },
			[44] = new List<Move>() { new Earthquake() },
			[50] = new List<Move>() { new Uproar() },
			[56] = new List<Move>() { new Dragonrush() },
			[62] = new List<Move>() { new Boomburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Airslash(), new Attract(), new Bodyslam(), new Bugbuzz(), new Bulldoze(), new Crunch(), new Defog(), new Dig(), new Doubleteam(), new Dracometeor(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fly(), new Focusenergy(), new Gigadrain(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Mudshot(), new Outrage(), new Protect(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Screech(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swift(), new Throatchop(), new Uproar(), new Uturn() };
		public override int Weight => 153;
		public override int ExpYield => 119;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}