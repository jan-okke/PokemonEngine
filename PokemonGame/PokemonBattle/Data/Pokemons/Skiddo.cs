using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Skiddo : Pokemon
{
	public override string Name => "Skiddo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sapsipper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Grasspelt() };
	public override Stats BaseStats => new Stats(66, 65, 48, 62, 57, 52);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growth() },
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
		[38] = new List<Move>() { new Moves.Doubleedge() },
		[42] = new List<Move>() { new Moves.Hornleech() },
		[45] = new List<Move>() { new Moves.Leafblade() },
		[50] = new List<Move>() { new Moves.Milkdrink() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Toxic(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Worryseed(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Defensecurl(), new Moves.Grassyterrain(), new Moves.Milkdrink(), new Moves.Rollout() };
	public override int Weight => 310;
	public override int ExpYield => 70;
	public override int CatchRate => 200;
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