using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Seedot : Pokemon
{
	public override string Name => "Seedot";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Earlybird() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickpocket() };
	public override Stats BaseStats => new Stats(40, 40, 50, 30, 30, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
		[3] = new List<Move>() { new Moves.Absorb() },
		[6] = new List<Move>() { new Moves.Astonish() },
		[9] = new List<Move>() { new Moves.Growth() },
		[12] = new List<Move>() { new Moves.Rollout() },
		[15] = new List<Move>() { new Moves.Megadrain() },
		[18] = new List<Move>() { new Moves.Payback() },
		[21] = new List<Move>() { new Moves.Naturepower() },
		[24] = new List<Move>() { new Moves.Sunnyday() },
		[27] = new List<Move>() { new Moves.Synthesis() },
		[30] = new List<Move>() { new Moves.Suckerpunch() },
		[33] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Bulletseed(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Explosion(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Beatup(), new Moves.Foulplay(), new Moves.Grassyterrain(), new Moves.Leechseed(), new Moves.Nightslash(), new Moves.Powerswap(), new Moves.Quickattack(), new Moves.Takedown(), new Moves.Worryseed() };
	public override int Weight => 40;
	public override int ExpYield => 44;
	public override int CatchRate => 255;
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