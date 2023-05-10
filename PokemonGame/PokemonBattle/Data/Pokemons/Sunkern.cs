using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sunkern : Pokemon
{
	public override string Name => "Sunkern";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Solarpower() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Earlybird() };
	public override Stats BaseStats => new Stats(30, 30, 30, 30, 30, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growth() },
		[4] = new List<Move>() { new Moves.Ingrain() },
		[7] = new List<Move>() { new Moves.Absorb() },
		[10] = new List<Move>() { new Moves.Megadrain() },
		[13] = new List<Move>() { new Moves.Leechseed() },
		[16] = new List<Move>() { new Moves.Razorleaf() },
		[19] = new List<Move>() { new Moves.Worryseed() },
		[22] = new List<Move>() { new Moves.Gigadrain() },
		[25] = new List<Move>() { new Moves.Endeavor() },
		[28] = new List<Move>() { new Moves.Synthesis() },
		[34] = new List<Move>() { new Moves.Solarbeam() },
		[37] = new List<Move>() { new Moves.Doubleedge() },
		[40] = new List<Move>() { new Moves.Sunnyday() },
		[43] = new List<Move>() { new Moves.Seedbomb() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Attract(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Uproar(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Encore(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Ingrain(), new Moves.Leechseed(), new Moves.Morningsun(), new Moves.Naturepower(), new Moves.Sweetscent() };
	public override int Weight => 18;
	public override int ExpYield => 36;
	public override int CatchRate => 235;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}