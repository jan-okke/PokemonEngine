using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Landorus : Pokemon
	{
		public override string Name => "Landorus";
		public override List<Ability> AvailableAbilities => new() {new Sandforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(89, 125, 90, 115, 80, 101);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sandtomb(), new Rockthrow() },
			[5] = new List<Move>() { new Leer() },
			[10] = new List<Move>() { new Block() },
			[15] = new List<Move>() { new Bulldoze() },
			[20] = new List<Move>() { new Rocktomb() },
			[25] = new List<Move>() { new Swordsdance() },
			[30] = new List<Move>() { new Imprison() },
			[35] = new List<Move>() { new Rockslide() },
			[40] = new List<Move>() { new Earthpower() },
			[45] = new List<Move>() { new Extrasensory() },
			[50] = new List<Move>() { new Stoneedge() },
			[55] = new List<Move>() { new Hammerarm() },
			[60] = new List<Move>() { new Sandstorm() },
			[65] = new List<Move>() { new Earthquake() },
			[70] = new List<Move>() { new Outrage() },
			[75] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Calmmind(), new Dig(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Fly(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Irontail(), new Mudshot(), new Outrage(), new Payback(), new Protect(), new Psychic(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Selfdestruct(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Superpower(), new Swordsdance(), new Uturn(), new Weatherball() };
		public override int Weight => 680;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}