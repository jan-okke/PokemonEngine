using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Omanyte : Pokemon
{
	public override string Name => "Omanyte";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Shellarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
	public override Stats BaseStats => new Stats(35, 40, 100, 90, 55, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Bind(), new Moves.Withdraw() },
		[5] = new List<Move>() { new Moves.Rollout() },
		[10] = new List<Move>() { new Moves.Sandattack() },
		[15] = new List<Move>() { new Moves.Watergun() },
		[20] = new List<Move>() { new Moves.Leer() },
		[25] = new List<Move>() { new Moves.Mudshot() },
		[30] = new List<Move>() { new Moves.Ancientpower() },
		[35] = new List<Move>() { new Moves.Brine() },
		[41] = new List<Move>() { new Moves.Protect() },
		[45] = new List<Move>() { new Moves.Rockblast() },
		[50] = new List<Move>() { new Moves.Surf() },
		[55] = new List<Move>() { new Moves.Shellsmash() },
		[60] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Meteorbeam(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Toxicspikes(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aurorabeam(), new Moves.Bite(), new Moves.Bubblebeam(), new Moves.Haze(), new Moves.Knockoff(), new Moves.Muddywater(), new Moves.Reflecttype(), new Moves.Slam(), new Moves.Spikes(), new Moves.Supersonic(), new Moves.Tickle(), new Moves.Toxicspikes(), new Moves.Whirlpool() };
	public override int Weight => 75;
	public override int ExpYield => 71;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}