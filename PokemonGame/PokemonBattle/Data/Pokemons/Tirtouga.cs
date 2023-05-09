using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tirtouga : Pokemon
{
	public override string Name => "Tirtouga";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Solidrock(), new Abilities.Sturdy() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
	public override Stats BaseStats => new Stats(54, 78, 103, 53, 45, 22);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Withdraw() },
		[3] = new List<Move>() { new Moves.Protect() },
		[6] = new List<Move>() { new Moves.Aquajet() },
		[9] = new List<Move>() { new Moves.Smackdown() },
		[12] = new List<Move>() { new Moves.Ancientpower() },
		[15] = new List<Move>() { new Moves.Bite() },
		[18] = new List<Move>() { new Moves.Wideguard() },
		[21] = new List<Move>() { new Moves.Brine() },
		[24] = new List<Move>() { new Moves.Rockslide() },
		[27] = new List<Move>() { new Moves.Crunch() },
		[30] = new List<Move>() { new Moves.Curse() },
		[33] = new List<Move>() { new Moves.Irondefense() },
		[36] = new List<Move>() { new Moves.Aquatail() },
		[39] = new List<Move>() { new Moves.Raindance() },
		[42] = new List<Move>() { new Moves.Hydropump() },
		[45] = new List<Move>() { new Moves.Shellsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dig(), new Moves.Dive(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Meteorbeam(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Surf(), new Moves.Waterfall(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Block(), new Moves.Knockoff(), new Moves.Rockthrow(), new Moves.Rollout(), new Moves.Slam(), new Moves.Waterpulse() };
	public override int Weight => 165;
	public override int ExpYield => 71;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}