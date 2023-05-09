using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Hitmonlee : Pokemon
{
	public override string Name => "Hitmonlee";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Limber(), new Abilities.Reckless() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unburden() };
	public override Stats BaseStats => new Stats(50, 120, 53, 35, 110, 87);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Brickbreak() },
		[1] = new List<Move>() { new Moves.Brickbreak(), new Moves.Feint(), new Moves.Lowsweep(), new Moves.Tackle(), new Moves.Helpinghand(), new Moves.Fakeout(), new Moves.Focusenergy() },
		[4] = new List<Move>() { new Moves.Doublekick() },
		[8] = new List<Move>() { new Moves.Lowkick() },
		[12] = new List<Move>() { new Moves.Endure() },
		[16] = new List<Move>() { new Moves.Revenge() },
		[21] = new List<Move>() { new Moves.Wideguard() },
		[24] = new List<Move>() { new Moves.Blazekick() },
		[28] = new List<Move>() { new Moves.Mindreader() },
		[32] = new List<Move>() { new Moves.Megakick() },
		[36] = new List<Move>() { new Moves.Closecombat() },
		[40] = new List<Move>() { new Moves.Reversal() },
		[44] = new List<Move>() { new Moves.Highjumpkick() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Aurasphere(), new Moves.Blazekick(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Uproar(), new Moves.Workup() };
	public override int Weight => 498;
	public override int ExpYield => 159;
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