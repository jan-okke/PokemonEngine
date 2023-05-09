using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sawk : Pokemon
{
	public override string Name => "Sawk";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Innerfocus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moldbreaker() };
	public override Stats BaseStats => new Stats(75, 125, 75, 30, 75, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Rocksmash(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Focusenergy() },
		[10] = new List<Move>() { new Moves.Doublekick() },
		[15] = new List<Move>() { new Moves.Quickguard() },
		[20] = new List<Move>() { new Moves.Lowsweep() },
		[25] = new List<Move>() { new Moves.Bulkup() },
		[30] = new List<Move>() { new Moves.Retaliate() },
		[35] = new List<Move>() { new Moves.Brickbreak() },
		[40] = new List<Move>() { new Moves.Counter() },
		[45] = new List<Move>() { new Moves.Endure() },
		[50] = new List<Move>() { new Moves.Reversal() },
		[55] = new List<Move>() { new Moves.Closecombat() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 510;
	public override int ExpYield => 163;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}