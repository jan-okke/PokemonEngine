using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Throh : Pokemon
{
	public override string Name => "Throh";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Guts(), new Abilities.Innerfocus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moldbreaker() };
	public override Stats BaseStats => new Stats(120, 100, 85, 30, 85, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Bind(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Focusenergy() },
		[10] = new List<Move>() { new Moves.Circlethrow() },
		[15] = new List<Move>() { new Moves.Wideguard() },
		[20] = new List<Move>() { new Moves.Revenge() },
		[25] = new List<Move>() { new Moves.Bulkup() },
		[30] = new List<Move>() { new Moves.Stormthrow() },
		[35] = new List<Move>() { new Moves.Vitalthrow() },
		[40] = new List<Move>() { new Moves.Seismictoss() },
		[45] = new List<Move>() { new Moves.Endure() },
		[50] = new List<Move>() { new Moves.Reversal() },
		[55] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Coaching(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 555;
	public override int ExpYield => 163;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}