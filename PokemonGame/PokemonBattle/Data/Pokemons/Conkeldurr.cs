using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Conkeldurr : Pokemon
{
	public override string Name => "Conkeldurr";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Guts(), new Abilities.Sheerforce() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Ironfist() };
	public override Stats BaseStats => new Stats(105, 140, 95, 55, 65, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Leer(), new Moves.Lowkick(), new Moves.Rockthrow() },
		[12] = new List<Move>() { new Moves.Focusenergy() },
		[16] = new List<Move>() { new Moves.Bulkup() },
		[20] = new List<Move>() { new Moves.Rockslide() },
		[24] = new List<Move>() { new Moves.Slam() },
		[30] = new List<Move>() { new Moves.Scaryface() },
		[36] = new List<Move>() { new Moves.Dynamicpunch() },
		[42] = new List<Move>() { new Moves.Hammerarm() },
		[48] = new List<Move>() { new Moves.Stoneedge() },
		[54] = new List<Move>() { new Moves.Superpower() },
		[60] = new List<Move>() { new Moves.Focuspunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Workup() };
	public override int Weight => 870;
	public override int ExpYield => 253;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}