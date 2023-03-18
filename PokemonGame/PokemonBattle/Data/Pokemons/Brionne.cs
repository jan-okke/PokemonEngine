using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Brionne : Pokemon
	{
		public override string Name => "Brionne";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Liquidvoice() };
		public override Stats BaseStats => new Stats(60, 69, 69, 91, 81, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Growl(), new Watergun(), new Disarmingvoice() },
			[9] = new List<Move>() { new Aquajet() },
			[12] = new List<Move>() { new Babydolleyes() },
			[15] = new List<Move>() { new Icywind() },
			[20] = new List<Move>() { new Sing() },
			[25] = new List<Move>() { new Bubblebeam() },
			[30] = new List<Move>() { new Encore() },
			[35] = new List<Move>() { new Mistyterrain() },
			[40] = new List<Move>() { new Hypervoice() },
			[45] = new List<Move>() { new Moonblast() },
			[50] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Amnesia(), new Attract(), new Blizzard(), new Brine(), new Charm(), new Dive(), new Drainingkiss(), new Encore(), new Endure(), new Facade(), new Flipturn(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Icebeam(), new Icywind(), new Irontail(), new Mistyterrain(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Tripleaxel(), new Uproar(), new Waterfall(), new Waterpledge(), new Whirlpool(), new Wonderroom(), new Workup() };
		public override int Weight => 175;
		public override int ExpYield => 147;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}