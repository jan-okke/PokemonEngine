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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sandforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
		public override Stats BaseStats => new Stats(89, 125, 90, 115, 80, 101);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Sandtomb(), new Moves.Rockthrow() },
			[5] = new List<Move>() { new Moves.Leer() },
			[10] = new List<Move>() { new Moves.Block() },
			[15] = new List<Move>() { new Moves.Bulldoze() },
			[20] = new List<Move>() { new Moves.Rocktomb() },
			[25] = new List<Move>() { new Moves.Swordsdance() },
			[30] = new List<Move>() { new Moves.Imprison() },
			[35] = new List<Move>() { new Moves.Rockslide() },
			[40] = new List<Move>() { new Moves.Earthpower() },
			[45] = new List<Move>() { new Moves.Extrasensory() },
			[50] = new List<Move>() { new Moves.Stoneedge() },
			[55] = new List<Move>() { new Moves.Hammerarm() },
			[60] = new List<Move>() { new Moves.Sandstorm() },
			[65] = new List<Move>() { new Moves.Earthquake() },
			[70] = new List<Move>() { new Moves.Outrage() },
			[75] = new List<Move>() { new Moves.Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Dig(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Irontail(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Uturn(), new Moves.Weatherball() };
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