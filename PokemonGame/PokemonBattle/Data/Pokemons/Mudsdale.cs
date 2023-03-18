using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mudsdale : Pokemon
	{
		public override string Name => "Mudsdale";
		public override List<Ability> AvailableAbilities => new() {new Owntempo(), new Stamina() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(100, 125, 100, 55, 85, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Rocksmash(), new Irondefense(), new Doublekick() },
			[12] = new List<Move>() { new Bulldoze() },
			[16] = new List<Move>() { new Stomp() },
			[20] = new List<Move>() { new Strength() },
			[24] = new List<Move>() { new Counter() },
			[28] = new List<Move>() { new Highhorsepower() },
			[34] = new List<Move>() { new Heavyslam() },
			[40] = new List<Move>() { new Earthquake() },
			[46] = new List<Move>() { new Megakick() },
			[52] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Closecombat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Focusblast(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Mudshot(), new Payback(), new Protect(), new Rest(), new Revenge(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Substitute(), new Superpower() };
		public override int Weight => 9200;
		public override int ExpYield => 175;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}