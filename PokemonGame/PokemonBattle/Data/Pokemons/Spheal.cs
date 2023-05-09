using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Spheal : Pokemon
{
	public override string Name => "Spheal";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Icebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Oblivious() };
	public override Stats BaseStats => new Stats(70, 40, 50, 55, 50, 25);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Rollout(), new Moves.Defensecurl() },
		[4] = new List<Move>() { new Moves.Growl() },
		[8] = new List<Move>() { new Moves.Watergun() },
		[12] = new List<Move>() { new Moves.Powdersnow() },
		[16] = new List<Move>() { new Moves.Rest() },
		[20] = new List<Move>() { new Moves.Snore() },
		[24] = new List<Move>() { new Moves.Brine() },
		[28] = new List<Move>() { new Moves.Aurorabeam() },
		[33] = new List<Move>() { new Moves.Encore() },
		[36] = new List<Move>() { new Moves.Bodyslam() },
		[40] = new List<Move>() { new Moves.Surf() },
		[44] = new List<Move>() { new Moves.Blizzard() },
		[48] = new List<Move>() { new Moves.Hail() },
		[52] = new List<Move>() { new Moves.Sheercold() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aquaring(), new Moves.Bellydrum(), new Moves.Curse(), new Moves.Fissure(), new Moves.Rollout(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Yawn() };
	public override int Weight => 395;
	public override int ExpYield => 58;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}