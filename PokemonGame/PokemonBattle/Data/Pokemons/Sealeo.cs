using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sealeo : Pokemon
{
	public override string Name => "Sealeo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Icebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Oblivious() };
	public override Stats BaseStats => new Stats(90, 60, 70, 75, 70, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Swagger() },
		[1] = new List<Move>() { new Moves.Swagger(), new Moves.Rollout(), new Moves.Defensecurl(), new Moves.Growl(), new Moves.Watergun() },
		[12] = new List<Move>() { new Moves.Powdersnow() },
		[16] = new List<Move>() { new Moves.Rest() },
		[20] = new List<Move>() { new Moves.Snore() },
		[24] = new List<Move>() { new Moves.Brine() },
		[28] = new List<Move>() { new Moves.Aurorabeam() },
		[35] = new List<Move>() { new Moves.Encore() },
		[40] = new List<Move>() { new Moves.Bodyslam() },
		[46] = new List<Move>() { new Moves.Surf() },
		[52] = new List<Move>() { new Moves.Blizzard() },
		[58] = new List<Move>() { new Moves.Hail() },
		[64] = new List<Move>() { new Moves.Sheercold() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 876;
	public override int ExpYield => 144;
	public override int CatchRate => 120;
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