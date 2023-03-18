using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shellos : Pokemon
	{
		public override string Name => "Shellos";
		public override List<Ability> AvailableAbilities => new() {new Stickyhold(), new Stormdrain() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(76, 48, 48, 34, 57, 62);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Mudslap() },
			[5] = new List<Move>() { new Harden() },
			[10] = new List<Move>() { new Recover() },
			[15] = new List<Move>() { new Waterpulse() },
			[20] = new List<Move>() { new Ancientpower() },
			[25] = new List<Move>() { new Bodyslam() },
			[31] = new List<Move>() { new Muddywater() },
			[35] = new List<Move>() { new Earthpower() },
			[40] = new List<Move>() { new Raindance() },
			[45] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Dive(), new Doubleteam(), new Earthpower(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Acidarmor(), new Amnesia(), new Clearsmog(), new Counter(), new Curse(), new Fissure(), new Memento(), new Mirrorcoat(), new Mist(), new Sludge(), new Spitup(), new Stockpile(), new Swallow(), new Yawn() };
		public override int Weight => 63;
		public override int ExpYield => 65;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}