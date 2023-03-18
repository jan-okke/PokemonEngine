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
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Cheekpouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hugepower() };
		public override Stats BaseStats => new Stats(38, 36, 38, 32, 36, 57);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Leer() },
			[3] = new List<Move>() { new Tackle() },
			[6] = new List<Move>() { new Laserfocus() },
			[9] = new List<Move>() { new Quickattack() },
			[12] = new List<Move>() { new Mudshot() },
			[15] = new List<Move>() { new Flail() },
			[18] = new List<Move>() { new Doublekick() },
			[21] = new List<Move>() { new Bulldoze() },
			[24] = new List<Move>() { new Dig() },
			[27] = new List<Move>() { new Bounce() },
			[30] = new List<Move>() { new Takedown() },
			[33] = new List<Move>() { new Swordsdance() },
			[36] = new List<Move>() { new Earthquake() },
			[39] = new List<Move>() { new Superfang() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bounce(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Dig(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Grassknot(), new Hiddenpower(), new Ironhead(), new Irontail(), new Mudshot(), new Payback(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Spikes(), new Stoneedge(), new Substitute(), new Surf(), new Swordsdance(), new Thief(), new Uturn(), new Wildcharge(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Defensecurl(), new Rollout() };
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