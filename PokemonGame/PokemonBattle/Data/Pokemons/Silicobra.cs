using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Silicobra : Pokemon
	{
		public override string Name => "Silicobra";
		public override List<Ability> AvailableAbilities => new() {new Sandspit(), new Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(52, 57, 75, 46, 35, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap(), new Sandattack() },
			[5] = new List<Move>() { new Minimize() },
			[10] = new List<Move>() { new Brutalswing() },
			[15] = new List<Move>() { new Bulldoze() },
			[20] = new List<Move>() { new Headbutt() },
			[25] = new List<Move>() { new Glare() },
			[30] = new List<Move>() { new Dig() },
			[35] = new List<Move>() { new Sandstorm() },
			[40] = new List<Move>() { new Slam() },
			[45] = new List<Move>() { new Coil() },
			[50] = new List<Move>() { new Sandtomb() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brutalswing(), new Bulldoze(), new Dig(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Hiddenpower(), new Mudshot(), new Protect(), new Rest(), new Round(), new Sandstorm(), new Sandtomb(), new Scaleshot(), new Scorchingsands(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Dragonrush(), new Lastresort(), new Mudslap(), new Poisontail() };
		public override int Weight => 76;
		public override int ExpYield => 63;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}