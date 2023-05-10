using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Basculin : Pokemon
{
	public override string Name => "Basculin";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Reckless(), new Abilities.Adaptability() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moldbreaker() };
	public override Stats BaseStats => new Stats(70, 92, 65, 80, 55, 98);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Tailwhip() },
		[4] = new List<Move>() { new Moves.Tackle() },
		[8] = new List<Move>() { new Moves.Flail() },
		[12] = new List<Move>() { new Moves.Aquajet() },
		[16] = new List<Move>() { new Moves.Bite() },
		[20] = new List<Move>() { new Moves.Scaryface() },
		[24] = new List<Move>() { new Moves.Headbutt() },
		[28] = new List<Move>() { new Moves.Soak() },
		[32] = new List<Move>() { new Moves.Crunch() },
		[36] = new List<Move>() { new Moves.Takedown() },
		[40] = new List<Move>() { new Moves.Finalgambit() },
		[44] = new List<Move>() { new Moves.Aquatail() },
		[48] = new List<Move>() { new Moves.Thrash() },
		[52] = new List<Move>() { new Moves.Doubleedge() },
		[56] = new List<Move>() { new Moves.Headsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bounce(), new Moves.Brine(), new Moves.Crunch(), new Moves.Dive(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swift(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bubblebeam(), new Moves.Endeavor() };
	public override int Weight => 180;
	public override int ExpYield => 161;
	public override int CatchRate => 25;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}