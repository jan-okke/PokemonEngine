using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sandaconda : Pokemon
	{
		public override string Name => "Sandaconda";
		public override List<Ability> AvailableAbilities => new() {new Sandspit(), new Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(72, 107, 125, 65, 70, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Skullbash(), new Wrap(), new Sandattack(), new Minimize(), new Brutalswing() },
			[15] = new List<Move>() { new Bulldoze() },
			[20] = new List<Move>() { new Headbutt() },
			[25] = new List<Move>() { new Glare() },
			[30] = new List<Move>() { new Dig() },
			[35] = new List<Move>() { new Sandstorm() },
			[42] = new List<Move>() { new Slam() },
			[49] = new List<Move>() { new Coil() },
			[51] = new List<Move>() { new Sandtomb() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Brutalswing(), new Bulldoze(), new Dig(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firefang(), new Gigaimpact(), new Hiddenpower(), new Highhorsepower(), new Hurricane(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Mudshot(), new Outrage(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaleshot(), new Scorchingsands(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Zenheadbutt() };
		public override int Weight => 655;
		public override int ExpYield => 179;
		public override int CatchRate => 120;
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