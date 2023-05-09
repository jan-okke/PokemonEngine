using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Weepinbell : Pokemon
{
	public override string Name => "Weepinbell";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
	public override Stats BaseStats => new Stats(65, 90, 50, 85, 45, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Vinewhip(), new Moves.Growth(), new Moves.Wrap() },
		[7] = new List<Move>() { new Moves.Growth() },
		[11] = new List<Move>() { new Moves.Wrap() },
		[13] = new List<Move>() { new Moves.Sleeppowder() },
		[15] = new List<Move>() { new Moves.Poisonpowder() },
		[17] = new List<Move>() { new Moves.Stunspore() },
		[24] = new List<Move>() { new Moves.Acid() },
		[29] = new List<Move>() { new Moves.Knockoff() },
		[32] = new List<Move>() { new Moves.Sweetscent() },
		[39] = new List<Move>() { new Moves.Gastroacid() },
		[44] = new List<Move>() { new Moves.Razorleaf() },
		[47] = new List<Move>() { new Moves.Poisonjab() },
		[54] = new List<Move>() { new Moves.Slam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bind(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Naturepower(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thief(), new Moves.Venoshock(), new Moves.Worryseed() };
	public override int Weight => 64;
	public override int ExpYield => 137;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}