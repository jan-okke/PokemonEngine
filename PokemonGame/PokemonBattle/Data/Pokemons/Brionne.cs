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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Liquidvoice() };
		public override Stats BaseStats => new Stats(60, 69, 69, 91, 81, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Growl(), new Moves.Watergun(), new Moves.Disarmingvoice() },
			[9] = new List<Move>() { new Moves.Aquajet() },
			[12] = new List<Move>() { new Moves.Babydolleyes() },
			[15] = new List<Move>() { new Moves.Icywind() },
			[20] = new List<Move>() { new Moves.Sing() },
			[25] = new List<Move>() { new Moves.Bubblebeam() },
			[30] = new List<Move>() { new Moves.Encore() },
			[35] = new List<Move>() { new Moves.Mistyterrain() },
			[40] = new List<Move>() { new Moves.Hypervoice() },
			[45] = new List<Move>() { new Moves.Moonblast() },
			[50] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Charm(), new Moves.Dive(), new Moves.Drainingkiss(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Mistyterrain(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Whirlpool(), new Moves.Wonderroom(), new Moves.Workup() };
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