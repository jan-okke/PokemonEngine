using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Walrein : Pokemon
{
	public override string Name => "Walrein";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Icebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Oblivious() };
	public override Stats BaseStats => new Stats(110, 80, 90, 95, 90, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Swagger(), new Moves.Crunch(), new Moves.Icefang(), new Moves.Rollout(), new Moves.Defensecurl(), new Moves.Growl(), new Moves.Watergun() },
		[12] = new List<Move>() { new Moves.Powdersnow() },
		[16] = new List<Move>() { new Moves.Rest() },
		[20] = new List<Move>() { new Moves.Snore() },
		[24] = new List<Move>() { new Moves.Brine() },
		[28] = new List<Move>() { new Moves.Aurorabeam() },
		[35] = new List<Move>() { new Moves.Encore() },
		[40] = new List<Move>() { new Moves.Bodyslam() },
		[48] = new List<Move>() { new Moves.Surf() },
		[56] = new List<Move>() { new Moves.Blizzard() },
		[64] = new List<Move>() { new Moves.Hail() },
		[72] = new List<Move>() { new Moves.Sheercold() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 1506;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}