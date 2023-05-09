using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Quilladin : Pokemon
{
	public override string Name => "Quilladin";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bulletproof() };
	public override Stats BaseStats => new Stats(61, 78, 95, 56, 58, 57);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Needlearm() },
		[1] = new List<Move>() { new Moves.Needlearm(), new Moves.Growl(), new Moves.Vinewhip() },
		[5] = new List<Move>() { new Moves.Vinewhip() },
		[8] = new List<Move>() { new Moves.Rollout() },
		[11] = new List<Move>() { new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Leechseed() },
		[19] = new List<Move>() { new Moves.Pinmissile() },
		[29] = new List<Move>() { new Moves.Takedown() },
		[35] = new List<Move>() { new Moves.Seedbomb() },
		[39] = new List<Move>() { new Moves.Mudshot() },
		[44] = new List<Move>() { new Moves.Bulkup() },
		[48] = new List<Move>() { new Moves.Bodyslam() },
		[52] = new List<Move>() { new Moves.Painsplit() },
		[56] = new List<Move>() { new Moves.Woodhammer() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dualchop(), new Moves.Endeavor(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Naturepower(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Toxic(), new Moves.Workup(), new Moves.Worryseed(), new Moves.Zenheadbutt() };
	public override int Weight => 290;
	public override int ExpYield => 142;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}