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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Watercompaction() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
		public override Stats BaseStats => new Stats(55, 55, 80, 70, 45, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Absorb(), new Moves.Harden() },
			[5] = new List<Move>() { new Moves.Astonish() },
			[10] = new List<Move>() { new Moves.Sandtomb() },
			[15] = new List<Move>() { new Moves.Megadrain() },
			[20] = new List<Move>() { new Moves.Sandattack() },
			[25] = new List<Move>() { new Moves.Bulldoze() },
			[30] = new List<Move>() { new Moves.Hypnosis() },
			[35] = new List<Move>() { new Moves.Gigadrain() },
			[40] = new List<Move>() { new Moves.Irondefense() },
			[45] = new List<Move>() { new Moves.Shadowball() },
			[50] = new List<Move>() { new Moves.Earthpower() },
			[55] = new List<Move>() { new Moves.Shoreup() },
			[60] = new List<Move>() { new Moves.Sandstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Mudshot(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Trick() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Curse(), new Moves.Destinybond(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow() };
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