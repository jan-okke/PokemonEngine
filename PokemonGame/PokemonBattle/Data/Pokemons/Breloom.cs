using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Breloom : Pokemon
{
	public override string Name => "Breloom";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Effectspore(), new Abilities.Poisonheal() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Technician() };
	public override Stats BaseStats => new Stats(60, 130, 80, 60, 60, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Machpunch() },
		[1] = new List<Move>() { new Moves.Machpunch(), new Moves.Absorb(), new Moves.Tackle(), new Moves.Stunspore(), new Moves.Leechseed() },
		[5] = new List<Move>() { new Moves.Stunspore() },
		[8] = new List<Move>() { new Moves.Leechseed() },
		[12] = new List<Move>() { new Moves.Megadrain() },
		[15] = new List<Move>() { new Moves.Headbutt() },
		[19] = new List<Move>() { new Moves.Feint() },
		[22] = new List<Move>() { new Moves.Counter() },
		[28] = new List<Move>() { new Moves.Forcepalm() },
		[33] = new List<Move>() { new Moves.Mindreader() },
		[39] = new List<Move>() { new Moves.Drainpunch() },
		[44] = new List<Move>() { new Moves.Seedbomb() },
		[50] = new List<Move>() { new Moves.Dynamicpunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lowsweep(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thunderpunch(), new Moves.Venoshock(), new Moves.Workup(), new Moves.Worryseed() };
	public override int Weight => 392;
	public override int ExpYield => 161;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}