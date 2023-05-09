using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Hitmontop : Pokemon
{
	public override string Name => "Hitmontop";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Technician() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Steadfast() };
	public override Stats BaseStats => new Stats(50, 95, 95, 35, 110, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Triplekick() },
		[1] = new List<Move>() { new Moves.Triplekick(), new Moves.Feint(), new Moves.Rapidspin(), new Moves.Tackle(), new Moves.Helpinghand(), new Moves.Fakeout(), new Moves.Focusenergy() },
		[4] = new List<Move>() { new Moves.Quickattack() },
		[8] = new List<Move>() { new Moves.Gyroball() },
		[12] = new List<Move>() { new Moves.Detect() },
		[16] = new List<Move>() { new Moves.Revenge() },
		[21] = new List<Move>() { new Moves.Wideguard(), new Moves.Quickguard() },
		[24] = new List<Move>() { new Moves.Suckerpunch() },
		[28] = new List<Move>() { new Moves.Agility() },
		[32] = new List<Move>() { new Moves.Dig() },
		[36] = new List<Move>() { new Moves.Closecombat() },
		[40] = new List<Move>() { new Moves.Counter() },
		[44] = new List<Move>() { new Moves.Endeavor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Workup() };
	public override int Weight => 480;
	public override int ExpYield => 159;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}