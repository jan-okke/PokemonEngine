using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mudbray : Pokemon
	{
		public override string Name => "Mudbray";
		public override List<Ability> AvailableAbilities => new() {new Owntempo(), new Stamina() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(70, 100, 70, 45, 45, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Rocksmash() },
			[4] = new List<Move>() { new Irondefense() },
			[8] = new List<Move>() { new Doublekick() },
			[12] = new List<Move>() { new Bulldoze() },
			[16] = new List<Move>() { new Stomp() },
			[20] = new List<Move>() { new Strength() },
			[24] = new List<Move>() { new Counter() },
			[28] = new List<Move>() { new Highhorsepower() },
			[32] = new List<Move>() { new Heavyslam() },
			[36] = new List<Move>() { new Earthquake() },
			[40] = new List<Move>() { new Megakick() },
			[44] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Bulldoze(), new Closecombat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Irondefense(), new Ironhead(), new Lowkick(), new Lowsweep(), new Megakick(), new Payback(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Substitute(), new Superpower() };
		public override List<Move> EggMoves => new List<Move>() { new Doubleedge(), new Fissure(), new Roar(), new Smackdown() };
		public override int Weight => 1100;
		public override int ExpYield => 77;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}