using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bunnelby : Pokemon
	{
		public override string Name => "Bunnelby";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pickup(), new Abilities.Cheekpouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hugepower() };
		public override Stats BaseStats => new Stats(38, 36, 38, 32, 36, 57);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Leer() },
			[3] = new List<Move>() { new Moves.Tackle() },
			[6] = new List<Move>() { new Moves.Laserfocus() },
			[9] = new List<Move>() { new Moves.Quickattack() },
			[12] = new List<Move>() { new Moves.Mudshot() },
			[15] = new List<Move>() { new Moves.Flail() },
			[18] = new List<Move>() { new Moves.Doublekick() },
			[21] = new List<Move>() { new Moves.Bulldoze() },
			[24] = new List<Move>() { new Moves.Dig() },
			[27] = new List<Move>() { new Moves.Bounce() },
			[30] = new List<Move>() { new Moves.Takedown() },
			[33] = new List<Move>() { new Moves.Swordsdance() },
			[36] = new List<Move>() { new Moves.Earthquake() },
			[39] = new List<Move>() { new Moves.Superfang() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Spikes(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Uturn(), new Moves.Wildcharge(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Defensecurl(), new Moves.Rollout() };
		public override int Weight => 50;
		public override int ExpYield => 47;
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