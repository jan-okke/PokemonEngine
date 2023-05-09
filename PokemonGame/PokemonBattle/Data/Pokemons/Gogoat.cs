using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gogoat : Pokemon
{
	public override string Name => "Gogoat";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sapsipper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Grasspelt() };
	public override Stats BaseStats => new Stats(123, 100, 62, 97, 81, 68);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Aerialace() },
		[1] = new List<Move>() { new Moves.Aerialace(), new Moves.Earthquake(), new Moves.Tackle(), new Moves.Growth(), new Moves.Vinewhip(), new Moves.Tailwhip() },
		[7] = new List<Move>() { new Moves.Vinewhip() },
		[9] = new List<Move>() { new Moves.Tailwhip() },
		[12] = new List<Move>() { new Moves.Leechseed() },
		[13] = new List<Move>() { new Moves.Razorleaf() },
		[16] = new List<Move>() { new Moves.Worryseed() },
		[20] = new List<Move>() { new Moves.Synthesis() },
		[22] = new List<Move>() { new Moves.Takedown() },
		[26] = new List<Move>() { new Moves.Bulldoze() },
		[30] = new List<Move>() { new Moves.Seedbomb() },
		[34] = new List<Move>() { new Moves.Bulkup() },
		[40] = new List<Move>() { new Moves.Doubleedge() },
		[47] = new List<Move>() { new Moves.Hornleech() },
		[55] = new List<Move>() { new Moves.Leafblade() },
		[58] = new List<Move>() { new Moves.Milkdrink() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Toxic(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Worryseed(), new Moves.Zenheadbutt() };
	public override int Weight => 910;
	public override int ExpYield => 186;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}