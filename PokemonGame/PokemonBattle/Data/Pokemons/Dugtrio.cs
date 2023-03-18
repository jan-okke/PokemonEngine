using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dugtrio : Pokemon
	{
		public override string Name => "Dugtrio";
		public override List<Ability> AvailableAbilities => new() {new Sandveil(), new Arenatrap() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(35, 100, 50, 120, 50, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Sandtomb() },
			[1] = new List<Move>() { new Sandtomb(), new Nightslash(), new Triattack(), new Sandattack(), new Scratch(), new Growl(), new Astonish() },
			[12] = new List<Move>() { new Mudslap() },
			[16] = new List<Move>() { new Bulldoze() },
			[20] = new List<Move>() { new Suckerpunch() },
			[24] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Sandstorm() },
			[36] = new List<Move>() { new Dig() },
			[42] = new List<Move>() { new Earthpower() },
			[48] = new List<Move>() { new Earthquake() },
			[54] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Allyswitch(), new Assurance(), new Attract(), new Beatup(), new Bodyslam(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Protect(), new Rest(), new Reversal(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Triattack(), new Uproar(), new Workup() };
		public override int Weight => 333;
		public override int ExpYield => 149;
		public override int CatchRate => 50;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}