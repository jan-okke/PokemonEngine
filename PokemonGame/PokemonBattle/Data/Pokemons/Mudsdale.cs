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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Owntempo(), new Abilities.Stamina() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
		public override Stats BaseStats => new Stats(100, 125, 100, 55, 85, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Rocksmash(), new Moves.Irondefense(), new Moves.Doublekick() },
			[12] = new List<Move>() { new Moves.Bulldoze() },
			[16] = new List<Move>() { new Moves.Stomp() },
			[20] = new List<Move>() { new Moves.Strength() },
			[24] = new List<Move>() { new Moves.Counter() },
			[28] = new List<Move>() { new Moves.Highhorsepower() },
			[34] = new List<Move>() { new Moves.Heavyslam() },
			[40] = new List<Move>() { new Moves.Earthquake() },
			[46] = new List<Move>() { new Moves.Megakick() },
			[52] = new List<Move>() { new Moves.Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower() };
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