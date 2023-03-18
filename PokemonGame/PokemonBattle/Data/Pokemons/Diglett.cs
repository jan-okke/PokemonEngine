using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Diglett : Pokemon
	{
		public override string Name => "Diglett";
		public override List<Ability> AvailableAbilities => new() {new Sandveil(), new Arenatrap() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(10, 55, 25, 35, 45, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sandattack(), new Scratch() },
			[4] = new List<Move>() { new Growl() },
			[8] = new List<Move>() { new Astonish() },
			[12] = new List<Move>() { new Mudslap() },
			[16] = new List<Move>() { new Bulldoze() },
			[20] = new List<Move>() { new Suckerpunch() },
			[24] = new List<Move>() { new Slash() },
			[28] = new List<Move>() { new Sandstorm() },
			[32] = new List<Move>() { new Dig() },
			[36] = new List<Move>() { new Earthpower() },
			[40] = new List<Move>() { new Earthquake() },
			[44] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Allyswitch(), new Assurance(), new Attract(), new Beatup(), new Bodyslam(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Hiddenpower(), new Protect(), new Rest(), new Reversal(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scorchingsands(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Uproar(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Astonish(), new Beatup(), new Finalgambit(), new Headbutt(), new Honeclaws(), new Memento(), new Reversal(), new Screech(), new Uproar() };
		public override int Weight => 8;
		public override int ExpYield => 53;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}