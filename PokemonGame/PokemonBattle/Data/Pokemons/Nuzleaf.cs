using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Nuzleaf : Pokemon
{
	public override string Name => "Nuzleaf";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Earlybird() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickpocket() };
	public override Stats BaseStats => new Stats(70, 70, 40, 60, 40, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Razorleaf() },
		[1] = new List<Move>() { new Moves.Razorleaf(), new Moves.Aircutter(), new Moves.Torment(), new Moves.Fakeout(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Explosion(), new Moves.Tackle(), new Moves.Harden(), new Moves.Absorb(), new Moves.Astonish() },
		[9] = new List<Move>() { new Moves.Growth() },
		[12] = new List<Move>() { new Moves.Rollout() },
		[18] = new List<Move>() { new Moves.Megadrain() },
		[24] = new List<Move>() { new Moves.Payback() },
		[30] = new List<Move>() { new Moves.Naturepower() },
		[36] = new List<Move>() { new Moves.Sunnyday() },
		[43] = new List<Move>() { new Moves.Extrasensory() },
		[50] = new List<Move>() { new Moves.Suckerpunch() },
		[57] = new List<Move>() { new Moves.Leafblade() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulletseed(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Explosion(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lashout(), new Moves.Leafblade(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychup(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Torment() };
	public override int Weight => 280;
	public override int ExpYield => 119;
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