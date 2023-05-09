using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Shellos : Pokemon
{
	public override string Name => "Shellos";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Stickyhold(), new Abilities.Stormdrain() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
	public override Stats BaseStats => new Stats(76, 48, 48, 57, 62, 34);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Mudslap() },
		[5] = new List<Move>() { new Moves.Harden() },
		[10] = new List<Move>() { new Moves.Recover() },
		[15] = new List<Move>() { new Moves.Waterpulse() },
		[20] = new List<Move>() { new Moves.Ancientpower() },
		[25] = new List<Move>() { new Moves.Bodyslam() },
		[31] = new List<Move>() { new Moves.Muddywater() },
		[35] = new List<Move>() { new Moves.Earthpower() },
		[40] = new List<Move>() { new Moves.Raindance() },
		[45] = new List<Move>() { new Moves.Memento() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidarmor(), new Moves.Amnesia(), new Moves.Clearsmog(), new Moves.Counter(), new Moves.Curse(), new Moves.Fissure(), new Moves.Memento(), new Moves.Mirrorcoat(), new Moves.Mist(), new Moves.Sludge(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Yawn() };
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