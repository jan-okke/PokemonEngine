using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Slugma : Pokemon
	{
		public override string Name => "Slugma";
		public override List<Ability> AvailableAbilities => new() {new Magmaarmor(), new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(40, 40, 40, 20, 70, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Yawn(), new Smog() },
			[6] = new List<Move>() { new Ember() },
			[8] = new List<Move>() { new Rockthrow() },
			[13] = new List<Move>() { new Harden() },
			[15] = new List<Move>() { new Incinerate() },
			[20] = new List<Move>() { new Clearsmog() },
			[22] = new List<Move>() { new Ancientpower() },
			[29] = new List<Move>() { new Rockslide() },
			[34] = new List<Move>() { new Lavaplume() },
			[36] = new List<Move>() { new Amnesia() },
			[41] = new List<Move>() { new Bodyslam() },
			[43] = new List<Move>() { new Recover() },
			[48] = new List<Move>() { new Flamethrower() },
			[50] = new List<Move>() { new Earthpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Attract(), new Confide(), new Doubleteam(), new Earthpower(), new Endure(), new Facade(), new Fireblast(), new Flamecharge(), new Flamethrower(), new Frustration(), new Heatwave(), new Hiddenpower(), new Infestation(), new Irondefense(), new Lightscreen(), new Naturepower(), new Overheat(), new Painsplit(), new Protect(), new Reflect(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Acidarmor(), new Curse(), new Earthpower(), new Guardswap(), new Heatwave(), new Inferno(), new Memento(), new Rollout(), new Smokescreen(), new Spitup(), new Stockpile(), new Swallow() };
		public override int Weight => 350;
		public override int ExpYield => 50;
		public override int CatchRate => 190;
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