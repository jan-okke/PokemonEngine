using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cacnea : Pokemon
{
	public override string Name => "Cacnea";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterabsorb() };
	public override Stats BaseStats => new Stats(50, 85, 40, 85, 40, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Absorb() },
		[7] = new List<Move>() { new Moves.Growth() },
		[10] = new List<Move>() { new Moves.Leechseed() },
		[13] = new List<Move>() { new Moves.Sandattack() },
		[16] = new List<Move>() { new Moves.Poisonjab() },
		[19] = new List<Move>() { new Moves.Assurance() },
		[22] = new List<Move>() { new Moves.Ingrain() },
		[26] = new List<Move>() { new Moves.Payback() },
		[30] = new List<Move>() { new Moves.Spikes() },
		[34] = new List<Move>() { new Moves.Suckerpunch() },
		[38] = new List<Move>() { new Moves.Pinmissile() },
		[42] = new List<Move>() { new Moves.Energyball() },
		[46] = new List<Move>() { new Moves.Cottonspore() },
		[50] = new List<Move>() { new Moves.Sandstorm() },
		[54] = new List<Move>() { new Moves.Destinybond() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Nastyplot(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spite(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thunderpunch(), new Moves.Venoshock(), new Moves.Worryseed() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acid(), new Moves.Belch(), new Moves.Block(), new Moves.Counter(), new Moves.Disable(), new Moves.Dynamicpunch(), new Moves.Fellstinger(), new Moves.Lowkick(), new Moves.Magicalleaf(), new Moves.Poweruppunch(), new Moves.Seedbomb(), new Moves.Switcheroo(), new Moves.Teeterdance(), new Moves.Worryseed() };
	public override int Weight => 513;
	public override int ExpYield => 67;
	public override int CatchRate => 190;
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