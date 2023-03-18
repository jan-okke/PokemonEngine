using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sandygast : Pokemon
	{
		public override string Name => "Sandygast";
		public override List<Ability> AvailableAbilities => new() {new Watercompaction() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(55, 55, 80, 15, 70, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Harden() },
			[5] = new List<Move>() { new Astonish() },
			[10] = new List<Move>() { new Sandtomb() },
			[15] = new List<Move>() { new Megadrain() },
			[20] = new List<Move>() { new Sandattack() },
			[25] = new List<Move>() { new Bulldoze() },
			[30] = new List<Move>() { new Hypnosis() },
			[35] = new List<Move>() { new Gigadrain() },
			[40] = new List<Move>() { new Irondefense() },
			[45] = new List<Move>() { new Shadowball() },
			[50] = new List<Move>() { new Earthpower() },
			[55] = new List<Move>() { new Shoreup() },
			[60] = new List<Move>() { new Sandstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Brine(), new Bulldoze(), new Earthpower(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Hiddenpower(), new Irondefense(), new Mudshot(), new Poltergeist(), new Protect(), new Psychic(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Trick() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Curse(), new Destinybond(), new Spitup(), new Stockpile(), new Swallow() };
		public override int Weight => 700;
		public override int ExpYield => 64;
		public override int CatchRate => 140;
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