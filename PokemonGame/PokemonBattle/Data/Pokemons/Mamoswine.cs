using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mamoswine : Pokemon
	{
		public override string Name => "Mamoswine";
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Snowcloak() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Thickfat() };
		public override Stats BaseStats => new Stats(110, 130, 80, 80, 70, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Doublehit() },
			[1] = new List<Move>() { new Doublehit(), new Icefang(), new Ancientpower(), new Tackle(), new Mudslap(), new Powdersnow(), new Flail() },
			[15] = new List<Move>() { new Iceshard() },
			[20] = new List<Move>() { new Mist() },
			[25] = new List<Move>() { new Endure() },
			[30] = new List<Move>() { new Icywind() },
			[37] = new List<Move>() { new Amnesia() },
			[44] = new List<Move>() { new Takedown() },
			[51] = new List<Move>() { new Earthquake() },
			[58] = new List<Move>() { new Blizzard() },
			[65] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Hail(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icebeam(), new Icefang(), new Iciclespear(), new Icywind(), new Ironhead(), new Lightscreen(), new Mudshot(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Roar(), new Rockblast(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Superpower(), new Swagger() };
		public override int Weight => 2910;
		public override int ExpYield => 265;
		public override int CatchRate => 50;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}