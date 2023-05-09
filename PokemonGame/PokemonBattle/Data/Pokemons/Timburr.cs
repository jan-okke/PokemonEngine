using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Timburr : Pokemon
{
	public override string Name => "Timburr";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Guts(), new Abilities.Sheerforce() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Ironfist() };
	public override Stats BaseStats => new Stats(75, 80, 55, 25, 35, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Lowkick() },
		[8] = new List<Move>() { new Moves.Rockthrow() },
		[12] = new List<Move>() { new Moves.Focusenergy() },
		[16] = new List<Move>() { new Moves.Bulkup() },
		[20] = new List<Move>() { new Moves.Rockslide() },
		[24] = new List<Move>() { new Moves.Slam() },
		[28] = new List<Move>() { new Moves.Scaryface() },
		[32] = new List<Move>() { new Moves.Dynamicpunch() },
		[36] = new List<Move>() { new Moves.Hammerarm() },
		[40] = new List<Move>() { new Moves.Stoneedge() },
		[44] = new List<Move>() { new Moves.Superpower() },
		[48] = new List<Move>() { new Moves.Focuspunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Coaching(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Defog(), new Moves.Detect(), new Moves.Machpunch(), new Moves.Poweruppunch(), new Moves.Wideguard() };
	public override int Weight => 125;
	public override int ExpYield => 61;
	public override int CatchRate => 180;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}