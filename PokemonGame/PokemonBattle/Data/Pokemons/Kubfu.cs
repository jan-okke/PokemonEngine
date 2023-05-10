using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Kubfu : Pokemon
{
	public override string Name => "Kubfu";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus() };
	public override Stats BaseStats => new Stats(60, 90, 60, 53, 50, 72);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Rocksmash(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Endure() },
		[8] = new List<Move>() { new Moves.Focusenergy() },
		[12] = new List<Move>() { new Moves.Aerialace() },
		[16] = new List<Move>() { new Moves.Scaryface() },
		[20] = new List<Move>() { new Moves.Headbutt() },
		[24] = new List<Move>() { new Moves.Brickbreak() },
		[28] = new List<Move>() { new Moves.Detect() },
		[32] = new List<Move>() { new Moves.Bulkup() },
		[36] = new List<Move>() { new Moves.Ironhead() },
		[40] = new List<Move>() { new Moves.Dynamicpunch() },
		[44] = new List<Move>() { new Moves.Counter() },
		[48] = new List<Move>() { new Moves.Closecombat() },
		[52] = new List<Move>() { new Moves.Focuspunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Focusenergy(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Thunderpunch(), new Moves.Uturn(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 120;
	public override int ExpYield => 77;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}