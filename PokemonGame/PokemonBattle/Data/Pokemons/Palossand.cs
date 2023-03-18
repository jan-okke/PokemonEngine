using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Palossand : Pokemon
	{
		public override string Name => "Palossand";
		public override List<Ability> AvailableAbilities => new() {new Watercompaction() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(85, 75, 110, 35, 100, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Harden(), new Astonish(), new Sandtomb() },
			[15] = new List<Move>() { new Megadrain() },
			[20] = new List<Move>() { new Sandattack() },
			[25] = new List<Move>() { new Bulldoze() },
			[30] = new List<Move>() { new Hypnosis() },
			[35] = new List<Move>() { new Gigadrain() },
			[40] = new List<Move>() { new Irondefense() },
			[47] = new List<Move>() { new Shadowball() },
			[54] = new List<Move>() { new Earthpower() },
			[61] = new List<Move>() { new Shoreup() },
			[68] = new List<Move>() { new Sandstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Brine(), new Bulldoze(), new Earthpower(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Fling(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Irondefense(), new Mudshot(), new Poltergeist(), new Protect(), new Psychic(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute(), new Terrainpulse(), new Trick() };
		public override int Weight => 2500;
		public override int ExpYield => 168;
		public override int CatchRate => 60;
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