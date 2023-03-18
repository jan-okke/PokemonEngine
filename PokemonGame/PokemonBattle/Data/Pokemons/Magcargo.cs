using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Magcargo : Pokemon
	{
		public override string Name => "Magcargo";
		public override List<Ability> AvailableAbilities => new() {new Magmaarmor(), new Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(60, 50, 120, 30, 90, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Shellsmash() },
			[1] = new List<Move>() { new Shellsmash(), new Earthpower(), new Yawn(), new Smog(), new Ember(), new Rockthrow() },
			[6] = new List<Move>() { new Ember() },
			[8] = new List<Move>() { new Rockthrow() },
			[13] = new List<Move>() { new Harden() },
			[15] = new List<Move>() { new Incinerate() },
			[20] = new List<Move>() { new Clearsmog() },
			[22] = new List<Move>() { new Ancientpower() },
			[29] = new List<Move>() { new Rockslide() },
			[34] = new List<Move>() { new Lavaplume() },
			[36] = new List<Move>() { new Amnesia() },
			[43] = new List<Move>() { new Bodyslam() },
			[47] = new List<Move>() { new Recover() },
			[54] = new List<Move>() { new Flamethrower() },
			[58] = new List<Move>() { new Earthpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Attract(), new Bulldoze(), new Confide(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Flamecharge(), new Flamethrower(), new Frustration(), new Gigaimpact(), new Gyroball(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Infestation(), new Irondefense(), new Lightscreen(), new Naturepower(), new Overheat(), new Painsplit(), new Protect(), new Reflect(), new Rest(), new Return(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sleeptalk(), new Smackdown(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Willowisp() };
		public override int Weight => 550;
		public override int ExpYield => 151;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}