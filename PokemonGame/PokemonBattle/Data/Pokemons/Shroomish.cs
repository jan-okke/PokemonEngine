using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Shroomish : Pokemon
{
	public override string Name => "Shroomish";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Effectspore(), new Abilities.Poisonheal() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Quickfeet() };
	public override Stats BaseStats => new Stats(60, 40, 60, 40, 60, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Stunspore() },
		[8] = new List<Move>() { new Moves.Leechseed() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[15] = new List<Move>() { new Moves.Headbutt() },
		[19] = new List<Move>() { new Moves.Poisonpowder() },
		[22] = new List<Move>() { new Moves.Worryseed() },
		[26] = new List<Move>() { new Moves.Gigadrain() },
		[29] = new List<Move>() { new Moves.Growth() },
		[33] = new List<Move>() { new Moves.Toxic() },
		[36] = new List<Move>() { new Moves.Seedbomb() },
		[40] = new List<Move>() { new Moves.Spore() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Toxic(), new Moves.Venoshock(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Charm(), new Moves.Faketears(), new Moves.Helpinghand(), new Moves.Seedbomb(), new Moves.Worryseed() };
	public override int Weight => 45;
	public override int ExpYield => 59;
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