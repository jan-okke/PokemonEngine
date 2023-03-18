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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Magmaarmor(), new Abilities.Flamebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
		public override Stats BaseStats => new Stats(60, 50, 120, 90, 80, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Shellsmash() },
			[1] = new List<Move>() { new Moves.Shellsmash(), new Moves.Earthpower(), new Moves.Yawn(), new Moves.Smog(), new Moves.Ember(), new Moves.Rockthrow() },
			[6] = new List<Move>() { new Moves.Ember() },
			[8] = new List<Move>() { new Moves.Rockthrow() },
			[13] = new List<Move>() { new Moves.Harden() },
			[15] = new List<Move>() { new Moves.Incinerate() },
			[20] = new List<Move>() { new Moves.Clearsmog() },
			[22] = new List<Move>() { new Moves.Ancientpower() },
			[29] = new List<Move>() { new Moves.Rockslide() },
			[34] = new List<Move>() { new Moves.Lavaplume() },
			[36] = new List<Move>() { new Moves.Amnesia() },
			[43] = new List<Move>() { new Moves.Bodyslam() },
			[47] = new List<Move>() { new Moves.Recover() },
			[54] = new List<Move>() { new Moves.Flamethrower() },
			[58] = new List<Move>() { new Moves.Earthpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Attract(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Overheat(), new Moves.Painsplit(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Willowisp() };
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