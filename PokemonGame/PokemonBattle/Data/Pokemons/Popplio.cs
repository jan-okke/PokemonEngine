using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Popplio : Pokemon
{
	public override string Name => "Popplio";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Liquidvoice() };
	public override Stats BaseStats => new Stats(50, 54, 54, 66, 56, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Growl() },
		[3] = new List<Move>() { new Moves.Watergun() },
		[6] = new List<Move>() { new Moves.Disarmingvoice() },
		[9] = new List<Move>() { new Moves.Aquajet() },
		[12] = new List<Move>() { new Moves.Babydolleyes() },
		[15] = new List<Move>() { new Moves.Icywind() },
		[18] = new List<Move>() { new Moves.Sing() },
		[21] = new List<Move>() { new Moves.Bubblebeam() },
		[24] = new List<Move>() { new Moves.Encore() },
		[27] = new List<Move>() { new Moves.Mistyterrain() },
		[30] = new List<Move>() { new Moves.Hypervoice() },
		[33] = new List<Move>() { new Moves.Moonblast() },
		[36] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Charm(), new Moves.Dive(), new Moves.Drainingkiss(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Mistyterrain(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Whirlpool(), new Moves.Wonderroom(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquaring(), new Moves.Lifedew(), new Moves.Perishsong() };
	public override int Weight => 75;
	public override int ExpYield => 64;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}